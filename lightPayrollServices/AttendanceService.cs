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
        public static List<AttendanceAdmin> LoadUserAttendance()//used for displaying the user only
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();
                conn.Execute("PRAGMA foreign_keys = ON;");

                // Step 1: Ensure the table exists
                string createTableSql = @"
               CREATE TABLE IF NOT EXISTS AttendanceTable (
	            AttendanceID	INTEGER NOT NULL UNIQUE,
	            UsersID	INTEGER NOT NULL,
	            FullName	TEXT NOT NULL,
	            Date	TEXT NOT NULL,
	            TimeIn	TEXT NOT NULL,
	            TimeOut	TEXT NOT NULL,
	            Status	TEXT NOT NULL,
	            Remarks	TEXT NOT NULL,
	            PRIMARY KEY(AttendanceID AUTOINCREMENT),
                FOREIGN KEY (UsersID) REFERENCES UsersTable(UsersID) 

                ON DELETE CASCADE
                ON UPDATE CASCADE
                );";

                conn.Execute(createTableSql);  // Dapper extension method for non-query commands

                // Step 2: Query the table
                var output = conn.Query<AttendanceAdmin>("SELECT Date, TimeIn, TimeOut, Status, Remarks FROM AttendanceTable", new DynamicParameters());

                var attendances = output.ToList();


                return attendances;
            }
        }

        public static int InsertClock(AttendanceUser user, int userId, string fullName)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                    string sql = @"
            INSERT INTO AttendanceTable 
            (UsersID, FullName, Date, TimeIn, TimeOut, Status, Remarks)
            VALUES (@UsersID, @FullName, @Date, @TimeIn, @TimeOut, @Status, @Remarks);";

                conn.Execute(sql, new
                {
                    UsersID = userId,
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

        public static bool HasClockedInToday(int userId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                DateTime start = DateTime.Now.Date;
                DateTime end = start.AddDays(1);

                var count = conn.ExecuteScalar<int>(
                    @"SELECT COUNT(1)
              FROM AttendanceTable
              WHERE UsersID = @UsersID
              AND Date >= @Start
              AND Date < @End
              AND TimeIn IS NOT NULL",
                    new
                    {
                        UsersID = userId,
                        Start = start,
                        End = end
                    });

                return count > 0;
            }
        }
        public static void UpdateClockOut(int attendanceId, DateTime timeOut)
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

        public static int GetActiveAttendanceId(int userId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                return conn.ExecuteScalar<int>(
                    @"SELECT AttendanceID
              FROM AttendanceTable
              WHERE UsersID = @UsersID
              AND TimeOut IS NULL
              ORDER BY Date DESC
              LIMIT 1;",
                    new { UsersID = userId });
            }
        }

        public static bool HasClockedOutToday(int userId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                return conn.ExecuteScalar<int>(
                    @"SELECT COUNT(1)
              FROM AttendanceTable
              WHERE UsersID = @UsersID
              AND TimeOut IS NOT NULL
              AND TimeIn IS NOT NULL
              AND DATE(Date) = DATE('now','localtime')",
                    new { UsersID = userId }) > 0;
            }
        }

        public static List<AttendanceUser> LoadUserAttendanceById(int userId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<AttendanceUser>("SELECT Date, TimeIn, TimeOut, Status, Remarks FROM AttendanceTable WHERE UsersID = @UsersID", new { UsersID = userId });
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

        public decimal CalculateHours(DateTime timeIn, DateTime timeOut)
        {
            TimeSpan total = timeOut - timeIn;

            // convert to decimal hours (e.g., 8.5 hours)
            return (decimal)total.TotalHours;
        }
        public decimal CalculateOvertime(decimal totalHours)
        {
            if (totalHours > 8)
                return totalHours - 8;

            return 0;
        }
    }
}
