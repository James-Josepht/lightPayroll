using lighPayrollUI;
using lightPayrollServices;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;
//timer is having conflict between System.Windows.Forms and System.Thread.Tasks, so I am using an alias

namespace lighPayroll
{
    

    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            TypeText(logckInLabel, "Let's LOGK IN!");
        }
        //used for Greetings lol
        public void TypeText(Label lbl, string text, int speed = 50)
        {
            int i = 0;

            //timer is having conflict between System.Windows.Forms and System.Thread.Tasks, so I am using an alias
            WinFormsTimer t = new WinFormsTimer();
            t.Interval = speed;

            t.Tick += (s, e) =>
            {
                if (i < text.Length)
                {
                    lbl.Text += text[i];
                    i++;
                }
                else
                {
                    t.Stop();
                }
            };

            lbl.Text = "";
            t.Start();
        }

        private void backHomeButton_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }


        private void showPassBox_CheckedChanged(object sender, EventArgs e)
        {
            passLogBox.UseSystemPasswordChar = !showPassBox.Checked;
        }

        private void loginButtonClick(object sender, EventArgs e)
        {

            string username = userLogBox.Text.Trim();
            string password = passLogBox.Text.Trim();

            AdminUI admin = new AdminUI();
            EmployeeUI employee = new EmployeeUI();
            
            AuthService validator = new AuthService();

            string status = validator.ValidateCredentials(username, password);

            if (status == "Active" && username.ToLower() == "admin")
            {
                showCustomMessage("Login successful!");
                admin.Show();
                this.Hide();
            }
            else if (status == "Active" && username.ToLower() != "admin")
            {
                showCustomMessage("Login successful!");
                employee.Show();
                this.Hide();
            }
            else if (status == "Pending")
            {
                showCustomMessage("Your account is pending approval.");

            }
            else
            {
                showCustomMessage("Invalid credentials.");
            }
        }

        public void showCustomMessage(string message)
        {
            Form customMsg = new Form();

            // Remove title bar buttons
            customMsg.FormBorderStyle = FormBorderStyle.FixedDialog; // No resize
            customMsg.ControlBox = false; // Removes Close (X) button and the entire control box
            customMsg.StartPosition = FormStartPosition.CenterScreen;
            customMsg.Size = new Size(400, 200);
            customMsg.BackColor = Color.White;

            customMsg.Text = "     ";
            customMsg.Size = new Size(300, 150);
            customMsg.StartPosition = FormStartPosition.CenterScreen;
            customMsg.BackColor = Color.Beige;

            Label lbl = new Label();
            lbl.Text = message;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Ubuntu Mono", 7, FontStyle.Regular);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Dock = DockStyle.Bottom;
            okButton.Click += (s, e) => customMsg.Close();

            customMsg.Controls.Add(lbl);
            customMsg.Controls.Add(okButton);

            customMsg.ShowDialog();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
