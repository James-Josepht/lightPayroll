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
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        //once the user leaves the username textbox, validate the email format 
        private void registerAccountBox_Leave(object sender, EventArgs e)
        {

            userName = registerAccountBox.Text;

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
        }

        private void registerPassBox_Leave(object sender, EventArgs e)
        {
            userPass = registerPassBox.Text;
            if (userPass.Length < 8)
            {
                invalidPassword.Visible = true; // Show the password error message
                registerButton.Enabled = false; // Disable the register button
                return;
            }
            else
            {
                invalidPassword.Visible = false;
                registerButton.Enabled = true;
            }
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userPass))
            {
                loginDesigns.CustomMessageBox("Fields must not be empty.");
                return;
            }



            //check if username exist in database
            if (authService.IsReserved(userName))
            {
                loginDesigns.CustomMessageBox("This username is invalid. Please choose a different one.");
            }
            else if (authService.RegisterAccount(userName, userPass))
            {
                loginDesigns.CustomMessageBox("Registration successful! You can now log in.");
                LogIn login = new LogIn();
                login.Show();
                this.Hide();
            }
            else
            {
                loginDesigns.CustomMessageBox("This username is taken. Please try again.");
            }

        }

        private void showPassBoxClick(object sender, EventArgs e)
        {
            registerPassBox.UseSystemPasswordChar = !showPassBox.Checked;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

  


    }
}
