using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace lighPayroll
{

    public partial class PHome : Form
    {

        public PHome()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer(); // this is for to change features images every mouse hover
            searchMenuStrip.Renderer = new MyRendererBackground();
            menuButtonStrip.Renderer = new MyRendererBackground();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            menuButton.DropDown.AutoSize = false;
            menuButton.DropDown.Width = menuButton.Width + 10;

            var searchDD = searchMS.DropDown as ToolStripDropDownMenu; //clear dropdown background:>

            if (searchDD != null)
            {
                searchDD.ShowImageMargin = false;
                searchDD.ShowCheckMargin = false;
                searchDD.Padding = Padding.Empty;
            }


            var dd = menuButton.DropDown as ToolStripDropDownMenu;

            if (dd != null)
            {
                dd.ShowImageMargin = false;
                dd.ShowCheckMargin = false;
                dd.Padding = Padding.Empty;
            }


            recentSearches.Margin = new Padding(17, 0, 0, 0); // increase 40 to go left and decrease to put it right
            toolStripSeparator4.Margin = Padding.Empty;

            ScaleContentToSize();
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
            // Use 900px as a reliable fixed breakpoint instead of % of screen
            bool isNarrow = ClientSize.Width < 900;
            bool isMedium = ClientSize.Width < 1000;

            if (isMedium)
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 100;
                tableLayoutPanel1.ColumnStyles[1].Width = 0;
                panel7.Visible = false;
            }
            else
            {
                tableLayoutPanel1.ColumnStyles[0].Width = 60;
                tableLayoutPanel1.ColumnStyles[1].Width = 40;
                panel7.Visible = true;
            }

            if (isNarrow)
            {
                panel4.Visible = false;
                menuButtonPanel.Visible = true;
                menuButtonPanel.Enabled = true;
                panel5.Enabled = false;
                panel5.Visible = false;
                logPanel.Enabled = false;
                logPanel.Visible = false;
            }
            else
            {
                panel4.Visible = true;
                menuButtonPanel.Visible = false;
                menuButtonPanel.Enabled = false;
                panel5.Enabled = true;
                panel5.Visible = true;
                logPanel.Visible = true;
                logPanel.Enabled = true;
            }

            ScaleContentToSize();
        }

        private void loginStrip_Click(object sender, EventArgs e)
        {
            PLogIn logIn = new PLogIn();
            logIn.Show();
            this.Hide();
        }

        private void registerStrip_Click(object sender, EventArgs e)
        {
            PRegister register = new PRegister();
            register.Show();
            this.Hide();
        }

        private void searchStrip_Click(object sender, EventArgs e)
        {
            AdUI customMessage = new AdUI(0); //I put zero if not for login but for message 'v'
            customMessage.CustomMessageBox("Coming soon!");
        }

        private void ScaleContentToSize()
        {
            if (ClientSize.Width >= 1300)
            {
                float baseHeight = 645f;
                float heightScale = Math.Max(0.6f,
                    Math.Min(2.0f, ClientSize.Height / baseHeight));

                label1.Font = new Font("Ubuntu Mono",
                    Math.Max(14f, 28.2f * heightScale),
                    FontStyle.Bold);

                label2.Font = new Font("Ubuntu Mono",
                    Math.Max(9f, 12f * heightScale),
                    FontStyle.Bold);
            }
            else if (ClientSize.Height <= 500)
            {
                label2.Visible = false;

                secondBenefitLbl.Visible = false;
                firstBenefitLbl.Visible = false;

                firstCheck.Visible = false;
                secondCheck.Visible = false;
            }
            else
            {
                label1.Font = new Font("Ubuntu Mono", 28.2f, FontStyle.Bold);
                label2.Font = new Font("Ubuntu Mono", 12f, FontStyle.Bold);

                label2.Visible = true;

                secondBenefitLbl.Visible = true;
                firstBenefitLbl.Visible = true;

                firstCheck.Visible = true;
                secondCheck.Visible = true;
            }

            // Always reposition left panel text
            int leftMargin = (int)(panel2.Width * 0.09f);
            label1.Location = new Point(leftMargin, (int)(panel2.Height * 0.25f));
            label2.Location = new Point(leftMargin, (int)(panel2.Height * 0.55f));

            // Always resize penguin
            int size = Math.Min(panel7.Width / 2, panel7.Height / 2);

            penguinPic.Size = new Size(size, size);
            penguinPic.Left = (panel7.Width - size) / 2;
            penguinPic.Top = (panel7.Height - size) / 4;

            firstCheck.Location =
                new Point(penguinPic.Left - 35, penguinPic.Bottom + 5);

            firstBenefitLbl.Location =
                new Point(penguinPic.Left, firstCheck.Top);

            secondCheck.Location =
                new Point(penguinPic.Left - 35, firstCheck.Bottom + 5);

            secondBenefitLbl.Location =
                new Point(penguinPic.Left, secondCheck.Top);

            float rightScale = Math.Max(0.7f,
             Math.Min(1.8f, panel7.Height / 489f));

            float benefitSize = 13.8f * rightScale;

            firstBenefitLbl.Font =
                new Font("Ubuntu Mono", benefitSize, FontStyle.Bold);

            secondBenefitLbl.Font =
                new Font("Ubuntu Mono", benefitSize, FontStyle.Bold);

            firstCheck.Font =
                new Font("Ubuntu Mono", benefitSize, FontStyle.Bold);

            secondCheck.Font =
                new Font("Ubuntu Mono", benefitSize, FontStyle.Bold);
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
    

        //used for changing search button not changing when clicked not the dropdown itself!
        public class MyRendererBackground : ToolStripProfessionalRenderer
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
