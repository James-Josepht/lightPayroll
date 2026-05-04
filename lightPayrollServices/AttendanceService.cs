using Dapper;
using lightPayrollModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightPayrollServices
{
    public class AttendanceService:SQLiteDataAccess
    {
        /// 
        /// LOADING
        /// PART
        /// 

        public List<AttendanceCore> LoadAttendanceCore()//used for displaying the user only
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                conn.Execute("PRAGMA foreign_keys = ON;");

                // Step 1: Ensure the table exists
                string createTableSql = @"
               CREATE TABLE IF NOT EXISTS AttendanceTable (
	            AttendanceID	INTEGER NOT NULL UNIQUE,
	            EmployeeID	INTEGER NOT NULL,
	            FullName	TEXT NOT NULL,
	            Date	TEXT NOT NULL,
	            TimeIn	TEXT NOT NULL,
	            TimeOut	TEXT NOT NULL,
	            Status	TEXT NOT NULL,
	            Remarks	TEXT NOT NULL,
	            PRIMARY KEY(AttendanceID AUTOINCREMENT),
                FOREIGN KEY (EmployeeID) REFERENCES EmployeesTable(EmployeeID) 

                ON DELETE CASCADE
                ON UPDATE CASCADE
                );";

                conn.Execute(createTableSql);  // Dapper extension method for non-query commands

                // Step 2: Query the table
                var output = conn.Query<AttendanceCore>(
                 @"SELECT EmployeeID, Date, TimeIn, TimeOut, Status, Remarks
                  FROM AttendanceTable
                  ORDER BY Date DESC",
                 new DynamicParameters());

                var attendances = output.ToList();


                return attendances;
            }
        }

        public List<AttendanceAdmin> LoadAttendanceAdmin()//used for displaying all attendance
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                conn.Execute("PRAGMA foreign_keys = ON;");

                // Step 1: Ensure the table exists
                string createTableSql = @"
               CREATE TABLE IF NOT EXISTS AttendanceTable (
	            AttendanceID	INTEGER NOT NULL UNIQUE,
	            EmployeeID	INTEGER NOT NULL,
	            FullName	TEXT NOT NULL,
	            Date	TEXT NOT NULL,
	            TimeIn	TEXT NOT NULL,
	            TimeOut	TEXT NOT NULL,
	            Status	TEXT NOT NULL,
	            Remarks	TEXT NOT NULL,
	            PRIMARY KEY(AttendanceID AUTOINCREMENT),
                FOREIGN KEY (EmployeeID) REFERENCES EmployeesTable(EmployeeID) 

                ON DELETE CASCADE
                ON UPDATE CASCADE
                );";

                conn.Execute(createTableSql);  // Dapper extension method for non-query commands

                // Step 2: Query the table
                var output = conn.Query<AttendanceAdmin>(
                 @"SELECT AttendanceID, EmployeeID, Date, TimeIn, TimeOut, Status, Remarks
                  FROM AttendanceTable
                  ORDER BY Date DESC",
                 new DynamicParameters());

                var attendances = output.ToList();


                return attendances;
            }
        }

        public List<AttendanceUser> LoadUserAttendanceById(int employeeID)
        {

            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<AttendanceUser>(
                 @"SELECT EmployeeID, Date, TimeIn, TimeOut, Status, Remarks
                  FROM AttendanceTable       
                  WHERE EmployeeID = @EmployeeID
                     ORDER BY Date DESC",
                 new { EmployeeID = employeeID });

                var attendances = output.Select(u =>
                {
                    u.Date = u.Date;
                    u.TimeIn = u.TimeIn;
                    u.TimeOut = u.TimeOut;
                    return u;
                }).ToList();
                return attendances;
            }
        }
        

        /// 
        /// INSERTING PART 
        /// 


        public int InsertClock(AttendanceUser user, int employeeID, string fullName)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                    string sql = @"
            INSERT INTO AttendanceTable 
            (EmployeeID, FullName, Date, TimeIn, TimeOut, Status, Remarks)
            VALUES (@EmployeeID, @FullName, @Date, @TimeIn, @TimeOut, @Status, @Remarks);";

                conn.Execute(sql, new
                {
                    EmployeeID = employeeID,
                    FullName = fullName,
                    Date = user.Date ?? DateTime.Now,
                    TimeIn = user.TimeIn ?? DateTime.Now,
                    TimeOut = user.TimeOut,
                    Status = user.Status,
                    Remarks = string.IsNullOrWhiteSpace(user.Remarks) ? "Pending" : user.Remarks
                });

                //INSERT → SQLite generates AttendanceID
                //SELECT last_insert_rowid() → gets that ID
                //return ID → you store it in app

                int attendanceID = conn.ExecuteScalar<int>("SELECT last_insert_rowid();");
                return attendanceID;
            }

           
        }


        /// 
        /// 
        /// UPDATING
        /// PART
        /// 
        
        public void UpdateClockOut(int attendanceId, DateTime timeOut)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute(
                    @"UPDATE AttendanceTable
              SET TimeOut = @TimeOut
              WHERE AttendanceID = @AttendanceID;",
                    new
                    {
                        TimeOut = timeOut,
                        AttendanceID = attendanceId
                    });
            }
        }

        public void UpdateEmployeeProfile(int id, string middleName = null, string email = null)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute(
                    @"UPDATE EmployeesTable
              SET MiddleName = @MiddleName, Email = @Email
              WHERE UsersID = @UsersID;",
                    new
                    {
                        Email = email,
                        MiddleName = middleName,
                        UsersID = id
                    });
            }
        }




        //
        // GETTING / SEARCHING
        //

      

        public int GetAttendanceCountToday()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql =
                @"SELECT COUNT(*) FROM AttendanceTable
                WHERE date(Date) = date('now','localtime')";
                
                return conn.ExecuteScalar<int>(sql);
            }
        }

        public int GetAttendanceCountByStatus(string status)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                SELECT COUNT(*) 
                FROM AttendanceTable 
                WHERE Status = @Status 
                AND date(Date) = date('now','localtime')";

                return conn.ExecuteScalar<int>(sql, new { Status = status });
            }
        }
        public int GetActiveAttendanceId(int employeeID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                return conn.ExecuteScalar<int>(
                    @"SELECT AttendanceID
              FROM AttendanceTable
              WHERE EmployeeID = @EmployeeID
              AND TimeOut IS NULL
              ORDER BY Date DESC
              LIMIT 1;",
                    new { EmployeeID = employeeID });
            }
        }


        public bool HasClockedInToday(int employeeID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                DateTime start = DateTime.Now.Date;
                DateTime end = start.AddDays(1);

                var count = conn.ExecuteScalar<int>(
                    @"SELECT COUNT(1)
              FROM AttendanceTable
              WHERE EmployeeID = @EmployeeID
              AND Date >= @Start
              AND Date < @End
              AND TimeIn IS NOT NULL",
                    new
                    {
                        EmployeeID = employeeID,
                        Start = start,
                        End = end
                    });

                return count > 0;
            }
        }

        public bool HasClockedOutToday(int employeeID)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                return conn.ExecuteScalar<int>(
                    @"SELECT COUNT(1)
              FROM AttendanceTable
              WHERE EmployeeID = @EmployeeID
              AND TimeOut IS NOT NULL
              AND TimeIn IS NOT NULL
              AND DATE(Date) = DATE('now','localtime')",
                    new { EmployeeID = employeeID }) > 0;
            }
        }

       
    }
}
