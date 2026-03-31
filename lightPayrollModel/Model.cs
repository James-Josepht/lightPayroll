using System;


namespace lightPayrollModel
{
    public class Users
    {
        private int userID;
        private string? userName;
        private string? passWord;
        private string? role;
        private string? accountStatus;
        private string? dateCreated;
        

        public int UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }
        public string? Username
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        public string? Password
        {
            get { return this.passWord; }
            set { this.passWord = value; }
        }

        public string? Role
        {
            get { return this.role; }
            set { this.role = value; }
        }
        public string? AccountStatus
        {
            get { return this.accountStatus; }
            set { this.accountStatus = value; }
        }
        public string? DateCreated
        {
            get { return this.dateCreated; }
            set { this.dateCreated = value; }
        }

    }

    public class Employees
    {
        private string? firstName;
        private string? middleName;
        private string? lastName;
        private string? position;
        private string? department;
        private DateTime? dateHired;
        private float? salaryRate;

        public string? FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string? MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string? LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FullName
        {
            get { return $"{this.firstName} {this.middleName} {this.lastName}"; }
        }

        public string? Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string? Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        
        public DateTime? DateHired
        {
            get { return this.dateHired; }
            set { this.dateHired = value; }
        }

        public float? SalaryRate
        {
            get { return this.salaryRate; }
            set { this.salaryRate = value; }
        }

    }

    public class Payroll
    {
        private int payrollID;
        private int employeeID;
        private float? basicSalary;
        private float? overtimePay;
        private float? deductions;
        private float? netSalary;
        private DateTime? payrollDate;
        private int processedBy;

        public int PayrollID
        {
            get { return this.payrollID; }
            set { this.payrollID = value; }
        }

        public int EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }

        public float? BasicSalary
        {
            get { return this.basicSalary; }
            set { this.basicSalary = value; }
        }

        public float? OvertimePay
        {
            get { return this.overtimePay; }
            set { this.overtimePay = value; }
        }

        public float? Deductions
        {
            get { return this.deductions; }
            set { this.deductions = value; }
        }

        public float? NetSalary
        {
            get { return this.netSalary; }
            set { this.netSalary = value; }
        }

        public DateTime? PayrollDate
        {
            get { return this.payrollDate; }
            set { this.payrollDate = value; }
        }

        public int ProcessedBy
        {
            get { return this.processedBy; }
            set { this.processedBy = value; }
        }
    }

    public class LeaveRequests
    {
        private int leaveID;
        private int employeeID;
        private string? leaveType;
        private DateTime? startDate;
        private DateTime? endDate;
        private string? reason;
        private string? status;
        private int approvedBy;

        public int LeaveID
        {
            get { return this.leaveID; }
            set { this.leaveID = value; }
        }

        public int EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }

        public string? LeaveType
        {
            get { return this.leaveType; }
            set { this.leaveType = value; }
        }

        public DateTime? StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public DateTime? EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

        public string? Reason
        {
            get { return this.reason; }
            set { this.reason = value; }
        }

        public string? Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int ApprovedBy
        {
            get { return this.approvedBy; }
            set { this.approvedBy = value; }
        }
    }

    public class OvertimeRequests
    {
        private int overtimeID;
        private int employeeID;
        private DateTime? date;
        private float? hoursRendered;
        private string? status;
        private int approvedBy;

        public int OvertimeID
        {
            get { return this.overtimeID; }
            set { this.overtimeID = value; }
        }

        public int EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }

        public DateTime? Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public float? HoursRendered
        {
            get { return this.hoursRendered; }
            set { this.hoursRendered = value; }
        }

        public string? Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int ApprovedBy
        {
            get { return this.approvedBy; }
            set { this.approvedBy = value; }
        }
    }

    public class Reports
    {
        private int reportID;
        private string? reportType;
        private DateTime? dateGenerated;
        private int generatedBy;

        public int ReportID
        {
            get { return this.reportID; }
            set { this.reportID = value; }
        }

        public string? ReportType
        {
            get { return this.reportType; }
            set { this.reportType = value; }
        }

        public DateTime? DateGenerated
        {
            get { return this.dateGenerated; }
            set { this.dateGenerated = value; }
        }

        public int GeneratedBy
        {
            get { return this.generatedBy; }
            set { this.generatedBy = value; }
        }
    }





}
