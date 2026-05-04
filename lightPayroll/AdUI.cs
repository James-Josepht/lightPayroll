using lighPayrollUI;
using lighPayrollUI.Properties;
using lightPayrollServices;
using Microsoft.Win32.SafeHandles;
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
    public partial class AdUI : Form
    {

        PLogIn loginDesigns = new PLogIn();
        public AdUI()
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


            HColorPanel.AddPanelGroupHover(taskPanel, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));
            HColorPanel.AddPanelGroupHover(userControlPanel, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));
            HColorPanel.AddPanelGroupHover(attendancePanel, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));
            HColorPanel.AddPanelGroupHover(requestsPanel, Color.FromArgb(60, 75, 100), Color.FromArgb(33, 44, 66));


        }



        private void attendanceToolClick(object sender, EventArgs e)
        {
            AdFeature home = new AdFeature("Attendance");
            home.Show();
            this.Hide();
        }

        private void userControlPanel_Click(object sender, EventArgs e)
        {
            AdFeature userModification = new AdFeature("UserControl");
            userModification.Show();
            this.Hide();
        }



        private void toDoPanel_Click(object sender, EventArgs e)
        {
            AdDashboard dashboard = new AdDashboard("Admin", "null", 0);
            dashboard.Show();
            this.Hide();

        }

        private void requestsPanel_Click(object sender, EventArgs e)
        {

            AdFeature home = new AdFeature("Requests");
            home.Show();
            this.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            PLogIn messageBox = new PLogIn();

            messageBox.CustomMessageBox("Signing out.");
            PHome homepage = new PHome();
            homepage.Show();
            this.Hide();
        }

        private void searchBox_Click(object sender, KeyEventArgs e) //incase user want to search for a feature
        {
            List<string> storedFeatures = new List<string>
            {
                "attendance",
                "employee removal",
                "payroll",
                "reports"
            };

            if (e.KeyCode == Keys.Enter && storedFeatures.Any(feature => searchBox.Text.ToLower().Contains(feature)))
            {
                e.SuppressKeyPress = true;
                AdFeature attRecords = new AdFeature("Attendance");
                attRecords.Show();
                this.Hide();
            }
            else if (e.KeyCode == Keys.Enter && !storedFeatures.Any(feature => searchBox.Text.ToLower().Contains(feature)))
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

    }

}
