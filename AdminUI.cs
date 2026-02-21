using lighPayroll.Properties;
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
        public AdminUI()
        {
            InitializeComponent();
            searchMenuStrip.Renderer = new MyRendererBackground();
        }



        private void AdminUI_Load(object sender, EventArgs e)
        {
            panelDesign();

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
                AttendanceRecords attRecords = new AttendanceRecords();
                attRecords.Show();
                this.Hide();
            }
            else if (e.KeyCode == Keys.Enter && !storedFeatures.Any(feature => searchBox.Text.Contains(feature)))
            {
                showCustomMessage("No results found\r\n\r\nYou may want to try different keywords or check for any possible typos.");
            }
        }

        private void panelDesign()
        {
            int radius = 30;

            GraphicsPath greetingsPath = new GraphicsPath();
            greetingsPath.AddArc(0, 0, radius, radius, 180, 90);
            greetingsPath.AddArc(greetingPanel.Width - radius, 0, radius, radius, 270, 90);
            greetingsPath.AddArc(greetingPanel.Width - radius, greetingPanel.Height - radius, radius, radius, 0, 90);
            greetingsPath.AddArc(0, greetingPanel.Height - radius, radius, radius, 90, 90);
            greetingsPath.CloseAllFigures();

            GraphicsPath bodyPath = new GraphicsPath();
            bodyPath.AddArc(0, 0, radius, radius, 180, 90);
            bodyPath.AddArc(bodyPanel.Width - radius, 0, radius, radius, 270, 90);
            bodyPath.AddArc(bodyPanel.Width - radius, bodyPanel.Height - radius, radius, radius, 0, 90);
            bodyPath.AddArc(0, bodyPanel.Height - radius, radius, radius, 90, 90);
            bodyPath.CloseAllFigures();

            greetingPanel.Region = new Region(greetingsPath);
            bodyPanel.Region = new Region(bodyPath);



            var dd = searchMS.DropDown as ToolStripDropDownMenu; //removing empty whitespace

            if (dd != null)
            {
                dd.ShowImageMargin = false;
                dd.ShowCheckMargin = false;
                dd.Padding = Padding.Empty;
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
            AttendanceRecords home = new AttendanceRecords();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
