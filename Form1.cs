using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace lighPayroll
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer(); // this is for to change features images every mouse hover
            menuStrip2.Renderer = new MyRendererBackground();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var dd = searchMS.DropDown as ToolStripDropDownMenu;

            if (dd != null)
            {
                dd.ShowImageMargin = false;
                dd.ShowCheckMargin = false;
                dd.Padding = Padding.Empty;
            }


            recentSearches.Margin = new Padding(40, 0, 0, 0); // increase 40 to go left and decrease to put it right
            toolStripSeparator4.Margin = Padding.Empty;
        }


        private void joinHomeBut_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
        private void loginHomeBut_Click(object sender, EventArgs e)
        {

            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }


        private void featureStrip1_Click(object sender, EventArgs e)
        {

        }

        private void featureStrip2_Click(object sender, EventArgs e)
        {

        }


        private void searchBox_Click(object sender, EventArgs e)
        {

        }


        private void clockInFeatureTab_Click(object sender, EventArgs e)
        {
            ClockInFeaturePage clockInFeaturePage = new ClockInFeaturePage();
            clockInFeaturePage.Show();
            this.Hide();
        }

        private void attendanceFeatureTab_Click(object sender, EventArgs e)
        {
            AttendanceFeaturePagecs attendanceFeaturePage = new AttendanceFeaturePagecs();
            attendanceFeaturePage.Show();
            this.Hide();
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
    public class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var item = e.Item;

            Rectangle rect = new Rectangle(Point.Empty, item.Size);

            if (e.Item.Selected || e.Item.Pressed)
            {
                // Do nothing (prevents blue hover highlight)
                return;
            }
            else
            {
                // fallback to normal background color
                using (Brush b = new SolidBrush(item.BackColor))
                {
                    e.Graphics.FillRectangle(b, rect);
                }
            }

            base.OnRenderMenuItemBackground(e);
        }

        


    }

    class MyRendererBackground : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var item = e.Item;

            Rectangle rect = new Rectangle(Point.Empty, item.Size);



            // Draw the item's background image if it has one
            if (item.BackgroundImage != null)
            {
                e.Graphics.DrawImage(
                    item.BackgroundImage,
                    rect
                );

            }

            else
            {
                // fallback to normal background color
                using (Brush b = new SolidBrush(item.BackColor))
                {
                    e.Graphics.FillRectangle(b, rect);
                }
            }

        }
        //this is for allowing drop down to have right color instead of empty filled white
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDownMenu)
            {
                using (Brush b = new SolidBrush(Color.Beige))
                {
                    e.Graphics.FillRectangle(b, e.AffectedBounds);
                }
                return;
            }

            base.OnRenderToolStripBackground(e);
        }


    }


}
