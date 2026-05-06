using lighPayroll;
using lightPayrollModel;
using lightPayrollServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WinFormsTimer = System.Windows.Forms.Timer;
//timer is having conflict between System.Windows.Forms and System.Thread.Tasks, so I am using an alias

namespace lighPayrollUI
{
    public partial class AdFeature : Form
    {
        PLogIn greetingsAndMessageBoxDesign = new PLogIn();
        GeneralDataService dataAccess = new GeneralDataService();
        AttendanceService attendanceDataAccess = new AttendanceService();
        HBorderRadius borderRadius = new HBorderRadius();
        AdminUser users = new AdminUser();
        AdUI messageCustom = new AdUI();

        private string feature_button;

        public AdFeature(string feature)
        {
            InitializeComponent();
            feature_button = feature;


        }

        private void UsersUI_Load(object sender, EventArgs e)
        {
            //trying to make the border of panel and buttonslike with curves
            borderRadius.SetRoundedRegion(loadPanel, 33);
            borderRadius.SetRoundedRegion(statusPanel, 33);
            borderRadius.SetRoundedRegion(overtimeLoadPnl, 33);
            borderRadius.SetRoundedRegion(leaveLoadPnl, 33);

            if (feature_button == "Attendance")
            {
                greetingsAndMessageBoxDesign.TypeMessage(titleMessage, "You will discover some day!");
                addUserButton.Visible = false;
                deleteUserButton.Visible = false;
                searchUserButton.Location = new Point(187, 7);
            }
            else if (feature_button == "UserControl")
            {
                greetingsAndMessageBoxDesign.TypeMessage(titleMessage, "Trust But Always Verify!");
                requestsPanel.Visible = false;

                addUserButton.Visible = true;
                deleteUserButton.Visible = true;
            }
            else if (feature_button == "Requests")
            {
                greetingsAndMessageBoxDesign.TypeMessage(titleMessage, "You will discover some day!");
                dataGrid.Visible = false;
                addUserButton.Visible = false;
                deleteUserButton.Visible = false;
                searchUserButton.Location = new Point(187, 7);
            }



            ApplyFeaturePermissions();


        }

        // Load directly from database
        private void LoadList()
        {
            if (feature_button == "UserControl")
            {
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGrid.DataSource = dataAccess.LoadUsers();
                dataGrid.Columns["UsersID"].DisplayIndex = 0;       // move to first column of grid
            }
            else
            {
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //might modify in the future if daghan
                var data = attendanceDataAccess.LoadAttendanceAdmin();
                var displayData = data.Select(a => new
                {
                    EmployeeID = a.EmployeeID,
                    Date = a.Date?.ToString("yyyy-MM-dd"),
                    TimeIn = a.TimeInDisplay,
                    TimeOut = a.TimeOutDisplay,
                    Status = a.Status,
                    Remarks = a.Remarks
                }).ToList();

                dataGrid.DataSource = displayData;
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            LoadList();

        }
        private void AdFeature_Shown(object sender, EventArgs e)
        {
            if (feature_button == "Requests")
            {
                WinFormsTimer t = new WinFormsTimer();
                t.Interval = 111; // small delay so layout finishes
                t.Tick += (s, args) =>
                {
                    t.Stop();
                    t.Dispose();

                    // Force scroll position (more reliable than ScrollControlIntoView)
                    bodyPanel.VerticalScroll.Value = requestsPanel.Top;
                    bodyPanel.PerformLayout();


                    //show the attendance tools after scroll
                    dataGrid.Visible = true;
                    upperBodyPanel.Visible = true;

                };

                t.Start();
            }
            else
            {
                dataGrid.Visible = true;
                upperBodyPanel.Visible = true;
            }


        }


        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // Validate input first
            if (!int.TryParse(nameOrIDTxtBox.Text, out int userId))
            {
                greetingsAndMessageBoxDesign.CustomMessageBox("Please enter a valid numeric User ID.");
                return;
            }


            if (dataAccess.GetUserByIdOrUsername(userId.ToString()) == null)
            {
                greetingsAndMessageBoxDesign.CustomMessageBox("User ID not found.");
                return;
            }

            var confirm = new ConfirmForm(
                        "Delete User",
                        $"Are you sure you want to delete User ID: {userId}?",
                        true, false
                    );

            confirm.ShowDialog();

            if (confirm.Result)
            {
                bool success = dataAccess.DeleteUser(userId);

                LoadList();

                if (!success)
                {
                    new ConfirmForm("Error", "User is linked to employee. Cannot delete.", false, false).ShowDialog();
                }
            }
        }


