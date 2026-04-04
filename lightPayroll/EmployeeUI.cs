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
        public EmployeeUI()
        {
            InitializeComponent();
        }

        private void EmployeeUI_Load(object sender, EventArgs e)
        {

        }

        //forces the tab control to draw the text in the color we want
        private void employeeFeatures_DrawItem(object sender, DrawItemEventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
