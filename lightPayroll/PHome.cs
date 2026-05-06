using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace lighPayroll
{

    public partial class PHome : Form
    {
        private Rectangle panel7riginalRect;

        private Size formOriginalSize;

        public PHome()
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


            recentSearches.Margin = new Padding(17, 0, 0, 0); // increase 40 to go left and decrease to put it right
            toolStripSeparator4.Margin = Padding.Empty;

            //starting in here, I am saving the original size and location of the controls to be used in resizing the form
            panel7riginalRect = new Rectangle(panel7.Location.X, panel7.Location.Y, panel7.Width, panel7.Height);
        }


        private void joinHomeBut_Click(object sender, EventArgs e)
        {
            PRegister register = new PRegister();
            register.Show();
            this.Hide();
        }
        private void searchBox_Click(object sender, KeyEventArgs e)
        {
            AdUI customMessage = new AdUI(0);
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevents beep sound

                string searchText = searchBox.Text.ToLower();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    customMessage.CustomMessageBox("Search not found.");
                }
                else if (searchText == "payroll")
                {
                    PFeauture page = new PFeauture("Payroll");
                    page.Show();
                    this.Hide();
                }
                else if (searchText == "clock in")
                {
                    PFeauture page = new PFeauture("Clock In");
                    page.Show();
                    this.Hide();
                }
                else if (searchText == "attendance")
                {
                    PFeauture page = new PFeauture("Attendance");
                    page.Show();
                    this.Hide();
                }


            }
        }
        private void loginHomeBut_Click(object sender, EventArgs e)
        {

            PLogIn login = new PLogIn();
            login.Show();
            this.Hide();
        }



        private void featureStrip2_Click(object sender, EventArgs e)
        {

        }



        private void FeatureTab_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            string feature = item.Tag.ToString();

            PFeauture page = new PFeauture(feature);
            page.Show();
            this.Hide();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PHome home = new PHome();
            home.Show();
            this.Hide();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Width < 833) // threshold
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 100;
                tableLayoutPanel1.ColumnStyles[1].Width = 0;

                panel7.Visible = false; // optional but cleaner

                if (this.Width < 800)
                {
                    panel4.Visible = false;
                    menu.Visible = true;
                    menu.Enabled = true;
                    panel5.Enabled = false;
                    panel5.Visible = false;
                    logPanel.Enabled = false;
                    logPanel.Visible = false;

                }
            }
            else
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 60;
                tableLayoutPanel1.ColumnStyles[1].Width = 40;

                panel7.Visible = true;

                panel4.Visible = true;
                menu.Visible = false;
                menu.Enabled = false;
                panel5.Enabled = true;
                panel5.Visible = true;
                logPanel.Visible = true;
                logPanel.Enabled = true;
            }
        }

   
    }

    //used for changing the hover color in features
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

    //used for changing search button not changing when clicked
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
