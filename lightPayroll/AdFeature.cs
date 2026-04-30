using lighPayroll;
using lightPayrollServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;
//timer is having conflict between System.Windows.Forms and System.Thread.Tasks, so I am using an alias

namespace lighPayrollUI
{
    public partial class AdFeature : Form
    {
        PLogIn greetingsAndMessageBoxDesign = new PLogIn();
        SQLiteDataAccess dataAccess = new SQLiteDataAccess();
        AttendanceService attendanceDataAccess = new AttendanceService();
        HBorderRadius borderRadius = new HBorderRadius();

        private string feature_button;

        public AdFeature(string feature)
        {
            InitializeComponent();
            feature_button = feature;


        }

        private void UsersUI_Load(object sender, EventArgs e)
        {

            panelDesign();

            if (feature_button == "Attendance")
                greetingsAndMessageBoxDesign.TypeMessage(titleMessage, "You will discover some day!");
            else if (feature_button == "UserControl")
                greetingsAndMessageBoxDesign.TypeMessage(titleMessage, "Trust But Always Verify!");

            ApplyFeaturePermissions();
        }

        // Load directly from database
        private void LoadList()
        {
            if (feature_button == "UserControl")
            {
                dataGrid.DataSource = dataAccess.LoadUsers();
                dataGrid.Columns["UsersID"].DisplayIndex = 0;       // move to first column of grid
            }
            else
            {
                dataGrid.DataSource = attendanceDataAccess.LoadAttendanceAdmin();
                dataGrid.Columns["UsersID"].DisplayIndex = 0;
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
                t.Interval = 50; // small delay so layout finishes
                t.Tick += (s, args) =>
                {
                    t.Stop();
                    t.Dispose();

                    bodyPanel.AutoScroll = true;

                    // Force scroll position (more reliable than ScrollControlIntoView)
                    bodyPanel.VerticalScroll.Value = requestsPanel.Top;
                    bodyPanel.PerformLayout();
                };

                t.Start();
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
                        true
                    );

            confirm.ShowDialog();

            if (confirm.Result)
            {
                bool success = dataAccess.DeleteUser(userId);

                LoadList();

                if (!success)
                {
                    new ConfirmForm("Error", "User is linked to employee. Cannot delete.", false).ShowDialog();
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

            // Optional: get status from another control (example)
            string status = statusComboBox.Text;
            string role = roleComboBox.Text;

            if (string.IsNullOrEmpty(status) || string.IsNullOrEmpty(role))
            {
                greetingsAndMessageBoxDesign.CustomMessageBox("Please select both status and role.");
                return;
            }

            dataAccess.UpdateUserStatus(userId, status, role);

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

                case "UserCount":

                    //btnPayroll.Enabled = true;
                    //btnApprove.Enabled = false;
                    break;
            }
        }

        private void panelDesign()
        {
            int radius = 17;

            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(loadButton.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(loadButton.Width - radius, loadButton.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, loadButton.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            loadButton.Region = new Region(path);
        }
    }
}