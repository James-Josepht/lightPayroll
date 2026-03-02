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
using Microsoft.VisualBasic;
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

        // remembers the row the context menu is opened for (still used by context menu flows)
        private int selectedRowIndex = -1;

        public AttendanceRecords()
        {
            InitializeComponent();

            // Create and wire the context menu items programmatically so designer stays untouched.
            var removeItem = new ToolStripMenuItem("Remove User", null, userRMbutton_Click) { Name = "userRMbutton" };
            var modifyItem = new ToolStripMenuItem("Modify", null, modifyButton_Click) { Name = "modifyButton" };
            var addItem = new ToolStripMenuItem("Add New", null, addButton_Click) { Name = "addButton" };


            delORmod.Items.Clear();
            delORmod.Items.Add(removeItem);
            delORmod.Items.Add(modifyItem);
            delORmod.Items.Add(new ToolStripSeparator());
            delORmod.Items.Add(addItem);

            addUserButton.Click += addButton_Click;
            modifyRowButton.Click += modifyButton_Click;
            deleteRowButton.Click += userRMbutton_Click;


        }

        private void AttendanceRecords_Load(object sender, EventArgs e)
        {
            foreach (var att in storedUsers)
            {
                attendanceGrid.Rows.Add(att.UserID, att.Username, att.Email, att.ClockInDate, att.ClockOutDate);
            }

            attendanceGrid.AutoGenerateColumns = false;
            panelDesign();
        }





        private int GetSelectedRowIndex()
        {
            if (attendanceGrid.SelectedRows != null && attendanceGrid.SelectedRows.Count > 0)
                return attendanceGrid.SelectedRows[0].Index;

            if (attendanceGrid.CurrentCell != null)
                return attendanceGrid.CurrentCell.RowIndex;

            return -1;
        }

        private void userRMbutton_Click(object? sender, EventArgs e)
        {
            // prefer the index stored from context menu; fall back to current selection
            int idx = selectedRowIndex >= 0 ? selectedRowIndex : GetSelectedRowIndex();
            if (idx < 0 || idx >= attendanceGrid.Rows.Count)
            {
                MessageBox.Show("Select a row to delete.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedRowIndex = -1;
                return;
            }

            var idCell = attendanceGrid.Rows[idx].Cells["userIDColumn"].Value;
            string id = idCell?.ToString() ?? string.Empty;

            if (MessageBox.Show($"Remove user with ID '{id}'?", "Confirm remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                selectedRowIndex = -1;
                return;
            }

            // Remove from backing list using the user id (safer when sorting/filtering may be added)
            var stored = storedUsers.FirstOrDefault(s => s.UserID == id);
            if (stored != null)
            {
                storedUsers.Remove(stored);
            }

            // Remove the row from grid (if the row still exists)
            if (idx >= 0 && idx < attendanceGrid.Rows.Count)
            {
                if (idx < 0 || attendanceGrid.Rows[idx].IsNewRow)
                    return;
                attendanceGrid.Rows.RemoveAt(idx);
            }

            selectedRowIndex = -1;
        }

        private void modifyButton_Click(object? sender, EventArgs e)
        {
            int idx = selectedRowIndex >= 0 ? selectedRowIndex : GetSelectedRowIndex();
            if (idx < 0 || idx >= attendanceGrid.Rows.Count)
            {
                MessageBox.Show("Select a row to modify.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedRowIndex = -1;
                return;
            }

            var idCell = attendanceGrid.Rows[idx].Cells["userIDColumn"].Value;
            string id = idCell?.ToString() ?? string.Empty;

            var stored = storedUsers.FirstOrDefault(s => s.UserID == id);
            if (stored == null)
            {
                MessageBox.Show("Selected user not found in stored list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedRowIndex = -1;
                return;
            }

            if (!PromptForAttendance(stored, out StoredAttendance? updated))
            {
                selectedRowIndex = -1;
                return;
            }

            // Update stored item
            stored.UserID = updated.UserID;
            stored.Username = updated.Username;
            stored.Email = updated.Email;
            stored.ClockInDate = updated.ClockInDate;
            stored.ClockOutDate = updated.ClockOutDate;

            // Update grid row cells
            var row = attendanceGrid.Rows[idx];
            row.Cells["userIDColumn"].Value = stored.UserID;
            row.Cells["userNameColumn"].Value = stored.Username;
            row.Cells["emailAccontColumn"].Value = stored.Email;
            row.Cells["indateColumn"].Value = stored.ClockInDate;
            row.Cells["outdateColumn"].Value = stored.ClockOutDate;

            selectedRowIndex = -1;
        }

        private void addButton_Click(object? sender, EventArgs e)
        {

            if (!PromptForAttendance(null, out StoredAttendance? created))
                return;

            storedUsers.Add(created);
            attendanceGrid.Rows.Add(created.UserID, created.Username, created.Email, created.ClockInDate, created.ClockOutDate);
        }

        // Simple prompt that uses InputBox for five fields. Returns false if user cancels/enters nothing for ID.
        private bool PromptForAttendance(StoredAttendance? existing, out StoredAttendance? result)
        {
            result = null;

            string defaultId = existing?.UserID ?? "";
            string defaultUser = existing?.Username ?? "";
            string defaultEmail = existing?.Email ?? "";
            string defaultIn = existing?.ClockInDate ?? "";
            string defaultOut = existing?.ClockOutDate ?? "";

            // Using Microsoft.VisualBasic.Interaction.InputBox for quick prompts
            string id = Interaction.InputBox("User ID:", existing == null ? "Add new attendance" : "Modify attendance", defaultId);
            if (string.IsNullOrWhiteSpace(id))
                return false;

            string username = Interaction.InputBox("Username:", "Add / Modify", defaultUser);
            if (string.IsNullOrWhiteSpace(username))
                username = defaultUser;

            string email = Interaction.InputBox("Email:", "Add / Modify", defaultEmail);
            if (string.IsNullOrWhiteSpace(email))
                email = defaultEmail;

            string clockIn = Interaction.InputBox("Clock In (string):", "Add / Modify", defaultIn);
            if (string.IsNullOrWhiteSpace(clockIn))
                clockIn = defaultIn;

            string clockOut = Interaction.InputBox("Clock Out (string):", "Add / Modify", defaultOut);
            if (string.IsNullOrWhiteSpace(clockOut))
                clockOut = defaultOut;

            result = new StoredAttendance(id, username, email, clockIn, clockOut);
            return true;
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
