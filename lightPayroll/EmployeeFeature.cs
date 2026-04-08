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
    public partial class EmployeeFeature : Form
    {
        AdminUI adminUI = new AdminUI(); //used for getting panel design and greeting service
        private string user_role, user_name;
        private int user_id;


        public EmployeeFeature(string role, string username, int userId)
        {
            InitializeComponent();
            employeeFeatures.DrawMode = TabDrawMode.OwnerDrawFixed;
            user_role = role;
            user_name = username;
            user_id = userId;
        }

        private void LoadAttendanceList()
        {
            clockGrid.DataSource = null;
            clockGrid.Columns.Clear();
           var data = AttendanceService.LoadUserAttendance();

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


        private void EmployeeFeature_Load(object sender, EventArgs e)
        {
            adminUI.panelDesign(statusPanel);
            LoadAttendanceList();
        }


        //different colors for selected and unselected tabs
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
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
            EmployeeUI employeeUI = new EmployeeUI(user_role, user_name, user_id);
            employeeUI.Show();
            this.Hide();
        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            if (AttendanceService.HasClockedInToday(user_id))
            {
                adminUI.CustomMessageBox("You have already clocked in today."); 
                return; // stop further execution
            }


            var attendance = new AttendanceUser
            {
                Date = DateTime.UtcNow.Date,
                TimeIn = DateTime.Now,
                TimeOut = null,
                Status = "Present",
                Remarks = ""
            };

            AttendanceService.InsertClock(attendance, user_id, user_name);

            LoadAttendanceList(); // refresh grid
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {

            AttendanceService.UpdateClockOut(user_id, DateTime.Now);

            LoadAttendanceList(); // refresh grid
        }
    }
}
