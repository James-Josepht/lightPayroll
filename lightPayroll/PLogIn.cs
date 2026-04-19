using Dapper;
using lighPayrollUI;
using lightPayrollServices;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;
//timer is having conflict between System.Windows.Forms and System.Thread.Tasks, so I am using an alias

namespace lighPayroll
{
    

    public partial class PLogIn : Form
    {

        public PLogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            TypeMessage(logckInLabel, "Let's LOGK IN!");

        }

        private void backHomeButton_Click(object sender, EventArgs e)
        {
            PHome home = new PHome();
            home.Show();
            this.Hide();
        }


        private void showPassBox_CheckedChanged(object sender, EventArgs e)
        {
            passLogBox.UseSystemPasswordChar = !showPassBox.Checked;
        }

        private void loginButtonClick(object sender, EventArgs e)
        {

            string email = userLogBox.Text.Trim();
            string password = passLogBox.Text.Trim();
            string formattedName = "";
            AdUI admin = new AdUI();
            
            
            AuthService validator = new AuthService();

            string status = validator.ValidateCredentials(email, password);
            string role = SQLiteDataAccess.GetUserRoleByUsername(email);
            int userID = 0;


            if (status != "Active" && status != "Pending" && status != "Rejected")
            {
                CustomMessageBox("Invalid credentials.");
                return;
            }

            if (email.ToLower() != "admin" )
            {
                userID = SQLiteDataAccess.GetUserIdByUsername(email);
                string usernamePart = email.Split('@')[0]; // "first.last"
                string[] parts = usernamePart.Split('.');

                //capitalizing first letter of each word in username
                parts[0] = char.ToUpper(parts[0][0]) + parts[0].Substring(1);
                parts[1] = char.ToUpper(parts[1][0]) + parts[1].Substring(1); 

                formattedName = string.Join(" ", parts); //First Last
            }

          
            // UI for manager, accountant, and employee shared the same form, but different layout.
            

            if (status == "Active")
            {
                EUI employee = new EUI(role, formattedName, userID);
                if (email.ToLower() == "admin" && password == "admin" || role == "Admin")
                {

                    //string pass = PasswordHash.HashPassword("testpass");
                    //Clipboard.SetText(pass);
                    //MessageBox.Show(pass);
                    CustomMessageBox("Login successful!");
                    admin.Show();
                    this.Hide();
                }
                else
                {
                     CustomMessageBox("Login successful!");
                    employee.Show();
                    this.Hide();
                }

            }
            else if (status == "Pending")
            {
                CustomMessageBox("Your account is pending approval.");

            }
            else
            {
                CustomMessageBox("Invalid credentials.");
            }
        }

        public void CustomMessageBox(string message)
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

      

        //used for Greetings lol
        public void TypeMessage(Label lbl, string text, int speed = 50)
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



        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
