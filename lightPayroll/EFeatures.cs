using lighPayroll;
using lightPayrollModel;
using lightPayrollServices;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lighPayrollUI
{
    public partial class EFeatures : Form
    {
        AdUI adminUI = new AdUI(); //used for getting panel design and greeting service
        SQLiteDataAccess dataAccess = new SQLiteDataAccess();
        AttendanceService attendanceDataAccess = new AttendanceService();
        PayrollService payrollService = new PayrollService();

        private readonly string user_role, user_name;
        private readonly int user_id;
        private int attendance_id;
        private int employee_id;
        private int selectedEmployeeID = 0;
        private string selectedEmployeeName = "";


        public EFeatures(string role, string username, int userId)
        {
            InitializeComponent();
            employeeFeatures.DrawMode = TabDrawMode.OwnerDrawFixed;
            user_role = role;
            user_name = username;
            user_id = userId;
            employee_id = dataAccess.GetEmployeeIdByUserId(user_id);
        }

        private void EmployeeFeature_Load(object sender, EventArgs e)
        {
            adminUI.panelDesign(statusPanel);
            ConfigureTabsByRole();
            LoadAttendanceList();
            LoadEmployeeList();
            LoadProfile();
            LoadAllAttendanceList();
            LoadPayslip();

            if (!DesignMode)
            {
                employeeFeatures.DrawMode = TabDrawMode.OwnerDrawFixed;
            }

            HBorderRadius borderRadius = new HBorderRadius();
            borderRadius.SetRoundedRegion(payrollSearchPanel, 37);
            borderRadius.SetRoundedRegion(payrollPanel, 33);
            borderRadius.SetRoundedRegion(attendancePanel, 33);
            borderRadius.SetRoundedRegion(attendanceSearchPnl, 33);
            borderRadius.SetRoundedRegion(profilePanel, 33);
            borderRadius.SetRoundedRegion(payslipPanel, 33);
            borderRadius.SetRoundedRegion(headPayslipPanel, 33);


            //borderRadius.SetRoundedRegion(insideProfile, 33);

            if (attendanceDataAccess.HasClockedOutToday(user_id))
            {
                clockStatusReal.Text = "Clock Out";
                clockStatusReal.ForeColor = Color.IndianRed;
            }
            else if (attendanceDataAccess.HasClockedInToday(user_id))
            {
                clockStatusReal.Text = "Clock In";
                clockStatusReal.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                clockStatusReal.Text = "Pending";
                clockStatusReal.ForeColor = Color.FromArgb(255, 255, 128);
            }

        }


        /// 
        /// FOR LOADING PART IN TABLES
        /// 

        private void LoadAllAttendanceList()
        {
            attendanceGrid.DataSource = null;
            attendanceGrid.Columns.Clear();
            var data = attendanceDataAccess.LoadAttendanceCore();
            var displayData = data.Select(a => new
            {
                EmployeeID = a.EmployeeID,
                Date = a.Date?.ToString("yyyy-MM-dd"),
                TimeIn = a.TimeInDisplay,
                TimeOut = a.TimeOutDisplay,
                a.Remarks
            }).ToList();

            attendanceGrid.DataSource = displayData;
        }

        private void LoadPayslip()
        {
            paySlipRecords.DataSource = null;
            paySlipRecords.Columns.Clear();

            var employeeRole = dataAccess.GetUserRoleByUsername(user_name);
            var employeeID = dataAccess.GetEmployeeIdByUserId(user_id);
            var data = payrollService.GetPayrollsByEmployee(employeeID);

            var displayData = data.Select(a => new
            {
                a.PeriodStart,
                a.PeriodEnd,
                a.PayrollDate,
                NetPay = a.NetPay.ToString("F2")
            }).ToList();

            paySlipRecords.DataSource = displayData;
        }



        private void LoadAttendanceList()
        {

            clockGrid.DataSource = null;
            clockGrid.Columns.Clear();
            var employeeID = dataAccess.GetEmployeeIdByUserId(user_id);
            var data = attendanceDataAccess.LoadUserAttendanceById(employeeID);

            // Project to display properties for the grid
            var displayData = data.Select(a => new
            {
                Date = a.Date?.ToString("yyyy-MM-dd"),
                TimeIn = a.TimeInDisplay,
                TimeOut = a.TimeOutDisplay,
                a.Status,
                a.Remarks
            }).ToList();



            clockGrid.DataSource = displayData;
        }

        private void LoadEmployeeList()
        {
            payrollGrid.DataSource = null;
            payrollGrid.Columns.Clear();
            var data = dataAccess.LoadEmployeeWithUser();


            payrollGrid.DataSource = data;
        }

        private void LoadProfile()
        {
            var employee = dataAccess.GetEmployeeByID(user_id);
            if (employee != null)
            {
                userID.Text = employee.EmployeeID.ToString();
                firstName.Text = employee.FirstName;
                lastName.Text = employee.LastName;
                role.Text = employee.Position;

                if (employee.MiddleName == null)
                    middleName.Text = "-";
                else
                    middleName.Text = employee.MiddleName;


                if (employee.Email == null)
                    email.Text = "-";
                else
                    email.Text = employee.Email;
            }
        }






        private void ConfigureTabsByRole()
        {
            if (user_role == "Employee")
            {
                // Only allow this tab (change name based on your actual TabPage Name)
                //this depend on role
                var allowedTabs = new List<string>
                {
                    "payslipPage", "clockPage", "profilePage"

                };

                foreach (TabPage tab in employeeFeatures.TabPages.Cast<TabPage>().ToList())
                {
                    if (!allowedTabs.Contains(tab.Name))
                    {
                        employeeFeatures.TabPages.Remove(tab);
                    }
                }
            }
            else if (user_role == "Manager")
            {
                var allowedTabs = new List<string>
                {
                    "payslipPage", "clockPage", "profilePage", "overTimePage", "attendancePage"

                };

                foreach (TabPage tab in employeeFeatures.TabPages.Cast<TabPage>().ToList())
                {
                    if (!allowedTabs.Contains(tab.Name))
                    {
                        employeeFeatures.TabPages.Remove(tab);
                    }
                }
            }
            else if (user_role == "Accountant")
            {
                var allowedTabs = new List<string>
                {
                    "payslipPage", "clockPage", "profilePage", "payrollPage", "attendancePage"

                };

                foreach (TabPage tab in employeeFeatures.TabPages.Cast<TabPage>().ToList())
                {
                    if (!allowedTabs.Contains(tab.Name))
                    {
                        employeeFeatures.TabPages.Remove(tab);
                    }
                }
            }

        }



        //different colors for selected and unselected tabs
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (DesignMode) return; // I need to add this check to prevent design-time errors when drawing tabs in the designer


            TabPage tabPage = employeeFeatures.TabPages[e.Index];
            Rectangle tabBounds = employeeFeatures.GetTabRect(e.Index);

            // Choose color per tab (example)
            Color textColor;

            if (e.Index == employeeFeatures.SelectedIndex)
                textColor = Color.FromArgb(33, 44, 66);   // selected tab
            else
                textColor = Color.Gray;   // unselected tabs

            TextRenderer.DrawText(
                e.Graphics,
                tabPage.Text,
                e.Font,
                tabBounds,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            if (tabPage.Name == "profilePage")
            {
                LoadProfile();
            }
            else if (tabPage.Name == "clockPage")
            {
                LoadAttendanceList();
            }
             else if (tabPage.Name == "attendancePage")
            {
                LoadAllAttendanceList();
            }
             else if (tabPage.Name == "payrollPage")
             {
                LoadEmployeeList();
             }
             else if (tabPage.Name == "payslipPage")
             {
                LoadPayslip();
            }
        }

        private void HomeUser_Click(object sender, EventArgs e)
        {
            EUI employeeUI = new EUI(user_role, user_name, user_id);
            employeeUI.Show();
            this.Hide();
        }

        /// 
        /// FOR CLOCK IN PAGE
        /// 
        /// 

        private void clockInButton_Click(object sender, EventArgs e)
        {
            if (attendanceDataAccess.HasClockedInToday(employee_id))
            {
                adminUI.CustomMessageBox("You have already clocked in today.");
                return;
            }

            var now = DateTime.Now;

            var attendance = new AttendanceUser
            {
                Date = now,
                TimeIn = now,
                TimeOut = null,
                Status = "Present",
                Remarks = ""
            };

            attendance_id = attendanceDataAccess.InsertClock(attendance, employee_id, user_name);

            LoadAttendanceList();

            clockStatusReal.ForeColor = Color.FromArgb(0, 192, 0);
            clockStatusReal.Text = "Clock In";
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {
            attendance_id = attendanceDataAccess.GetActiveAttendanceId(employee_id);

            if (attendance_id == null || attendance_id == 0)
            {
                adminUI.CustomMessageBox("You are already clocked out or have no active shift.");
                return;
            }


            attendanceDataAccess.UpdateClockOut(attendance_id, DateTime.Now);

            LoadAttendanceList(); // refresh grid
            clockStatusReal.Text = "Clock Out";
            clockStatusReal.ForeColor = Color.IndianRed;
        }




        ////
        //// FOR PROFILE PAGE (others are in load - the top)
        ////
        ////
        ///


        private void modifyProfile_Click(object sender, EventArgs e)
        {
            ConfirmForm form = new ConfirmForm("Modify Profile", "", true, true);
            form.ShowDialog();

            if (form.Result)
            {
                string email = form.Email;
                string middle = form.MiddleName;

                if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
                    email = null;
                if (string.IsNullOrEmpty(middle) || string.IsNullOrWhiteSpace(middle))
                    middle = null;


                attendanceDataAccess.UpdateEmployeeProfile(user_id, middle, email);
                LoadProfile();
            }
        }

        ///
        /// FOR ATTENDANCE PAGE
        ///

        private void SearchAttendance()
        {
            string employeeAtt = attendanceSearch.Text;

            if (string.IsNullOrEmpty(employeeAtt) || string.IsNullOrWhiteSpace(employeeAtt))
            {
                LoadAllAttendanceList();
                return;
            }

            // Validate input first
            else if (!int.TryParse(attendanceSearch.Text, out int userId))
            {
                adminUI.CustomMessageBox("Please enter a valid numeric User ID.");
                return;
            }

            var result = attendanceDataAccess.LoadUserAttendanceById(int.Parse(employeeAtt));

            var displayData = result.Select(a => new
            {
                EmployeeID = employeeAtt,
                Date = a.Date?.ToString("yyyy-MM-dd"),
                TimeIn = a.TimeInDisplay,
                TimeOut = a.TimeOutDisplay,
                a.Remarks
            }).ToList();

            if (result == null || result.Count == 0)
            {
                adminUI.CustomMessageBox("User not found.");
                return;
            }

            attendanceGrid.DataSource = displayData;
        }

        private void attendanceSearchEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // prevents "ding" sound
                // Call your search method here, similar to SearchUser for payroll
                SearchAttendance();

            }
        }

        /// 
        /// FOR PAYROLL PAGE
        //

        private void SearchEmployee()
        {
            string username = searchBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                adminUI.CustomMessageBox("Enter valid name.");
                return;
            }

            var result = dataAccess.GetEmployeeByName(username);

            if (result == null || result.Count == 0)
            {
                adminUI.CustomMessageBox("User not found.");
                return;
            }

            payrollGrid.DataSource = result;
        }

        private void searchEnterPayroll(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevents "ding" sound
                SearchEmployee();
            }
        }

        private void modifyPayrollB_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == 0)
            {
                adminUI.CustomMessageBox("Please select an employee first.");
                return;
            }

            HPayroll form = new HPayroll();

            Payroll payroll = new Payroll();
            try
            {
                payroll = form.ShowPayrollForm(selectedEmployeeID, user_id);


            }
            catch (Exception ex)
            {
                adminUI.CustomMessageBox($"{ex.Message}");
            }



            if (payroll != null)
            {

                payrollService.InsertOrUpdatePayroll(payroll);
                adminUI.CustomMessageBox("Payroll successfully made.");

                try
                {
                    var employee = dataAccess.GetEmployeeByID(employeeID: selectedEmployeeID);

                    if (employee.Email == null)
                        throw new Exception("       The user has not modified the email.");


                    EmailService.SendPayrollEmail(
                       employee.Email,
                        selectedEmployeeName

                    );
                }
                catch (SocketException ex)
                {
                    var error = new ConfirmForm(
                        $"\n\n\n\n{ex.Message}",
                        "",
                        false
                    );
                    error.ShowDialog();
                }
                catch (Exception ex)
                {
                    var error = new ConfirmForm(
                        $"Unable to email the employee\n\n\n\n",
                        $"{ex.Message}",
                        false
                    );

                    error.ShowDialog();
                }
            }



        }

        private void payrollGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int tempEmployeeID = Convert.ToInt32(
                    payrollGrid.Rows[e.RowIndex].Cells["EmployeeID"].Value);

                string tempName = payrollGrid.Rows[e.RowIndex]
                    .Cells["FullName"].Value.ToString();

                ConfirmForm confirm = new ConfirmForm(
                $"Confirm to select this employee?\n\n", $"Employee ID: {tempEmployeeID}\nName: {tempName}");

                confirm.ShowDialog();

                if (confirm.Result)
                {
                    adminUI.CustomMessageBox("Employee ID saved. Please click modify button");
                    selectedEmployeeID = tempEmployeeID;
                    selectedEmployeeName = tempName;
                }
            }
        }

        ///
        /// PAYSLIP PAGE
        ///

        private void paySlipRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string tempEmployeePayslip = paySlipRecords.Rows[e.RowIndex].Cells["PayrollDate"].Value.ToString();

                ConfirmForm confirm = new ConfirmForm(
                $"Confirm to select this payslip?\n\n", $"\t\tPayroll Date: {tempEmployeePayslip}");
                confirm.ShowDialog();

                if (confirm.Result)
                {

                }
            }
        }

        private void headPayslipPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
