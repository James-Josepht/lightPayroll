using lightPayrollModel;

namespace lightPayrollServices
{
    public class PayrollService
    {
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
            decimal hoursWorked,
            decimal overtimeHours,
            int processedBy)
        {
            decimal basicSalary = hourlyRate * hoursWorked;
            decimal overtimePay = overtimeHours * hourlyRate * 1.25m;

            decimal grossPay = basicSalary + overtimePay;
            decimal tax = ComputeTax(grossPay);

            decimal netPay = grossPay - tax;
            if (netPay < 0) netPay = 0;

            return new Payroll
            {
                EmployeeID = employeeId,
                BasicSalary = basicSalary,
                OvertimePay = overtimePay,
                SSS = 0,
                PhilHealth = 0,
                PagIBIG = 0,
                WithholdingTax = tax,
                Deductions = tax,
                NetSalary = netPay,
                PayrollDate = DateTime.Now,
                ProcessedBy = processedBy
            };
        }

        //second month full deductions including government
        public Payroll CalculateSecond (int employeeId, decimal hourlyRate, decimal hoursWorked,
                                        decimal overtimeHours, decimal pagIbig, decimal otherDeductions, int processedBy)

        {
            decimal basicSalary = hourlyRate * hoursWorked;
            decimal overtimePay = overtimeHours * hourlyRate * 1.25m;

            decimal monthlyRate = basicSalary * 2;

            // SSS
            decimal msc = monthlyRate < 5000 ? 5000 :
                          monthlyRate > 35000 ? 35000 : monthlyRate;

            decimal sss = msc * 0.05m;

            // PhilHealth
            decimal salaryPH = monthlyRate < 10000 ? 10000 :
                               monthlyRate > 100000 ? 100000 : monthlyRate;

            decimal philHealth = (salaryPH * 0.05m) / 2;

            decimal grossPay = basicSalary + overtimePay;
            decimal taxableIncome = grossPay - (sss + philHealth + pagIbig);

            decimal tax = ComputeTax(taxableIncome);

            decimal deductions = tax + sss + philHealth + pagIbig;
            decimal netPay = grossPay - deductions;
            if (netPay < 0) netPay = 0;

            return new Payroll
            {
                EmployeeID = employeeId,
                BasicSalary = basicSalary,
                OvertimePay = overtimePay,
                SSS = sss,
                PhilHealth = philHealth,
                PagIBIG = pagIbig,
                WithholdingTax = tax,
                Deductions = deductions,
                NetSalary = netPay,
                PayrollDate = DateTime.Now,
                ProcessedBy = processedBy
            };
        }
    }
}