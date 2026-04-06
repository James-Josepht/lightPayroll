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

namespace lighPayrollUI
{
    public partial class EmployeeUI : Form
    {
        private string user_role;
        AdminUI adminUI = new AdminUI(); //used for getting panel design and greeting service
        LogIn logIn = new LogIn(); //used for getting greeting service
        public EmployeeUI(string role)
        {
            InitializeComponent();
            user_role = role;
        }

        private void ApplyRolePermissions()
        {
            switch (user_role)
            {
                case "Manager":
                   
                    //btnApprove.Enabled = true;
                    //btnPayroll.Enabled = true;
                    break;

                case "Accountant":
                    //btnPayroll.Enabled = true;
                    //btnApprove.Enabled = false;
                    break;

                case "Employee":
                    //btnPayroll.Enabled = false;
                    //btnApprove.Enabled = false;
                    break;
            }
        }


        private void EmployeeUI_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
            adminUI.panelDesign(greetingPanel, bodyPanel);
        }

        //forces the tab control to draw the text in the color we want

        private void eFeaturesPanel_Click(object sender, EventArgs e)
        {
            EmployeeFeature empFeature = new EmployeeFeature();
            empFeature.Show();
            this.Hide();
        }
    }
}
