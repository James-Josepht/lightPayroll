using lighPayrollUI;
using lighPayrollUI.Properties;
using lightPayrollModel;
using lightPayrollServices;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace lighPayroll
{
    public partial class AdminDashboard : Form
    {
        List<Users> attendance = new List<Users>();

        private string user_role, user_name;
        private int user_id;
        public AdminDashboard(string role, string username, int id)
        {
            InitializeComponent();

            user_role = role;
            user_name = username;
            user_id = id;
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadUserPieChart();
            ApplyRole(user_role);
        }

        private void LoadUserCount()
        {
            int count = SQLiteDataAccess.GetUserCount();
            labelUserCount.Text = count.ToString();
        }

        private void LoadUserPieChart()
        {
            int adminCount = SQLiteDataAccess.GetUserCountByRole("Admin");
            int managerCount = SQLiteDataAccess.GetUserCountByRole("Manager");
            int accountantCount = SQLiteDataAccess.GetUserCountByRole("Accountant");
            int employeeCount = SQLiteDataAccess.GetUserCountByRole("Employee");

            usersChart.Series = new ISeries[]
            {
                new PieSeries<int>
                {
                    Values = new[] { adminCount },
                    Name = "Admin",
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point => $"{point.StackedValue} ({point.StackedValue.Share:P})"

                },
                new PieSeries<int>
                {
                    Values = new[] { accountantCount },
                    Name = "Accountant",
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point => $"{point.StackedValue} ({point.StackedValue.Share:P})"

                },
                new PieSeries<int>
                {
                    Values = new[] { managerCount },
                    Name = "Manager",
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point => $"{point.StackedValue} ({point.StackedValue.Share:P})"

                },
                new PieSeries<int>
                {
                    Values = new[] { employeeCount },
                    Name = "Employee",
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point => $"{point.StackedValue} ({point.StackedValue.Share:P})"
                }
            };
        }


        private void usersB_Click(object sender, EventArgs e)
        {

        }

        private void taskB_Click(object sender, EventArgs e)
        {

        }

        private void attendanceB_Click(object sender, EventArgs e)
        {

        }

        private void ApplyRole(string role)
        {

            if (role == "Admin")
            {
                taskB.Visible = true;
                taskB.Enabled = true;
                attendanceB.Visible = true;
                attendanceB.Enabled = true;
                usersB.Visible = true;
                usersB.Enabled = true;

            }
            else if (role == "Manager")
            {
                taskB.Visible = true;
                taskB.Enabled = true;
                attendanceB.Visible = true;
                attendanceB.Enabled = true;
                attendanceB.Location = new Point(14, 152);
            }
            else if (role == "Employee")
            {
                taskB.Visible = true;
                taskB.Enabled = true;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (user_role != "Admin")
            {
                EmployeeUI home = new EmployeeUI(user_role, user_name, user_id);
                home.Show();
            }
            else
            {
                AdminUI home = new AdminUI();
                home.Show();

            }
            
            this.Hide();
        }
    }


}
