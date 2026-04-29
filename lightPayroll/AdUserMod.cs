using lighPayroll;
using lightPayrollServices;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace lighPayrollUI
{
    public partial class AdUserMod : Form
    {
        PLogIn greetingsAndMessageBoxDesign = new PLogIn();
        SQLiteDataAccess dataAccess = new SQLiteDataAccess();
        AttendanceService attendanceDataAccess = new AttendanceService();

        public AdUserMod()
        {
            InitializeComponent();
        }

        private void UsersUI_Load(object sender, EventArgs e)
        {

            greetingsAndMessageBoxDesign.TypeMessage(label2, "Trust But Always Verify!");
            panelDesign();
        }

        // Load directly from database
        private void LoadUserList()
        {
            attendanceGrid.DataSource = dataAccess.LoadUsers();
            attendanceGrid.Columns["UsersID"].DisplayIndex = 0;       // move to first

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadUserList();
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

                LoadUserList();

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
            LoadUserList();
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
                attendanceGrid.DataSource = dataAccess.SearchUsersByUsername(username);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdUI adminUI = new AdUI();
            adminUI.Show();
            this.Hide();
        }


        private void panelDesign()
        {
            int radius = 30;

            GraphicsPath greetingsPath = new GraphicsPath();
            greetingsPath.AddArc(0, 0, radius, radius, 180, 90);
            greetingsPath.AddArc(loadButton.Width - radius, 0, radius, radius, 270, 90);
            greetingsPath.AddArc(loadButton.Width - radius, loadButton.Height - radius, radius, radius, 0, 90);
            greetingsPath.AddArc(0, loadButton.Height - radius, radius, radius, 90, 90);
            greetingsPath.CloseAllFigures();

            GraphicsPath bodyPath = new GraphicsPath();
            bodyPath.AddArc(0, 0, radius, radius, 180, 90);
            bodyPath.AddArc(loadButton.Width - radius, 0, radius, radius, 270, 90);
            bodyPath.AddArc(loadButton.Width - radius, loadButton.Height - radius, radius, radius, 0, 90); //lower right
            bodyPath.AddArc(0, loadButton.Height - radius, radius, radius, 90, 90);
            bodyPath.CloseAllFigures();

            loadButton.Region = new Region(greetingsPath);
            loadButton.Region = new Region(bodyPath);

        }

        
    }
}