        // Update ONLY when button is clicked
        private void modifyRowButton_Click(object sender, EventArgs e)
        {

            // Validate input first
            if (!int.TryParse(nameOrIDTxtBox.Text, out int userId))
            {
                greetingsAndMessageBoxDesign.CustomMessageBox("Please enter a valid numeric User ID.");
                return;
            }

            if (dataAccess.GetUserByIdOrUsername(userId.ToString()) == null)
            {
                greetingsAndMessageBoxDesign.CustomMessageBox("User ID not found.");
                return;
            }
            else
            {
                users = dataAccess.GetUserByIdOrUsername(userId.ToString());
            }

            string usernamePart = users.Username.Split('@')[0]; // "first.last"
            string[] parts = usernamePart.Split('.');

            //capitalizing first letter of each word in username
            parts[0] = char.ToUpper(parts[0][0]) + parts[0].Substring(1);
            parts[1] = char.ToUpper(parts[1][0]) + parts[1].Substring(1);


            string status = statusComboBox.Text;
            string role = roleComboBox.Text;

            if (string.IsNullOrEmpty(status) || string.IsNullOrEmpty(role))
            {
                greetingsAndMessageBoxDesign.CustomMessageBox("Please select both status and role.");
                return;
            }

            dataAccess.UpdateUserStatus(userId, status, role);

            var employee = dataAccess.GetEmployeeByID(userId);

            if ((employee) == null)
            {
                //Create user object
                NewEmployee newEmployee = new NewEmployee
                {
                    UsersID = userId,
                    FirstName = parts[0],
                    LastName = parts[1],
                    Position = role,
                    DateHired = DateTime.Now
                };

                dataAccess.InsertEmployee(newEmployee);

            }
            else
            {
                dataAccess.UpdateEmployeeStatus(role, userId);

            }





            greetingsAndMessageBoxDesign.CustomMessageBox("User updated successfully!");

            // Refresh grid
            LoadList();
        }
        private void searchUserButton_Click(object sender, EventArgs e)
        {
            string username = nameOrIDTxtBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                greetingsAndMessageBoxDesign.CustomMessageBox("Enter valid name.");
                return;
            }


            if (dataAccess.SearchUsersByUsername(username) == null)
                greetingsAndMessageBoxDesign.CustomMessageBox("User not found.");
            else
                dataGrid.DataSource = dataAccess.SearchUsersByUsername(username);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdUI adminUI = new AdUI();
            adminUI.Show();
            this.Hide();
        }



        private void ApplyFeaturePermissions()
        {
            switch (feature_button)
            {
                case "Attendance":

                    titleLabel.Text = "Attendance";

                    //btnApprove.Enabled = true;
                    //btnPayroll.Enabled = true;
                    break;

                case "UserControl":
                    titleLabel.Text = "User Modification";
                    break;

                default:

                    titleLabel.Text = "Attendance";
                    break;
            }
        }
        //different colors for selected and unselected tabs
        private void otherFeatures_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (DesignMode) return; // I need to add this check to prevent design-time errors when drawing tabs in the designer


            TabPage tabPage = requestsTabPage.TabPages[e.Index];
            Rectangle tabBounds = requestsTabPage.GetTabRect(e.Index);

            // Choose color per tab (example)
            Color textColor;

            if (e.Index == requestsTabPage.SelectedIndex)
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
    }
}