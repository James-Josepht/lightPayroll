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
            greetingsAndMessageBoxDesign.TypeText(label2, "Trust But Always Verify!");
        }

        // Load directly from database
        private void LoadUserList()
        {
            attendanceGrid.DataSource = SQLiteDataAccess.LoadUsers();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }



        // Update ONLY when button is clicked
        private void modifyRowButton_Click(object sender, EventArgs e)
        {
            // Validate input first
            if (!int.TryParse(idTxtBox.Text, out int userId))
            {
                greetingsAndMessageBoxDesign.CustomMessage("Please enter a valid numeric User ID.");
                return;
            }

            if (SQLiteDataAccess.GetUserByIdOrUsername(userId.ToString()) == null)
            {
                greetingsAndMessageBoxDesign.CustomMessage("User ID not found.");
                return;
            }

            // Optional: get status from another control (example)
            string status = statusComboBox.Text;
            string role = roleComboBox.Text;

            if (string.IsNullOrEmpty(status) || string.IsNullOrEmpty(role))
            {
                greetingsAndMessageBoxDesign.CustomMessage("Please select both status and role.");
                return;
            }

            SQLiteDataAccess.UpdateUserStatus(userId, status, role);

            greetingsAndMessageBoxDesign.CustomMessage("User updated successfully!");

            // Refresh grid
            LoadUserList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminUI adminUI = new AdminUI();
            adminUI.Show();
            this.Hide();
        }
    }
}