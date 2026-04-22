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
    public partial class PFeauture : Form
    {
        //class below this, used for designing only
        ClockInDesignPage design = new ClockInDesignPage();

        private string page_feature;
        public PFeauture(string feature)
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer(); // this is for to change features images every mouse hover
            menuStrip2.Renderer = new MyRendererBackground();
            page_feature = feature;

        }

        private void ClockInFeaturePage_Load(object sender, EventArgs e)
        {
            var dd = toolStripMenuItem8.DropDown as ToolStripDropDownMenu;
            SetFeature(page_feature);

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


        private void FeatureTab_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;

            //string feature = btn.Tag.ToString();

            ToolStripMenuItem item = sender as ToolStripMenuItem;

            string feature = item.Tag.ToString();

            PFeauture page = new PFeauture(feature);
            page.Show();
            this.Hide();


        }


        private void home_Click(object sender, EventArgs e)
        {
            PHome home = new PHome();
            home.Show();
            this.Hide();
        }

        public void SetFeature(string featureType)
        {
            switch (featureType)
            {
                case "Clock In":
                    introLabel.Text = "Clock In";

                    break;

                case "Attendance":
                    introLabel.Text = "Attendance";

                    break;

                case "Payroll":
                    introLabel.Text = "Payroll";

                    break;
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            PLogIn logIn = new PLogIn();
            logIn.Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            PRegister register = new PRegister();
            register.Show();
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
