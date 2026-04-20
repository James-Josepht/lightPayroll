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
    public class SQLiteDataAccess
    {

        // all these changes in the database can be seen in lightPayroll\bin\Debug\net8.0-windows\lightPayrollDB.db
        // not the one in lightPayroll\lightPayrollDB.db

        /// 
        ///                LOAD SECTION
        /// 

        public static List<UserDisplay> LoadUsers()//used for displaying the users, not for authentication
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


        public static List<EmployeeDisplay> LoadEmployeeWithUser()
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

        public static void InsertUser(Users user)
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

        public static void InsertEmployee(Employee employee)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
        INSERT INTO EmployeeTable
        (UsersID, FirstName, MiddleName, LastName, Position, Department, DateHired, SalaryRate)
        VALUES
        (@UsersID, @FirstName, @MiddleName, @LastName, @Position, @Department, @DateHired, @SalaryRate);";

                conn.Execute(sql, employee);
            }
        }

        public static void InsertPayroll(Payroll payroll)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string sql = @"
        INSERT INTO Payroll
        (EmployeeID, BasicSalary, OvertimePay, SSS, PhilHealth, PagIBIG, WithholdingTax, Deductions, NetSalary, PayrollDate, ProcessedBy)
        VALUES
        (@EmployeeID, @BasicSalary, @OvertimePay, @SSS, @PhilHealth, @PagIBIG, @WithholdingTax, @Deductions, @NetSalary, @PayrollDate, @ProcessedBy)";

                conn.Execute(sql, payroll);
            }
        }


        /// 
        /// SEARCHING PART
        /// 
        /// 


        public static Employee GetEmployeeByID(int id)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                SELECT 
                    e.EmployeeID,
                    e.UsersID,
                    e.FirstName,
                    e.LastName,
                    e.Position,
                    u.Username,
                    u.Role
                FROM EmployeesTable e
                INNER JOIN UsersTable u ON e.UsersID = u.UsersID
                WHERE e.UsersID = @UsersID
                LIMIT 1;";

                return conn.QueryFirstOrDefault<Employee>(sql, new { UsersID = id });
            }
        }

        public static int GetUserIdByUsername(string username)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                string sql = "SELECT UsersID FROM UsersTable WHERE Username = @Username LIMIT 1";
                int? userId = conn.QueryFirstOrDefault<int?>(sql, new { Username = username });


                return userId ?? -1; // no exception
            }
        }

        public static AdminUser GetUserByIdOrUsername(string input)
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
        public static List<UserDisplay> SearchUsersByUsername(string input)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {

                string sql = "SELECT * FROM UsersTable WHERE Username LIKE @Input";
                var users = conn.Query<UserDisplay>(sql, new { Input = $"%{input}%" }).ToList();

                return users;
            }
        }

        

        public static string GetUserRoleByUsername(string username)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT Role FROM UsersTable WHERE Username = @Username LIMIT 1";

                return conn.QueryFirstOrDefault<string>(sql, new { Username = username });
            }
        }

        

        /// 
        /// UPDATE PART
        /// 



        public static void UpdateUserStatus(int userId, string status, string role)
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


       



        ////////////////////////////////////////////////////////////////////// //////////////
        /// FOR GETTING THE TOTAL NUMBER OF USERS IN THE DATABASE, USED IN ADMIN DASHBOARD 
        /// 
        /// I DECIDE HOW TO COMMENT HEHEHEHE
        ////////////////////////////////////////////////////////////////////////////////////
        public static int GetUserCount()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT COUNT(*) FROM UsersTable";
                return conn.ExecuteScalar<int>(sql);
            }
        }

        public static int GetUserCountByRole(string role)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "SELECT COUNT(*) FROM UsersTable WHERE Role = @Role";
                return conn.ExecuteScalar<int>(sql, new { Role = role });
            }
        }




        /// 
        /// INITIALIZATION OF DATABASE (AYAW INTAWN HILABTI!)
        ///
 
        protected static string LoadConnectionString(string id = "DefaultConnection")// goes to App.config to get the connection string with the name "Default"
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
