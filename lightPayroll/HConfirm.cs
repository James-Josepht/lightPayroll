using System;
using System.Drawing;
using System.Windows.Forms;

namespace lighPayrollUI
{
    public partial class ConfirmForm : Form
    {
        public bool Result { get; private set; }

        public ConfirmForm(string head, string body, bool isConfirmation = true)
        {

            this.Text = " ";
            this.Size = new Size(350, 200);
            this.Font = new Font("Ubuntu Mono", 8, FontStyle.Regular);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Beige;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

            Panel content = new Panel()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(15)
            };

            Label headerlbl = new Label()
            {
                Text = head,
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label bodylbl = new Label()
            {
                Text = body,
                Dock = DockStyle.Fill,
                Height = 80,
                TextAlign = ContentAlignment.MiddleLeft
            };

            //put this label in the panel
            content.Controls.Add(bodylbl);
            content.Controls.Add(headerlbl);

            Button yes = new Button() { Text = "Yes", Width = 80 };
            Button no = new Button() { Text = "No", Width = 80 };

            if (isConfirmation)
            {
                yes.Text = "Yes";
                no.Text = "No";
            }
            else
            {
                yes.Text = "OK";
                no.Visible = false; // hide No button
            }

            FlowLayoutPanel panel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(80, 5, 0, 5)
            };

            panel.Controls.Add(yes);
            panel.Controls.Add(no);

            this.Controls.Add(content);
            this.Controls.Add(panel);

            yes.Click += (s, e) =>
            {
                Result = true;
                this.Close();
            };

            no.Click += (s, e) =>
            {
                Result = false;
                this.Close();
            };
        }
    }
}