using lighPayrollUI;
using lighPayrollUI.Properties;
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
        HBorderRadius curveBorder = new HBorderRadius();

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

            curveBorder.SetRoundedRegion(featurePanel, 11);
            curveBorder.SetRoundedRegion(panel7, 11);
            curveBorder.SetRoundedRegion(panel8, 11);
            curveBorder.SetRoundedRegion(headFeaturePanel, 11);

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
                    label1.Text = "Phase 1: Search Name";
                    label4.Text = "The user searches for an employee by \nname to locate their record.";
                    phase1Pic.Image = Resources.payrollPhase1;
                    phase1Pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    label2.Text = "Phase 2: Click ID";
                    label5.Text = "The user selects the employee by clicking \ntheir ID from the results.";
                    phase2Pic.Image = Resources.payrollPhase2;
                    phase2Pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    label3.Text = "Phase 3: Calculate";
                    label6.Text = "The system computes the payroll based on \nthe employee’s attendance, overtime, \nand deductions.";
                    phase3pic.Image = Resources.payrollPhase3;
                    phase3pic.SizeMode = PictureBoxSizeMode.StretchImage;

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

        private void headFeaturePic_Click(object sender, EventArgs e)
        {

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
