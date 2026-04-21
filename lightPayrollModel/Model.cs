using System;

namespace lightPayrollModel
{ 
    public abstract class BaseEntity
    {
        public int UsersID { get; set; }
        public DateTime? DateCreated { get; set; }

        // Force all models to validate themselves
        public abstract void Validate();
    }

    public abstract class Users : BaseEntity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? AccountStatus { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Username))
                throw new Exception("Username is required");

            if (string.IsNullOrWhiteSpace(Password))
                throw new Exception("Password is required");
        }
    }

    public interface IApprovable
    {
        void Approve(int approvedBy);
    }

    public interface ILoggable
    {
        void LogAction(string action);
    }

    public class UserDisplay: BaseEntity
    {
        public string? Username { get; set; }
        public string? Role { get; set; }
        public string? AccountStatus { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Username))
                throw new Exception("Username is required");
        }
    }

    public class EmployeeDisplay //used for lists in data grid
    {
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName =>
        string.Join(" ", new[]
        {
            FirstName,
            MiddleName == "-" ? "" : MiddleName,
            LastName
        });
        public string? Role { get; set; }
    }

   

    public class AdminUser : Users //used for creating instance for admin
    {
        public override void Validate()
        {
            base.Validate();
        }
    }

    public class NewUser : Users //used for creating instance for users
    {
        public override void Validate()
        {
            base.Validate();
        }
    }


    public class Employee : BaseEntity //used for getting employee complete info not for display
    {
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName =>
            string.Join(" ", new[] { FirstName, MiddleName, LastName }
            .Where(s => !string.IsNullOrWhiteSpace(s)));

        public string? Position { get; set; }
        public string? Department { get; set; }
        public DateTime? DateHired { get; set; }

        private double? salaryRate;
        public double? SalaryRate
        {
            get => salaryRate;
            set
            {
                if (value < 0)
                    throw new Exception("Salary rate cannot be negative");
                salaryRate = value;
            }
        }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                throw new Exception("First name is required");
        }
    }

    public class PayrollInput //used for forms input
    {
        public int EmployeeID { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal PagIBIG { get; set; } //Other Deductions (Loans, Cash Advance, etc.)
        public decimal OtherDeductions { get; set; }
        public int ProcessedBy { get; set; }
    }


    public class Payroll : BaseEntity
    {
        public int EmployeeID { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? OvertimePay { get; set; }
        public decimal SSS { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal PagIBIG { get; set; }
        public decimal WithholdingTax { get; set; }
        public decimal? Deductions { get; set; }
        public decimal? NetSalary { get; set; }
        public DateTime? PayrollDate { get; set; }
        public int ProcessedBy { get; set; }

        public override void Validate()
        {
            if (EmployeeID <= 0)
                throw new Exception("Invalid Employee ID");
        }
    }

    public class LeaveRequest : BaseEntity
    {
        public int EmployeeID { get; set; }
        public string? LeaveType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Reason { get; set; }
        public string? Status { get; set; }
        public int ApprovedBy { get; set; }

        public override void Validate()
        {
            if (EmployeeID <= 0)
                throw new Exception("Invalid Employee ID");
        }
    }

    public class OvertimeRequest : BaseEntity
    {
        public int EmployeeID { get; set; }
        public DateTime? Date { get; set; }
        public float? HoursRendered { get; set; }
        public string? Status { get; set; }
        public int ApprovedBy { get; set; }

        public override void Validate()
        {
            if (EmployeeID <= 0)
                throw new Exception("Invalid Employee ID");
        }
    }

    public class Report : BaseEntity
    {
        public string? ReportType { get; set; }
        public int GeneratedBy { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(ReportType))
                throw new Exception("Report type is required");
        }
    }

    public class AttendanceAdmin : BaseEntity
    {
        public int AttendanceID { get; set; }
        public int UserID { get; set; }
        public string? FullName { get; set; }

        public DateTime? Date { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }

        public string? Status { get; set; }
        public string? Remarks { get; set; }

        public override void Validate()
        {
            if (UserID <= 0)
                throw new Exception("Invalid User ID");

            if (Date == null)
                throw new Exception("Date is required");
        }
    }

    public class AttendanceUser
    {
        public DateTime? Date { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }

        public string? Status { get; set; }
        public string? Remarks { get; set; }

        // For display only
        public string TimeInDisplay => TimeIn?.ToString("HH:mm");
        public string TimeOutDisplay => TimeOut?.ToString("HH:mm");

    }


}