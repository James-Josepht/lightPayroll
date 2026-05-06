using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lightPayrollServices
{
    public class RequestsService: GeneralDataService
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
                        CAST(strftime('%m', Date) AS INTEGER) AS Month,
                        COUNT(*) AS Total
                    FROM LeaveRequestsTable
                    WHERE strftime('%Y', Date) = @year
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
                        MIN(strftime('%Y', Date)) AS MinYear,
                        MAX(strftime('%Y', Date)) AS MaxYear
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
}
}
