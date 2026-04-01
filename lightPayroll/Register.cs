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
        private string username;
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
           Username = registerAccountBox.Text;
            
        }
        private void registerPassTextChange(object sender, EventArgs e)
        {
            string password = registerPassBox.Text;
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            if (authService.IsReserved(Username))
            {
                loginDesigns.showCustomMessage("This username is reserved. Please choose a different one.");
            }
        }
        private void showPassBoxClick(object sender, EventArgs e)
        {
            registerPassBox.UseSystemPasswordChar = !showPassBox.Checked;
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
    }
}
