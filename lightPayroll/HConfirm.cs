using System;
using System.Drawing;
using System.Windows.Forms;

namespace lighPayrollUI
{
    public partial class ConfirmForm : Form
    {
            public bool Result { get; private set; }

            // NEW: properties for inputs
            public string Email { get; private set; }
            public string MiddleName { get; private set; }


            public ConfirmForm(string head, string body, bool isConfirmation = true, bool withInput = false)
            {
                this.Text = " ";
                this.Size = new Size(350, withInput ? 260 : 200); // adjust height if inputs exist
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
                    Dock = DockStyle.Top,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                // NEW INPUT CONTROLS
                Label emailLbl = new Label()
                {
                    Text = "Email:",
                    Dock = DockStyle.Top,
                    Visible = withInput
                };

                TextBox emailBox = new TextBox()
                {
                    Dock = DockStyle.Top,
                    Visible = withInput
                };

                Label middleLbl = new Label()
                {
                    Text = "Middle Name:",
                    Dock = DockStyle.Top,
                    Visible = withInput
                };

                TextBox middleBox = new TextBox()
                {
                    Dock = DockStyle.Top,
                    Visible = withInput
                };

                // Add controls in reverse order (WinForms stacking)
                content.Controls.Add(middleBox);
                content.Controls.Add(middleLbl);
                content.Controls.Add(emailBox);
                content.Controls.Add(emailLbl);

                if (!(string.IsNullOrEmpty(body) || string.IsNullOrWhiteSpace(body)))
                    content.Controls.Add(bodylbl);

                content.Controls.Add(headerlbl);

                Button yes = new Button() { Text = "Confirm", Width = 80 };
                Button no = new Button() { Text = "Cancel", Width = 80 };

                if (isConfirmation)
                {
                    yes.Text = "Confirm";
                    no.Text = "Cancel";
                }
                else
                {
                    yes.Text = "OK";
                    no.Visible = false;
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

                //capture input
                yes.Click += (s, e) =>
                {
                    Email = emailBox.Text;
                    MiddleName = middleBox.Text;
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