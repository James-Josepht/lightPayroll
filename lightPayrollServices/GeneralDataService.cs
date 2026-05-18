using Dapper;
using lightPayrollModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite; 
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace lightPayrollServices
{
    //this is where the most common sql queries happened
    public class GeneralDataService
    {

        // all these changes in the database can be seen in lightPayroll\bin\Debug\net8.0-windows\lightPayrollDB.db
        // not the one in lightPayroll\lightPayrollDB.db

        /// 
        ///                LOAD SECTION
        /// 

        public List<UserDisplay> LoadUsers()//used for displaying the users, not for authentication
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                // Step 1: Ensure the table exists
                string createTableSql = @"
                CREATE TABLE IF NOT EXISTS UsersTable (
                UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                Role TEXT CHECK(Role IN ('Admin','Manager','Accountant','Employee')) NOT NULL,
                AccountStatus TEXT CHECK(AccountStatus IN ('Pending','Active','Rejected')) DEFAULT 'Pending',
                DateCreated TEXT DEFAULT CURRENT_TIMESTAMP
                );";

                conn.Execute(createTableSql);  // Dapper extension method for non-query commands

                // Step 2: Query the table
                var output = conn.Query<UserDisplay>("SELECT UsersID, Username, Role, AccountStatus, DateCreated FROM UsersTable", new DynamicParameters());

                var users = output.Select(u =>
                {
                    u.DateCreated = u.DateCreated.Value.ToLocalTime(); // converts to user local time (converting the database time)
                    return u;
                }).ToList();


                return users;
            }
        }


        public List<EmployeeDisplay> LoadEmployeeWithUser()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                var result = conn.Query<EmployeeDisplay>(
                    @"SELECT 
                e.EmployeeID,
                e.FirstName,
                IFNULL(e.MiddleName, '-') AS MiddleName,
                e.LastName,
                u.Username,
                u.Role
              FROM EmployeesTable e
              JOIN UsersTable u ON e.UsersID = u.UsersID"
                ).ToList();

                return result;
            }
        }

        /// 
        /// INSERTION PART (DILI INTAWN NI AI AKONG COMMENT!)
        /// 
        /// 

        public  void InsertUser(Users user)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                INSERT INTO UsersTable 
                (Username, Password, Role, AccountStatus) 
                VALUES (@Username, @Password, @Role, @AccountStatus);";

                conn.Execute(sql, user);
            }
        }

        public  bool InsertEmployee(Employee employee) //look into insertUser reference to know the process
        {
            var existingEmployee = GetEmployeeByID(employee.EmployeeID);

            if (existingEmployee != null)
                return false;

            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                INSERT INTO EmployeesTable
                (UsersID, FirstName, LastName, Position, DateHired)
                VALUES
                (@UsersID, @FirstName, @LastName, @Position, @DateHired);";

                conn.Execute(sql, employee);
            }
            return true;
        }



        public void InsertLeave(int employeeId, string leaveType, string startDate, string endDate, string reason, int? id = null)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT INTO LeaveRequestsTable (EmployeeID, LeaveType, StartDate, EndDate, Reason, ApprovedBy)
                       VALUES (@EmployeeID, @LeaveType, @StartDate, @EndDate, @Reason, @ApprovedBy)";

                conn.Execute(sql, new
                {
                    EmployeeID = employeeId,
                    StartDate = startDate,
                    EndDate = endDate,
                    LeaveType = leaveType,
                    Reason = reason,
                    ApprovedBy = id
                });
            }
        }

        public void InsertOvertime(int employeeId, string date, string type)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"INSERT INTO OvertimeRequestsTable (EmployeeID, Date, Reason)
                       VALUES (@EmployeeID, @Date, @Reason)";

                conn.Execute(sql, new
                {
                    EmployeeID = employeeId,
                    Date = date,
                    Reason = type
                });
            }
        }


        /// 
        /// SEARCHING PART
        /// 
        /// 

        public string GetFullNameByEmployeeId(int employeeId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                return conn.QueryFirstOrDefault<string>(
                    @"SELECT FirstName || ' ' || LastName
              FROM EmployeesTable
              WHERE EmployeeID = @EmployeeID",
                    new { EmployeeID = employeeId }
                );
            }
        }

        public int GetEmployeeIdByUserId(int usersID) //used to get id not employee itself
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var employeeId = conn.QueryFirstOrDefault<int>(
                    @"SELECT EmployeeID 
              FROM EmployeesTable 
              WHERE UsersID = @UsersID",
                    new { UsersID = usersID });

                return employeeId;
            }
        }


        //THE QUERY WILL LAG ONCE USER REACHES HUGE NUMBER, NEED TO OPTIMIZE IN THE FUTURE!
        public List<EmployeeDisplay> GetEmployeeByName(string fullname)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                SELECT 
                    e.EmployeeID,
                    e.UsersID,
                    e.FirstName,
                    e.MiddleName,
                    e.LastName,
                    e.Position,
                    u.Username,
                    u.Role
                FROM EmployeesTable e
                INNER JOIN UsersTable u ON e.UsersID = u.UsersID
                WHERE REPLACE(
                LOWER(TRIM(e.FirstName || ' ' || IFNULL(e.MiddleName, '') || ' ' || e.LastName)), 
                '  ', ' '
            ) LIKE LOWER(@Name);";

               
                // It's often safer to Trim the input from the user as well
                string searchPattern = "%" + fullname.Trim() + "%";

                return conn.Query<EmployeeDisplay>(sql, new { Name = searchPattern }).ToList();

            }
        }

        public Employee GetEmployeeByID(int? usersId = null, int? employeeID = null) 
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                SELECT 
                    e.EmployeeID,
                    e.UsersID,
                    e.FirstName,
                    e.MiddleName,
                    e.LastName,
                    e.Position,
                    e.Email,
                    u.Username,
                    u.Role
                FROM EmployeesTable e
                INNER JOIN UsersTable u ON e.UsersID = u.UsersID
                WHERE 1=1";

                if (usersId.HasValue)
                {
                    sql += " AND e.UsersID = @UsersID";
                }
                else if (employeeID.HasValue)
                {
                    sql += " AND e.EmployeeID = @EmployeeID";
                }
                else
                {
                    return null; // nothing to search
                }

                sql += " LIMIT 1;";

                return conn.QueryFirstOrDefault<Employee>(sql, new
                {
                    UsersID = usersId,
                    EmployeeID = employeeID
                });
            }
        }

        public int GetUserIdByUsername(string username)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                string sql = "SELECT UsersID FROM UsersTable WHERE Username = @Username LIMIT 1";
                int? userId = conn.QueryFirstOrDefault<int?>(sql, new { Username = username });


                return userId ?? -1; // no exception
            }
        }

        public AdminUser GetUserByIdOrUsername(string input)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                int id;
                bool isNumeric = int.TryParse(input, out id);

                string sql = isNumeric
                    ? "SELECT * FROM UsersTable WHERE UsersID = @Input LIMIT 1"
                    : "SELECT * FROM UsersTable WHERE Username = @Input LIMIT 1";

                return conn.QueryFirstOrDefault<AdminUser>(sql, new { Input = isNumeric ? (object)id : input });
            }
        }
        public List<UserDisplay> SearchUsersByUsername(string input)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {

                string sql = "SELECT * FROM UsersTable WHERE Username LIKE @Input";
                var users = conn.Query<UserDisplay>(sql, new { Input = $"%{input}%" }).ToList();

                return users;
            }
        }

        

        public string GetUserRoleByUsername(string username)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT Role FROM UsersTable WHERE Username = @Username LIMIT 1";

                return conn.QueryFirstOrDefault<string>(sql, new { Username = username });
            }
        }

        public (int MinYear, int MaxYear) GetRegistrationYearRange()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                SELECT 
                    MIN(strftime('%Y', DateCreated)) AS MinYear,
                    MAX(strftime('%Y', DateCreated)) AS MaxYear
                FROM UsersTable";

                var result = conn.QueryFirstOrDefault<(string MinYear, string MaxYear)>(sql);

                return (int.Parse(result.MinYear), int.Parse(result.MaxYear));
            }
        }

        public IEnumerable<(int Month, int Total)> GetRegistrationsPerMonth(int year)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var sql = @"
                SELECT 
                    strftime('%m', DateCreated) AS Month,
                    COUNT(*) AS Total
                FROM UsersTable
                WHERE strftime('%Y', DateCreated) = @Year
                GROUP BY Month
                ORDER BY Month;";

                return conn.Query<(string Month, int Total)>(sql, new { Year = year.ToString() })
                    .Select(x => (int.Parse(x.Month), x.Total));
            }
        }

       

        public int GetUserCount() 
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT COUNT(*) FROM UsersTable";
                return conn.ExecuteScalar<int>(sql);
            }
        }

        public int GetUserCountByRole(string role)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT COUNT(*) FROM UsersTable WHERE Role = @Role";
                return conn.ExecuteScalar<int>(sql, new { Role = role });
            }
        }

        


        /// 
        /// UPDATE PART
        /// 



        public void UpdateUserStatus(int userId, string status, string role)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                UPDATE UsersTable 
                SET AccountStatus = @Status, Role = @Role
                WHERE UsersID = @UsersID";


                conn.Execute(sql, new { Status = status, Role = role, UsersID = userId });
            }
        }
        public void UpdateEmployeeStatus(string role, int id)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                UPDATE EmployeesTable 
                SET Position = @Position
                WHERE UsersID = @UsersID";


                conn.Execute(sql, new { Position = role, UsersID = id});
            }
        }

      

        ///
        /// DELETE PART
        ///


        public bool DeleteUser(int userId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                // check if user is used
                int count = conn.ExecuteScalar<int>(
                    "SELECT COUNT(1) FROM EmployeesTable WHERE UsersID = @UsersID",
                    new { UsersID = userId });

                if (count > 0)
                {
                    return false; // cannot delete
                }

                string sql = "DELETE FROM UsersTable WHERE UsersID = @UsersID";
                conn.Execute(sql, new { UsersID = userId });

                return true;
            }
        }







        /// 
        /// INITIALIZATION OF DATABASE (AYAW INTAWN HILABTI!)
        ///
 
        public static string LoadConnectionString(string id = "DefaultConnection")// goes to App.config to get the connection string with the name "Default"
        {
            var connStrings = ConfigurationManager.ConnectionStrings[id].ConnectionString;

            if (connStrings == null)
            {
                throw new Exception($"Connection string '{id}' not found.");
            }

            return connStrings;
        }
    }

}
