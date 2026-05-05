using Dapper;
using lightPayrollModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;

namespace lightPayrollServices
{
    public class PayrollService : SQLiteDataAccess
    {

        private decimal ComputePagIbig(decimal monthlySalary)
        {
            decimal cappedSalary = monthlySalary > 10000 ? 10000 : monthlySalary;

            decimal rate = cappedSalary <= 1500 ? 0.01m : 0.02m;

            decimal employeeShare = cappedSalary * rate;

            // Cap rule from your table
            if (cappedSalary > 10000)
                return 200m;

            return employeeShare;
        }

        private decimal ComputeTax(decimal taxableIncome)
        {
            if (taxableIncome <= 10417)
                return 0;
            else if (taxableIncome <= 16666)
                return 0.20m * (taxableIncome - 10417);
            else if (taxableIncome <= 33332)
                return 1250 + (0.25m * (taxableIncome - 16667));
            else if (taxableIncome <= 83332)
                return 5416.67m + (0.30m * (taxableIncome - 33333));
            else if (taxableIncome <= 333332)
                return 20416.67m + (0.32m * (taxableIncome - 83333));
            else
                return 100416.67m + (0.35m * (taxableIncome - 333333));
        }

        public Payroll CalculateFirst(
                    int employeeId,
                    decimal hourlyRate,
                    int processedBy,
                    DateTime periodStart,
                    DateTime periodEnd,
                    DateTime payrollDate)
        {
            var (hoursWorked, overtimeHours) =
                GetHoursWithOvertime(employeeId, periodStart, periodEnd);

            decimal basicSalary = hourlyRate * hoursWorked;
            decimal overtimePay = overtimeHours * hourlyRate * 1.25m;

            decimal grossPay = basicSalary + overtimePay;
            decimal tax = ComputeTax(grossPay);

            decimal netPay = grossPay - tax;
            if (netPay < 0) netPay = 0;

            return new Payroll
            {
                EmployeeID = employeeId,
                HourlyRate = hourlyRate,
                BasicSalary = basicSalary,
                OvertimePay = overtimePay,
                SSS = 0,
                PhilHealth = 0,
                PagIBIG = 0,
                WithholdingTax = tax,
                Deductions = tax,
                NetPay = netPay,
                PayrollDate = payrollDate.ToString("yyyy-MM-dd"),
                PayrollCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm tt"),
                ApprovedBy = processedBy,
                PeriodStart = periodStart.ToString("yyyy-MM-dd"),
                PeriodEnd = periodEnd.ToString("yyyy-MM-dd")
            };
        }

        //second month full deductions including government
        public Payroll CalculateSecond(int employeeId, decimal hourlyRate,
                                          decimal otherDeductions, int processedBy,
                                        DateTime periodStart, DateTime periodEnd, DateTime payrollDate)

        {
            // compute hours based on selected period
            var (hoursWorked, overtimeHours) =
                GetHoursWithOvertime(employeeId, periodStart, periodEnd);

            decimal basicSalary = hourlyRate * hoursWorked;
            decimal overtimePay = overtimeHours * hourlyRate * 1.25m;
            decimal leavePay = 0;

            decimal monthlyRate = (basicSalary + overtimePay) * 2; // Assuming this is the monthly equivalent for deductions
            decimal pagIbig = ComputePagIbig(monthlyRate);

            // SSS
            decimal msc = monthlyRate < 5000 ? 5000 :
                          monthlyRate > 35000 ? 35000 : monthlyRate;

            decimal sss = msc * 0.05m;

            // PhilHealth
            decimal salaryPH = monthlyRate < 10000 ? 10000 :
                               monthlyRate > 100000 ? 100000 : monthlyRate;

            decimal philHealth = (salaryPH * 0.05m) / 2;

            decimal grossPay = basicSalary + overtimePay + leavePay;
            decimal taxableIncome = grossPay - (sss + philHealth + pagIbig);

            decimal tax = ComputeTax(taxableIncome);


            decimal deductions = tax + sss + philHealth + pagIbig + otherDeductions;
            decimal netPay = grossPay - deductions;
            if (netPay < 0) netPay = 0;

            return new Payroll
            {
                EmployeeID = employeeId,
                ApprovedBy = processedBy,
                HourlyRate = hourlyRate,
                BasicSalary = basicSalary,
                OvertimePay = overtimePay,
                LeavePay = leavePay,
                SSS = sss,
                PhilHealth = philHealth,
                PagIBIG = pagIbig,
                WithholdingTax = tax,
                Deductions = deductions,
                NetPay = netPay,
                PayrollDate = payrollDate.ToString("yyyy-MM-dd"),
                PayrollCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm tt"),
                PeriodStart = periodStart.ToString("yyyy-MM-dd"),
                PeriodEnd = periodEnd.ToString("yyyy-MM-dd"),


            };
        }



        /// 
        ///     GETTING PART    
        /// 
        public Payroll GetPayrollByDate(int employeeId, string payrollDate)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
        SELECT *
        FROM PayrollTable
        WHERE EmployeeID = @EmployeeID
        AND PayrollDate = @PayrollDate
        LIMIT 1";

