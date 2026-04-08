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
        public static List<AttendanceUser> LoadUserAttendance()//used for displaying the user only
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
                FOREIGN KEY (UserID) REFERENCES UsersTable(UsersID)

                ON DELETE CASCADE
                ON UPDATE CASCADE
                );";

                conn.Execute(createTableSql);  // Dapper extension method for non-query commands

                // Step 2: Query the table
                var output = conn.Query<AttendanceUser>("SELECT  Date, TimeIn, TimeOut, Status, Remarks FROM AttendanceTable", new DynamicParameters());

                var attendances = output.Select(u =>
                {
                    u.Date = u.Date?.ToLocalTime();
                    u.TimeIn = u.TimeIn?.ToLocalTime();
                    u.TimeOut = u.TimeOut?.ToLocalTime();
                    return u;
                }).ToList();


                return attendances;
            }
        }

        public static void InsertClock(AttendanceUser user, int userId, string fullName)
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
                    Date = user.Date?.ToUniversalTime(),       // store UTC
                    TimeIn = user.TimeIn?.ToUniversalTime(),
                    TimeOut = user.TimeOut?.ToUniversalTime(),
                    Status = user.Status,
                    Remarks = user.Remarks
                });
            }
        }

        public static bool HasClockedInToday(int userId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                // Get LOCAL day (PH time)
                var localNow = DateTime.Now;
                var localStart = localNow.Date;
                var localEnd = localStart.AddDays(1);

                // Convert to UTC
                var utcStart = localStart.ToUniversalTime();
                var utcEnd = localEnd.ToUniversalTime();

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
                        Start = utcStart,
                        End = utcEnd
                    });

                return count > 0;
            }
        }

        public static void UpdateClockOut(int userId, DateTime timeOut)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                UPDATE AttendanceTable
                SET TimeOut = @TimeOut
                WHERE UsersID = @UsersID 
                AND DATE(Date) = DATE(@Date);"; // safer date comparison

                conn.Execute(sql, new
                {
                    TimeOut = timeOut.ToUniversalTime(),
                    UsersID = userId,
                    Date = DateTime.UtcNow // compare dates safely
                });
            }
        }

        public static List<AttendanceUser> LoadUserAttendanceById(int userId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<AttendanceUser>("SELECT Date, TimeIn, TimeOut, Status, Remarks FROM AttendanceTable WHERE UsersID = @UsersID", new { UsersID = userId });
                var attendances = output.Select(u =>
                {
                    u.Date = u.Date?.ToLocalTime();
                    u.TimeIn = u.TimeIn?.ToLocalTime();
                    u.TimeOut = u.TimeOut?.ToLocalTime();
                    return u;
                }).ToList();
                return attendances;
            }
        }

    }
}
