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
    public class AttendanceService:GeneralDataService
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

        public IEnumerable<(int Month, int Present, int Late, int Leave)> GetMonthlyAttendanceBreakdown(int year)
        {
            var result = new List<(int, int, int, int)>();

            for (int month = 1; month <= 12; month++)
            {
                int present = GetAttendanceCountByMonthAndStatus(year, month, "Present");
                int late = GetAttendanceCountByMonthAndStatus(year, month, "Late");
                int leave = GetAttendanceCountByMonthAndStatus(year, month, "Leave");

                result.Add((month, present, late, leave));
            }

            return result;
        }
        public int GetAttendanceCountByMonthAndStatus(int year, int month, string status)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM AttendanceTable
                    WHERE strftime('%Y', Date) = ?
                    AND strftime('%m', Date) = ?
                    AND Status = ?
                ";

                using (var cmd = new SQLiteCommand(query, (SQLiteConnection)conn))
                {
                    cmd.Parameters.AddWithValue("@year", year.ToString());
                    cmd.Parameters.AddWithValue("@month", month.ToString("00"));
                    cmd.Parameters.AddWithValue("@status", status);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        

        public (int MinYear, int MaxYear) GetAttendanceYearRange()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
                SELECT 
                    MIN(strftime('%Y', Date)) AS MinYear,
                    MAX(strftime('%Y', Date)) AS MaxYear
                FROM AttendanceTable";

                var result = conn.QueryFirstOrDefault<(string MinYear, string MaxYear)>(sql);

                return (int.Parse(result.MinYear), int.Parse(result.MaxYear));
            }
        }


        public (int present, int late, int leave) GetAttendanceCountToday()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string sql = @"
            SELECT
                SUM(CASE WHEN Status = 'Present' THEN 1 ELSE 0 END) AS Present,
                SUM(CASE WHEN Status = 'Late' THEN 1 ELSE 0 END) AS Late,
                SUM(CASE WHEN Status = 'Leave' THEN 1 ELSE 0 END) AS Leave
            FROM AttendanceTable
            WHERE date(Date) = date('now','localtime');
              ";

                using (var cmd = new SQLiteCommand(sql, (SQLiteConnection)conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int present = reader["Present"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Present"]);
                        int late = reader["Late"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Late"]);
                        int leave = reader["Leave"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Leave"]);

                        return (present, late, leave);
                    }
                }

                return (0, 0, 0);
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
