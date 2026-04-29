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
using lighPayrollUI.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using lightPayrollModel;
using lightPayrollServices;
using System.Security.AccessControl;


namespace lighPayroll
{
    public partial class AdAttendance : Form
    {
        SQLiteDataAccess dataAccess = new SQLiteDataAccess();
        AttendanceService attendanceDataAccess = new AttendanceService();
        List <AttendanceAdmin> users = new List<AttendanceAdmin>();


        public AdAttendance()
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

        private void LoadAttendanceList()
        {
            //from lightPayrollServices

            users = attendanceDataAccess.LoadAttendanceAdmin(); 
            WireUpAttendanceList();
        }

        private void WireUpAttendanceList()
        {
            attendanceGrid.DataSource = null;
            attendanceGrid.DataSource = users;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadAttendanceList();

        }

        private void addButton_Click(object? sender, EventArgs e)
        {
            AdminUser user = new AdminUser //create an instance from admin, since only admin can add or modify users
            {
                Username = nameTxtBox.Text,
                Password = fNameTxtBox.Text,
            };

            dataAccess.InsertUser(user);
            nameTxtBox.Text = "";
            fNameTxtBox.Text = "";
        }

        private void userRMbutton_Click(object? sender, EventArgs e)
        {

        }

        private void modifyButton_Click(object? sender, EventArgs e)
        {



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


        private void searchMS_Click(object sender, EventArgs e)
        {

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminHome_Click(object sender, EventArgs e)
        {
            AdUI home = new AdUI();
            home.Show();
            this.Hide();
        }
    }


}
