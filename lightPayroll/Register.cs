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
            UserName = registerAccountBox.Text;

        }
        private void registerPassTextChange(object sender, EventArgs e)
        {
            UserPass = registerPassBox.Text;
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
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
