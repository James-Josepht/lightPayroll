using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lighPayroll
{
    public partial class ClockInFeaturePage : Form
    {
        ClockInDesignPage design = new ClockInDesignPage();
        public ClockInFeaturePage()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer(); // this is for to change features images every mouse hover
            menuStrip2.Renderer = new MyRendererBackground();
        }

        private void ClockInFeaturePage_Load(object sender, EventArgs e)
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
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void attendanceFeatureTab_Click(object sender, EventArgs e)
        {
            AttendanceFeaturePagecs attendanceFeaturePage = new AttendanceFeaturePagecs();
            attendanceFeaturePage.Show();
            this.Hide();
        }


        private void clockInFeatureTab_Click_1(object sender, EventArgs e)
        {
            ClockInFeaturePage clockInFeaturePage = new ClockInFeaturePage();
            clockInFeaturePage.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clockInIntroLabel_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void payrollFeatureTab_Click(object sender, EventArgs e)
        {
            PayrollFeaturePage payroll = new PayrollFeaturePage();
            payroll.Show();
            this.Hide();
        }
    }

    public class ClockInDesignPage
    {
        //I want to set panel edges smooth
        internal void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();

            control.Region = new Region(path);
        }



    }


}
