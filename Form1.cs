using System.Drawing;


namespace lighPayroll
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
            menuStrip2.Renderer = new MyRendererBackground();
            


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    class MyRenderer : ToolStripProfessionalRenderer
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
    }


}
