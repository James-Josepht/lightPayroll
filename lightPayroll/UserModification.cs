using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using lighPayroll;
using lightPayrollServices;

namespace lighPayrollUI
{
    public partial class UserModification : Form
    {
        LogIn greetingsAndMessageBoxDesign = new LogIn();


        public UserModification()
        {
            InitializeComponent();
        }

        private void UsersUI_Load(object sender, EventArgs e)
        {
            greetingsAndMessageBoxDesign.TypeMessage(label2, "Trust But Always Verify!");
        }

        // Load directly from database
        private void LoadUserList()
        {
            attendanceGrid.DataSource = SQLiteDataAccess.LoadUsers();
            attendanceGrid.Columns["UsersID"].DisplayIndex = 0;       // move to first

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadUserList();
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

            if (SQLiteDataAccess.GetUserByIdOrUsername(userId.ToString()) == null)
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

            SQLiteDataAccess.UpdateUserStatus(userId, status, role);

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


            if (SQLiteDataAccess.SearchUsersByUsername(username) == null)
                greetingsAndMessageBoxDesign.CustomMessageBox("User not found.");
            else
                attendanceGrid.DataSource = SQLiteDataAccess.SearchUsersByUsername(username);




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminUI adminUI = new AdminUI();
            adminUI.Show();
            this.Hide();
        }

    }
}