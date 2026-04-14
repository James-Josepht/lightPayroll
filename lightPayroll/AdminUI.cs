using lighPayrollUI;
using lighPayrollUI.Properties;
using lightPayrollServices;
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
    public partial class AdminUI : Form
    {

        LogIn loginDesigns = new LogIn();
        public AdminUI()
        {
            InitializeComponent();
            searchMenuStrip.Renderer = new MyRendererBackground(); //for search button design
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) // ensures code runs only at runtime
            {
                GreetingService greetingService = new GreetingService();

                string adminGreeting = greetingService.GetRandomGreeting("Admin") ?? "Hello Admin!";
                string bibleGuidance = greetingService.GetRandomGreeting("Christ-Centered Guidance") ?? "John 3:16";

                loginDesigns.TypeMessage(label1, adminGreeting);
                loginDesigns.TypeMessage(encourageVerses, bibleGuidance);

                panelDesign(greetingPanel, bodyPanel);
            }


            ColorHelper.AddPanelGroupHover(taskPanel, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));
            ColorHelper.AddPanelGroupHover(userControlPanel, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));
            ColorHelper.AddPanelGroupHover(attendanceTool, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));
            ColorHelper.AddPanelGroupHover(payrollTool, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));

        }


        private void searchBox_Click(object sender, KeyEventArgs e) //incase user want to search for a feature
        {
            List<string> storedFeatures = new List<string>
            {
                "Attendance",
                "Employee Removal",
                "Payroll",
                "Reports"
            };

            if (e.KeyCode == Keys.Enter && storedFeatures.Any(feature => searchBox.Text.Contains("Attendance")))
            {
                e.SuppressKeyPress = true;
                AdminAttendance attRecords = new AdminAttendance();
                attRecords.Show();
                this.Hide();
            }
            else if (e.KeyCode == Keys.Enter && !storedFeatures.Any(feature => searchBox.Text.Contains(feature)))
            {
                CustomMessageBox("No results found\r\n\r\nYou may want to try different keywords or check for any possible typos.");
            }
        }

        internal void panelDesign(Panel headPanelDesign = null, Panel bodyPanelDesign = null)
        {
            if (this.DesignMode) return;

            int radius = 30;
            GraphicsPath greetingsPath = new GraphicsPath();
            GraphicsPath bodyPath = new GraphicsPath();

            if (headPanelDesign != null)
            {

                greetingsPath.AddArc(0, 0, radius, radius, 180, 90);
                greetingsPath.AddArc(headPanelDesign.Width - radius, 0, radius, radius, 270, 90);
                greetingsPath.AddArc(headPanelDesign.Width - radius, headPanelDesign.Height - radius, radius, radius, 0, 90);
                greetingsPath.AddArc(0, headPanelDesign.Height - radius, radius, radius, 90, 90);
                greetingsPath.CloseAllFigures();
                headPanelDesign.Region = new Region(greetingsPath);
            }

            if (bodyPanelDesign != null)
            {
                bodyPath.AddArc(0, 0, radius, radius, 180, 90);
                bodyPath.AddArc(bodyPanelDesign.Width - radius, 0, radius, radius, 270, 90);
                bodyPath.AddArc(bodyPanelDesign.Width - radius, bodyPanelDesign.Height - radius, radius, radius, 0, 90);
                bodyPath.AddArc(0, bodyPanelDesign.Height - radius, radius, radius, 90, 90);
                bodyPath.CloseAllFigures();

                bodyPanelDesign.Region = new Region(bodyPath);
            }

            var dd = searchMS.DropDown as ToolStripDropDownMenu; //removing empty whitespace

            if (dd != null)
            {
                dd.ShowImageMargin = false;
                dd.ShowCheckMargin = false;
                dd.Padding = Padding.Empty;
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

            customMsg.Text = "      ";
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


        private void attendanceToolClick(object sender, EventArgs e)
        {
            AdminAttendance home = new AdminAttendance();
            home.Show();
            this.Hide();
        }

        private void userControlPanel_Click(object sender, EventArgs e)
        {
            AdminUserMod userModification = new AdminUserMod();
            userModification.Show();
            this.Hide();
        }

 
        private void exitButton_Click(object sender, EventArgs e)
        {
            LogIn messageBox = new LogIn();

            messageBox.CustomMessageBox("Signing out.");
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void toDoPanel_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();

        }

    }

}
