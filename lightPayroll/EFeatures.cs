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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lighPayrollUI
{
    public partial class EFeatures : Form
    {
        AdUI adminUI = new AdUI(); //used for getting panel design and greeting service
        private string user_role, user_name;
        private int user_id;


        public EFeatures(string role, string username, int userId)
        {
            InitializeComponent();
            employeeFeatures.DrawMode = TabDrawMode.OwnerDrawFixed;
            user_role = role;
            user_name = username;
            user_id = userId;
        }
        private void EmployeeFeature_Load(object sender, EventArgs e)
        {
            adminUI.panelDesign(statusPanel);
            ConfigureTabsByRole();
            LoadAttendanceList();

            if (!DesignMode)
            {
                employeeFeatures.DrawMode = TabDrawMode.OwnerDrawFixed;
            }

            HBorderRadius borderRadius = new HBorderRadius();
            borderRadius.SetRoundedRegion(payrollSearchPanel, 37);
            borderRadius.SetRoundedRegion(payrollPanel, 33);
            borderRadius.SetRoundedRegion(profilePanel, 33);

        }

        private void LoadAttendanceList()
        {
            clockGrid.DataSource = null;
            clockGrid.Columns.Clear();
            var data = AttendanceService.LoadUserAttendanceById(user_id);

            // Project to display properties for the grid
            var displayData = data.Select(a => new
            {
                Date = a.Date?.ToLocalTime().ToString("yyyy-MM-dd"),
                TimeIn = a.TimeInDisplay,
                TimeOut = a.TimeOutDisplay,
                a.Status,
                a.Remarks
            }).ToList();



            clockGrid.DataSource = displayData;
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
            if (AttendanceService.HasClockedInToday(user_id))
            {
                adminUI.CustomMessageBox("You have already clocked in today.");
                return; // stop further execution
            }


            var nowUtc = DateTime.UtcNow;

            var attendance = new AttendanceUser
            {
                Date = nowUtc,   // store full datetime
                TimeIn = nowUtc,
                TimeOut = null,
                Status = "Present",
                Remarks = ""
            };

            AttendanceService.InsertClock(attendance, user_id, user_name);

            LoadAttendanceList(); // refresh grid
            clockStatusReal.ForeColor = Color.FromArgb(0, 192, 0);

        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {

            AttendanceService.UpdateClockOut(user_id, DateTime.UtcNow);

            LoadAttendanceList(); // refresh grid
            clockStatusReal.Text = "Clock Out";
            clockStatusReal.ForeColor = Color.IndianRed;
        }


        ////
        //// FOR PROFILE PAGE
        ////
        ////
       
    }
}
