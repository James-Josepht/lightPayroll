using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (clickedColumn == decisionColumn || clickedColumn.Name == "decisionColumn" || clickedColumn is DataGridViewButtonColumn)
            {
                // Map row index to your stored list (ensure rows aren't sorted/filtered)
                StoredAttendance selectedUser = storedUsers[e.RowIndex];

                MessageBox.Show($"User {selectedUser.Username} clocked in at {selectedUser.ClockInDate}");
            }
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
