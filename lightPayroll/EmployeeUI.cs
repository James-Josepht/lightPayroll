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
        AdminUI adminUI = new AdminUI(); //used for getting panel design and greeting service
        public EmployeeUI()
        {
            InitializeComponent();
        }



        private void EmployeeUI_Load(object sender, EventArgs e)
        {
            adminUI.panelDesign(greetingPanel, bodyPanel);
        }

        //forces the tab control to draw the text in the color we want


        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eFeaturesPanel_Click(object sender, EventArgs e)
        {
            EmployeeFeature empFeature = new EmployeeFeature();
            empFeature.Show();
            this.Hide();
        }
    }
}
