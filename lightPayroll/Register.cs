using GemBox.Spreadsheet;
using lightPayrollServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lighPayroll
{
    public partial class Register : Form
    {
        AuthService authService = new AuthService();
        LogIn loginDesigns = new LogIn();
        private string userName;
        private string userPass;

        public Register()
        {
            InitializeComponent();
        }
        private void backHomeButtonClick(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void registerAccountTextChange(object sender, EventArgs e)
        {
            AuthService authService = new AuthService();

            UserName = registerAccountBox.Text;
        }

        private void registerPassTextChange(object sender, EventArgs e)
        {
            // Check if the username (email) is in valid format
            bool isValid = authService.IsValidLightEmail(userName);
            invalidUsername.Visible = !isValid; // Show the error message if not valid

            if (isValid)
            {
                registerButton.Enabled = true;
            }
            else
            {
                registerButton.Enabled = false;
            }


            UserPass = registerPassBox.Text;
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            if (UserPass.Length < 8)
            {
                invalidPassword.Visible = true; // Show the password error message
                registerButton.Enabled = false; // Disable the register button
                return;
            }
            else
            {
                invalidPassword.Visible = false; // Hide the password error message
                registerButton.Enabled = true; // Enable the register button
            }



            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(UserPass))
            {
                loginDesigns.showCustomMessage("Please fill in all fields.");
                return;
            }



            //check if username exist in database
            if (authService.IsReserved(UserName))
            {
                loginDesigns.showCustomMessage("This username is invalid. Please choose a different one.");
            }
            else if (authService.RegisterAccount(UserName, UserPass))
            {
                loginDesigns.showCustomMessage("Registration successful! You can now log in.");
                LogIn login = new LogIn();
                login.Show();
                this.Hide();
            }
            else
            {
                loginDesigns.showCustomMessage("This username is taken. Please try again.");
            }

        }
        private void showPassBoxClick(object sender, EventArgs e)
        {
            registerPassBox.UseSystemPasswordChar = !showPassBox.Checked;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

  

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string UserPass
        {
            get { return this.userPass; }
            set { this.userPass = value; }
        }

    }
}