                return conn.QueryFirstOrDefault<Payroll>(sql, new
                {
                    EmployeeID = employeeId,
                    PayrollDate = payrollDate
                });
            }
        }

        public List<Payroll> GetPayrollsByEmployee(int employeeId)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                return conn.Query<Payroll>(
                    @"SELECT * FROM PayrollTable 
              WHERE EmployeeID = @EmployeeID
              ORDER BY PayrollDate DESC",
                    new { EmployeeID = employeeId }).ToList();
            }
        }

        public static (DateTime start, DateTime end) GetSemiMonthlyPeriod(DateTime payrollDate)
        {
            if (payrollDate.Day <= 15)
            {
                return (
                    new DateTime(payrollDate.Year, payrollDate.Month, 1),
                    new DateTime(payrollDate.Year, payrollDate.Month, 15)
                );
            }
            else
            {
                int lastDay = DateTime.DaysInMonth(payrollDate.Year, payrollDate.Month);

                return (
                    new DateTime(payrollDate.Year, payrollDate.Month, 16),
                    new DateTime(payrollDate.Year, payrollDate.Month, lastDay)
                );
            }
        }

        public static (decimal totalHours, decimal overtimeHours) GetHoursWithOvertime(
    int employeeID, DateTime start, DateTime end)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                DateTime endExclusive = end.AddDays(1);

                var records = conn.Query<AttendanceUser>(
                    @"SELECT TimeIn, TimeOut, Remarks
              FROM AttendanceTable
              WHERE EmployeeID = @EmployeeID
              AND TimeOut IS NOT NULL
              AND TimeIn >= @Start
              AND TimeIn < @EndExclusive",
                    new
                    {
                        EmployeeID = employeeID,
                        Start = start,
                        EndExclusive = endExclusive
                    });

                decimal totalHours = 0;
                decimal overtimeHours = 0;

                foreach (var r in records)
                {
                    if (r.TimeIn.HasValue && r.TimeOut.HasValue)
                    {
                        decimal dailyHours = (decimal)(r.TimeOut.Value - r.TimeIn.Value).TotalHours;

                        decimal regularHours = Math.Min(dailyHours, 8);
                        totalHours += regularHours;

                        if (r.Remarks?.Equals("Approved", StringComparison.OrdinalIgnoreCase) == true
                            && dailyHours > 8)
                        {
                            overtimeHours += (dailyHours - 8);
                        }
                    }
                }

                return (totalHours, overtimeHours);
            }
        }

        public bool PayrollExists(IDbConnection conn, int employeeID, string periodStart, string periodEnd)
        {
            return conn.ExecuteScalar<int>(
                @"SELECT COUNT(1)
          FROM PayrollTable
          WHERE EmployeeID = @EmployeeID
          AND PeriodStart = @PeriodStart
          AND PeriodEnd = @PeriodEnd",
                new { EmployeeID = employeeID, PeriodStart = periodStart, PeriodEnd = periodEnd }) > 0;
        }


        //i change user date to stick to the right datetime
        public static (DateTime start, DateTime end) NormalizeSemiMonthly(DateTime start, DateTime end)
        {
            DateTime normalizedStart;
            DateTime normalizedEnd;

            // FIRST HALF
            if (start.Day <= 15)
            {
                normalizedStart = new DateTime(start.Year, start.Month, 1);
                normalizedEnd = new DateTime(start.Year, start.Month, 15);
            }
            else
            {
                int lastDay = DateTime.DaysInMonth(start.Year, start.Month);
                normalizedStart = new DateTime(start.Year, start.Month, 16);
                normalizedEnd = new DateTime(start.Year, start.Month, lastDay);
            }

            return (normalizedStart, normalizedEnd);
        }

        //
        //  INSERTING
        //

        public void InsertOrUpdatePayroll(Payroll payroll)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Open();

                if (PayrollExists(conn, payroll.EmployeeID, payroll.PeriodStart, payroll.PeriodEnd))
                {
                    // UPDATE instead of INSERT
                    string updateSql = @"
            UPDATE PayrollTable
            SET ApprovedBy = @ApprovedBy,
                HourlyRate = @HourlyRate,
                BasicSalary = @BasicSalary,
                OvertimePay = @OvertimePay,
                LeavePay = @LeavePay,
                SSS = @SSS,
                PhilHealth = @PhilHealth,
                PagIBIG = @PagIBIG,
                WithholdingTax = @WithholdingTax,
                Deductions = @Deductions,
                NetPay = @NetPay,
                PayrollDate = @PayrollDate,
                PayrollCreated = @PayrollCreated
            WHERE EmployeeID = @EmployeeID
              AND PeriodStart = @PeriodStart
              AND PeriodEnd = @PeriodEnd";

                    conn.Execute(updateSql, payroll);
                }
                else
                {
                    // INSERT new
                    string insertSql = @"
            INSERT INTO PayrollTable
            (EmployeeID, ApprovedBy, HourlyRate, BasicSalary, OvertimePay, LeavePay, SSS, PhilHealth, PagIBIG, WithholdingTax, Deductions, NetPay, PayrollDate, PeriodStart, PeriodEnd, PayrollCreated)
            VALUES
            (@EmployeeID, @ApprovedBy, @HourlyRate, @BasicSalary, @OvertimePay, @LeavePay, @SSS, @PhilHealth, @PagIBIG, @WithholdingTax, @Deductions, @NetPay, @PayrollDate, @PeriodStart, @PeriodEnd, @PayrollCreated)";

                    conn.Execute(insertSql, payroll);
                }
            }
        }


        // PDF



    }

       
}