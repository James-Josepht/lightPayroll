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
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lighPayroll
{
    public partial class AttendanceRecords : Form
    {
        OleDbConnection? dataConnection;
        OleDbDataAdapter? dataAdapter;
        OleDbCommand? dataCommand;
        DataSet? dataSet;

        int index = 0;





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

            //attendanceGrid.AutoGenerateColumns = false;
            panelDesign();
            dropDownDesign();
        }



        private void userRMbutton_Click(object? sender, EventArgs e)
        {

        }

        private void modifyButton_Click(object? sender, EventArgs e)
        {



        }

        private void addButton_Click(object? sender, EventArgs e)
        {
            string query = @"INSERT into tblHRData (EmployeeID)";
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

        //future usage for rounded panel borders and it is not related to drop down
        private void panelDesign()
        {
            int radius = 30;

            GraphicsPath greetingsPath = new GraphicsPath();
            greetingsPath.AddArc(0, 0, radius, radius, 180, 90);
            greetingsPath.AddArc(loadButton.Width - radius, 0, radius, radius, 270, 90);
            greetingsPath.AddArc(loadButton.Width - radius, loadButton.Height - radius, radius, radius, 0, 90);
            greetingsPath.AddArc(0, loadButton.Height - radius, radius, radius, 90, 90);
            greetingsPath.CloseAllFigures();

            GraphicsPath bodyPath = new GraphicsPath();
            bodyPath.AddArc(0, 0, radius, radius, 180, 90);
            bodyPath.AddArc(loadButton.Width - radius, 0, radius, radius, 270, 90);
            bodyPath.AddArc(loadButton.Width - radius, loadButton.Height - radius, radius, radius, 0, 90); //lower right
            bodyPath.AddArc(0, loadButton.Height - radius, radius, radius, 90, 90);
            bodyPath.CloseAllFigures();

            loadButton.Region = new Region(greetingsPath);
            loadButton.Region = new Region(bodyPath);

        }

        private void dropDownDesign()
        {

            var dd = searchMS.DropDown as ToolStripDropDownMenu; //removing empty whitespace

            if (dd != null)
            {
                dd.ShowImageMargin = false;
                dd.ShowCheckMargin = false;
                dd.Padding = Padding.Empty;
            }

        }


        private void loadButton_Click(object sender, EventArgs e)
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\James\Documents\Learning\Trial Database\CompanyADatabase.accdb";

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();

                // Check if table exists
                DataTable schemaTable = connection.GetSchema("Tables");
                bool tableExists = false;

                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    string tableType = row["TABLE_TYPE"].ToString();

                    if ((tableType == "TABLE" || tableType == "VIEW") && tableName == "salariesQuery")
                    {
                        tableExists = true;
                        break;
                    }
                }

                if (tableExists)
                {
                    dataAdapter = new OleDbDataAdapter("SELECT * FROM salariesQuery", connString );
                    dataSet = new DataSet();

                    dataAdapter.Fill(dataSet, "salariesQuery");
                    attendanceGrid.DataSource = dataSet.Tables["salariesQuery"];

                }
                else
                {
                    MessageBox.Show("Error. Table NOT found!");
                }
            }

        }

        private void searchMS_Click(object sender, EventArgs e)
        {

        }

        private void attendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
