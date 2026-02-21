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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lighPayroll
{
    public partial class AttendanceRecords : Form
    {
        List<StoredAttendance> storedUsers = new List<StoredAttendance>
        {
            new StoredAttendance("23-3815-938", "shalomsavedbychrist", "shalom.saved@company.org", "02-03-26, 7:30 AM", "02-03-26, 3:30 PM"),
            new StoredAttendance("25-3000-123", "itisnotyouitisme", "itisnotyou.me@company.org", "02-04-26, 8:00 AM", "02-04-26, 8:30 PM"),
            new StoredAttendance("24-1234-456", "jamesneedjesus", "james.jesus@company.org", "02-05-26, 10:00 AM", "02-05-26, 10:30 AM")
        };
        private void AttendanceRecords_Load(object sender, EventArgs e)
        {
            foreach (var att in storedUsers)
            {
                attendanceGrid.Rows.Add(att.UserID, att.Username, att.Email, att.ClockInDate, att.ClockOutDate);
            }

            attendanceGrid.AutoGenerateColumns = false;
            panelDesign();

        }


        public AttendanceRecords()
        {
            InitializeComponent();
        }


        private void delORmod_Opening(object sender, CancelEventArgs e)
        {


        }

        private void attendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore header/invalid clicks
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var clickedColumn = attendanceGrid.Columns[e.ColumnIndex];

            // Identify the button column correctly (use the designer field or the actual column name)
            /* if (clickedColumn == decisionColumn || clickedColumn.Name == "decisionColumn" || clickedColumn is DataGridViewButtonColumn)
             {
                 // Map row index to your stored list (ensure rows aren't sorted/filtered)
                 StoredAttendance selectedUser = storedUsers[e.RowIndex];

                 MessageBox.Show($"User {selectedUser.Username} clocked in at {selectedUser.ClockInDate}");
             }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelDesign()
        {
            int radius = 30;

            GraphicsPath greetingsPath = new GraphicsPath();
            greetingsPath.AddArc(0, 0, radius, radius, 180, 90);
            greetingsPath.AddArc(bodyPanel.Width - radius, 0, radius, radius, 270, 90);
            greetingsPath.AddArc(bodyPanel.Width - radius, bodyPanel.Height - radius, radius, radius, 0, 90);
            greetingsPath.AddArc(0, bodyPanel.Height - radius, radius, radius, 90, 90);
            greetingsPath.CloseAllFigures();

            GraphicsPath bodyPath = new GraphicsPath();
            bodyPath.AddArc(0, 0, radius, radius, 180, 90);
            bodyPath.AddArc(bodyPanel.Width - radius, 0, radius, radius, 270, 90);
            bodyPath.AddArc(bodyPanel.Width - radius, bodyPanel.Height - radius, radius, radius, 0, 90);
            bodyPath.AddArc(0, bodyPanel.Height - radius, radius, radius, 90, 90);
            bodyPath.CloseAllFigures();

            bodyPanel.Region = new Region(greetingsPath);
            bodyPanel.Region = new Region(bodyPath);



            var dd = searchMS.DropDown as ToolStripDropDownMenu; //removing empty whitespace

            if (dd != null)
            {
                dd.ShowImageMargin = false;
                dd.ShowCheckMargin = false;
                dd.Padding = Padding.Empty;
            }

        }

        private void decisionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    internal class StoredAttendance
    {
        private string username;
        private string userID;
        private string email;
        private string clockInDate;
        private string clockOutDate;
        

        public StoredAttendance(string userID, string username, string email, string clockIn, string clockOut)
        {
            this.Username = username;
            this.UserID = userID;
            this.Email = email;
            this.ClockInDate = clockIn;
            this.ClockOutDate = clockOut;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ClockInDate
        {
            get { return clockInDate; }
            set { clockInDate = value; }
        }
        public string ClockOutDate
        {
            get { return clockOutDate; }
            set { clockOutDate = value; }
        }
    }
}
