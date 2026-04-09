using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lighPayroll
{
    public partial class PayrollFeaturePage : Form
    {
        ClockInDesignPage design = new ClockInDesignPage();

        public PayrollFeaturePage()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer(); // this is for to change features images every mouse hover
            menuStrip2.Renderer = new MyRendererBackground();

        }

        private void AttendanceFeaturePagecs_Load(object sender, EventArgs e)
        {

            var dd = toolStripMenuItem8.DropDown as ToolStripDropDownMenu;

            if (dd != null)
            {
                dd.ShowImageMargin = false;
                dd.ShowCheckMargin = false;
                dd.Padding = Padding.Empty;
            }

            design.SetRoundedRegion(flowLayoutPanel1, 20); // 20 = curve radius

            recentSearches.Margin = new Padding(40, 0, 0, 0); // increase 40 to go left and decrease to put it right
            toolStripSeparator4.Margin = Padding.Empty;
        }


        private void attendanceFeatureTab_Click(object sender, EventArgs e)
        {
            AttendanceFeaturePagecs attendanceFeaturePage = new AttendanceFeaturePagecs();
            attendanceFeaturePage.Show();
            this.Hide();
        }

        private void clockInFeatureTab_Click(object sender, EventArgs e)
        {
            ClockInFeaturePage clockInFeaturePage = new ClockInFeaturePage();
            clockInFeaturePage.Show();
            this.Hide();
        }

        private void payrollFeatureTab_Click(object sender, EventArgs e)
        {
            PayrollFeaturePage payroll = new PayrollFeaturePage();
            payroll.Show();
            this.Hide();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

    }
}
