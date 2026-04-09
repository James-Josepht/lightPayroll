using lighPayroll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using lightPayrollModel;
using lightPayrollServices;

namespace lighPayrollUI
{
    public partial class EmployeeUI : Form
    {
        private string user_role, user_name;
        private int user_id;
        AdminUI adminUI = new AdminUI(); //used for getting panel design and greeting service
        GreetingService greetings = new GreetingService(); //used for getting greetings
        LogIn logIn = new LogIn(); //used for applying greetings

        public EmployeeUI(string role, string username, int id)
        {
            InitializeComponent();
            user_role = role;
            user_name = username;
            user_id = id;
        }

        private void ApplyRolePermissions()
        {
            switch (user_role)
            {
                case "Manager":
                    greetingLabel.Text = $"Hello {user_name}!";
                    logIn.TypeMessage(sGreetingsLabel, greetings.GetRandomGreeting("Manager"));
                    //btnApprove.Enabled = true;
                    //btnPayroll.Enabled = true;
                    break;

                case "Accountant":
                    greetingLabel.Text = $"Hello {user_name}!";
                    logIn.TypeMessage(sGreetingsLabel, greetings.GetRandomGreeting("Accountant"));
                    //btnPayroll.Enabled = true;
                    //btnApprove.Enabled = false;
                    break;

                case "Employee":
                    greetingLabel.Text = $"Hello {user_name}!";
                    logIn.TypeMessage(sGreetingsLabel, greetings.GetRandomGreeting("Employee"));
                    //btnPayroll.Enabled = false;
                    //btnApprove.Enabled = false;
                    break;
            }
        }


        private void EmployeeUI_Load(object sender, EventArgs e)
        {
            string bibleVerse = greetings.GetRandomGreeting("Christ-Centered Guidance");
            logIn.TypeMessage(encourageVerses, bibleVerse);

            ApplyRolePermissions();
            adminUI.panelDesign(greetingPanel, bodyPanel);
        }


        private void eFeaturesPanel_Click(object sender, EventArgs e)
        {
            EmployeeFeature empFeature = new EmployeeFeature(user_role, user_name, user_id);
            empFeature.Show();
            this.Hide();
        }

        private void headPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            logIn.CustomMessageBox("Signing out");
            Homepage homePage = new Homepage();
            homePage.Show();
            this.Hide();
        }
    }
}
