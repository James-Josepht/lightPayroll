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


namespace lighPayroll
{
    public partial class AttendanceRecords : Form
    {
        List<Model> users = new List<Model>();


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

        private void loadButton_Click(object sender, EventArgs e)
        {

            users = SQLiteDataAccess.LoadPeople(); //from lightPayrollServices

        }


        private void userRMbutton_Click(object? sender, EventArgs e)
        {

        }

        private void modifyButton_Click(object? sender, EventArgs e)
        {



        }

        private void addButton_Click(object? sender, EventArgs e)
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

        private void attendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

 
}
