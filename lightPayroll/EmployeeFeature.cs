using lighPayroll;
using lightPayrollServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lighPayrollUI
{
    public partial class EmployeeFeature : Form
    {
        AdminUI adminUI = new AdminUI(); //used for getting panel design and greeting service

        public EmployeeFeature()
        {
            InitializeComponent();
        }

        private void EmployeeFeature_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) // ensures code runs only at runtime
            {
                adminUI.panelDesign();
            }
        }
 
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = employeeFeatures.TabPages[e.Index];
            Rectangle tabBounds = employeeFeatures.GetTabRect(e.Index);

            // Choose color per tab (example)
            Color textColor;

            if (e.Index == employeeFeatures.SelectedIndex)
                textColor = Color.FromArgb(33, 44, 66);   // selected tab
            else
                textColor = Color.Gray;   // unselected tabs

            TextRenderer.DrawText(
                e.Graphics,
                tabPage.Text,
                e.Font,
                tabBounds,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
