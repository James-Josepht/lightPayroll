using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lighPayroll;
using lightPayrollModel;
using lightPayrollServices;

namespace lighPayrollUI
{
    public partial class UserModification : Form
    {
        LogIn greetings = new LogIn();
        List<Users> users = new List<Users>();

        public UserModification()
        {
            InitializeComponent();
        }
        private void UsersUI_Load(object sender, EventArgs e)
        {
            greetings.TypeText(label2, "Trust But Always Verify!");
        }

        private void LoadUserList()
        {
            users = SQLiteDataAccess.LoadUsers();
            WireUpUserList();
        }
        private void WireUpUserList()
        {

            attendanceGrid.DataSource = null;
            attendanceGrid.DataSource = users;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }

    }
}
