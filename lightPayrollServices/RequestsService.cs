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
    public class RequestsService: GeneralDataService //updating and inserting attendance after approve request is in general
    {
       
        // ----------------------------
        // DAILY / TOTAL COUNTS
        // ----------------------------

        public int GetRequestCountByStatus(string status)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string sql = @"
                    SELECT COUNT(*)
                    FROM LeaveRequestsTable
                    WHERE Status = @status
                ";

                using (var cmd = new SQLiteCommand(sql, (SQLiteConnection)conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // ----------------------------
        // MONTHLY TREND
        // ----------------------------

        public IEnumerable<(int Month, int Total)> GetRequestsPerMonth(int year)
        {
            var result = new List<(int, int)>();

            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string sql = @"
                    SELECT
                        CAST(strftime('%m', StartDate) AS INTEGER) AS Month,
                        COUNT(*) AS Total
                    FROM LeaveRequestsTable
                    WHERE strftime('%Y', StartDate) = @year
                    GROUP BY Month
                ";

                using (var cmd = new SQLiteCommand(sql, (SQLiteConnection)conn))
                {
                    cmd.Parameters.AddWithValue("@year", year.ToString());

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add((
                                Convert.ToInt32(reader["Month"]),
                                Convert.ToInt32(reader["Total"])
                            ));
                        }
                    }
                }
            }

            return result;
        }

        // ----------------------------
        // YEAR RANGE (for dashboard nav)
        // ----------------------------

        public (int MinYear, int MaxYear) GetRequestYearRange()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        MIN(strftime('%Y', StartDate)) AS MinYear,
                        MAX(strftime('%Y', StartDate)) AS MaxYear
                    FROM LeaveRequestsTable
                ";

                using (var cmd = new SQLiteCommand(sql, (SQLiteConnection)conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int minYear = reader["MinYear"] == DBNull.Value
                            ? DateTime.Now.Year
                            : Convert.ToInt32(reader["MinYear"]);

                        int maxYear = reader["MaxYear"] == DBNull.Value
                            ? DateTime.Now.Year
                            : Convert.ToInt32(reader["MaxYear"]);

                        return (minYear, maxYear);

                    }
                }
            }

            return (DateTime.Now.Year, DateTime.Now.Year);
        }

        // ----------------------------
        // LOAD PART
        // ----------------------------

        public List<OvertimeRequest> LoadOvertimeRequests()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<OvertimeRequest>(
                 @"SELECT *
                  FROM OvertimeRequestsTable
                  ORDER BY Date DESC",
                 new DynamicParameters());

                var attendances = output.ToList();


                return attendances;
            }
        }

        public List<LeaveRequest> LoadLeaveRequests()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<LeaveRequest>(
                 @"SELECT LeaveID, LeaveType, EmployeeID, StartDate, EndDate, Reason, Status
                   FROM LeaveRequestsTable
                   ORDER BY 
                       CASE 
                           WHEN Status = 'Pending' THEN 0
                           ELSE 1
                       END,
                       StartDate ASC",
                 new DynamicParameters());

                return output.ToList();
            }
        }

        // ----------------------------
        // GETTING PART
        // ----------------------------
       


        public List<LeaveRequest> SearchLeaveRequests(int id) 
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<LeaveRequest>(
                 @"SELECT *
                   FROM LeaveRequestsTable
                   WHERE EmployeeID = @EmployeeID
                    ORDER BY 
                       CASE 
                           WHEN Status = 'Pending' THEN 0
                           ELSE 1
                       END,
                       StartDate ASC",
                 new { EmployeeID = id });

                return output.ToList();
            }
        }


        // ----------------------------
        // UPDATING PART
        // ----------------------------

        //update based on leave request ID
        public void UpdateLeaveStatus(int leaveRequestId, string status)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute(
                    @"UPDATE LeaveRequestsTable
              SET Status = @Status
              WHERE LeaveID = @Id",
                    new
                    {
                        Id = leaveRequestId,
                        Status = status
                    });
            }
        }
    }
}
