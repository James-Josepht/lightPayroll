using lighPayrollUI;
using lighPayrollUI.Properties;
using lightPayrollModel;
using lightPayrollServices;
using LiveChartsCore;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.VisualBasic;
using SkiaSharp;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace lighPayroll
{
    public partial class AdDashboard : Form
    {
        AdUI customMessages = new AdUI();
        List<Users> attendance = new List<Users>();
        AttendanceService attendanceService = new AttendanceService();
        SQLiteDataAccess dataAccess = new SQLiteDataAccess();
        HBorderRadius borderRadius = new HBorderRadius();

        private string user_role, user_name;
        private int user_id;
        private int currentYear, minYear, maxYear;


        public AdDashboard(string role, string username, int id)
        {
            InitializeComponent();

            user_role = role;
            user_name = username;
            user_id = id;
        }



        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            ApplyRole(user_role);
           
        }

        private int LoadUserCount()
        {
            int count = dataAccess.GetUserCount();
            int approvedCount =
                dataAccess.GetUserCountByRole("Admin") +
                dataAccess.GetUserCountByRole("Manager") +
                dataAccess.GetUserCountByRole("Accountant") +
                dataAccess.GetUserCountByRole("Employee");


            int pendingCount = count - approvedCount;

            totalUsersLbl.Text = $"Total Count: {count.ToString()}";
            approvedCountLbl.Text = $"Approved Count: {approvedCount.ToString()}";
            pendingUsersLbl.Text = $"Pending Count: {pendingCount.ToString()}";

            approvedCountLbl.Visible = true;

            pendingUsersLbl.Visible = true;

            return count;
        }

        private void LoadRegisteredCount() //line chart
        {

            var data = attendanceService.GetRegistrationsPerMonth(currentYear);
            yearLbl.Text = currentYear.ToString();
            //Your method returns:

            // IEnumerable<(int Month, int Total)>

            //  So I need:

            //X axis → months
            //Y axis → totals

            double[] values = new double[12];

            foreach (var item in data)
            {
                values[item.Month - 1] = item.Total;
            }


            leftCartesianChart.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = values
                }
            };

            leftCartesianChart.YAxes = new[]
           {
                new Axis
                {
                    Name = "Registered Users",

                     LabelsPaint = new SolidColorPaint(SKColors.Beige),

                    NamePaint = new SolidColorPaint(SKColors.DarkGray)
                }

            };

            leftCartesianChart.XAxes = new[]
            {
                new Axis
                {
                    Labels = new[]
                    {
                        "Jan","Feb","Mar","Apr","May","Jun",
                        "Jul","Aug","Sep","Oct","Nov","Dec"
                    },

                    LabelsPaint = new SolidColorPaint(SKColors.Beige),
                    TextSize = 10,
                    NamePaint = new SolidColorPaint(SKColors.DarkGray)
                }
            };
        }

        private int LoadAttendanceCount()
        {
            int count = attendanceService.GetAttendanceCountToday();
            dataLbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            totalUsersLbl.Text = $"Attendance Count: {count.ToString()}";

            return count;
        }



        /// 
        /// STARTING IN HERE IT SHOWS WHEN A USER CLICKS ON LEFT BUTTONS
        /// 
        ///  IT WILL SHOW DIFFERENT CHART
        /// 

        private void taskB_Click(object sender, EventArgs e)
        {
            //right focus
            LoadUserPieChart("task");
            rightPieChart.Visible = false;
            yearRangePanel.Visible = false;
            totalUsersLbl.Visible = false;
            countPanel.Visible = false;
            noDataLabel.Visible = false;
            dataLbl.Visible = false;
            yearLbl.Visible = false;


            //left focus
            leftCartesianChart.Visible = false;
            cartesianPlane.Visible = false;
            modifyYearPanel.Visible = false;

        }

        private void usersB_Click(object sender, EventArgs e)
        {
            //right chart focus
            rightPieChart.Visible = true;
            totalUsersLbl.Visible = true;
            countPanel.Visible = true;
            yearLbl.Visible = true;

            //left chart focus
            leftCartesianChart.Visible = true;
            cartesianPlane.Visible = true;
            modifyYearPanel.Visible = true;
          

            var range = dataAccess.GetRegistrationYearRange();
            minYear = range.MinYear;
            maxYear = range.MaxYear;

            //after getting year range
            dataLbl.Text = $"{minYear} - {maxYear}";
            dataLbl.Visible = true;
            yearRangePanel.Visible = true;



            currentYear = maxYear; // start at latest year

            int count = LoadUserCount();

            if (count == 0)
            {
                LoadUserPieChart("empty");
                noDataLabel.Visible = true;
                return;
            }
            else
            {
                LoadUserPieChart("user");
                LoadRegisteredCount();
                noDataLabel.Visible = false;
            }


        }

        private void attendanceB_Click(object sender, EventArgs e)
        {
            //focus on right chart
            rightPieChart.Visible = true;
            yearRangePanel.Visible = true;
            totalUsersLbl.Visible = true;
            totalUsersLbl.Text = "Attendance Count: ";
            countPanel.Visible = true;

            //focus on left chart
            leftCartesianChart.Visible = true;
            cartesianPlane.Visible = true;
            modifyYearPanel.Visible = true;




            int count = LoadAttendanceCount();
            //only load and modify the count text after clicking the button

            if (count == 0)
            {
                LoadUserPieChart("empty");
                noDataLabel.Visible = true;
                noDataLabel.Enabled = true;
                return;
            }
            else
            {
                LoadUserPieChart("attendance");
                noDataLabel.Visible = false;
                noDataLabel.Enabled = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (currentYear > minYear)
            {
                currentYear--;
                LoadRegisteredCount();
            }
            else
            {
                customMessages.CustomMessageBox("No previous year available.");
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentYear < maxYear)
            {
                currentYear++;
                LoadRegisteredCount();
            }
            else
            {
                customMessages.CustomMessageBox("You are already at the latest year.");
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (user_role != "Admin")
            {
                EUI home = new EUI(user_role, user_name, user_id);
                home.Show();
            }
            else
            {
                AdUI home = new AdUI();
                home.Show();

            }

            this.Hide();
        }


        //this is the pie that would appear on the right side of the dashboard
        private void LoadUserPieChart(string button)
        {
            if (button == "user")
            {
                int adminCount = dataAccess.GetUserCountByRole("Admin");
                int managerCount = dataAccess.GetUserCountByRole("Manager");
                int accountantCount = dataAccess.GetUserCountByRole("Accountant");
                int employeeCount = dataAccess.GetUserCountByRole("Employee");

                rightPieChart.Series = new ISeries[]
                {
                    new PieSeries<int>
                    {
                        //this is without text inside
                        //Values = new[] { adminCount },
                        //Name = "Admin",
                        //DataLabelsSize = 14,
                        //DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        //DataLabelsFormatter = point => $"{point.Coordinate.PrimaryValue} ({point.StackedValue.Share:P})"


                        Values = new[] { adminCount },
                        Name = "Admin",
                        DataLabelsSize = 11,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsPaint = new SolidColorPaint(SKColors.Beige), // label color
                        //Fill = new SolidColorPaint(SKColors.Cyan), // pie color
                        DataLabelsFormatter = point => $"Admin \n{point.Coordinate.PrimaryValue} ({point.StackedValue.Share:P0})"
                    },
                    new PieSeries<int>
                    {
                         Values = new[] { accountantCount },
                        Name = "Accountant",
                        DataLabelsSize = 11,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsPaint = new SolidColorPaint(SKColors.Beige), // label color
                        DataLabelsFormatter = point => $"Accountant \n{point.Coordinate.PrimaryValue} ({point.StackedValue.Share:P0})"



                    },
                    new PieSeries<int>
                    {
                         Values = new[] { managerCount },
                        Name = "Manager",
                        DataLabelsSize = 11,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsPaint = new SolidColorPaint(SKColors.Beige), // label color
                        DataLabelsFormatter = point => $"Manager \n{point.Coordinate.PrimaryValue} ({point.StackedValue.Share:P0})"
                    },
                    new PieSeries<int>
                    {
                        Values = new[] { employeeCount },
                        Name = "Employee",
                        DataLabelsSize = 11,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsPaint = new SolidColorPaint(SKColors.Beige), //label color
                        Fill = new SolidColorPaint(SKColors.Orange), // pie color
                        DataLabelsFormatter = point => $"Employee \n{point.Coordinate.PrimaryValue} ({point.StackedValue.Share:P0})"
                    }
                };
            }
            else if (button == "leave")
            {

            }
            else if (button == "attendance")
            {
                int present = attendanceService.GetAttendanceCountByStatus("Present");
                int late = attendanceService.GetAttendanceCountByStatus("Late");
                int onLeave = attendanceService.GetAttendanceCountByStatus("Leave");

                rightPieChart.Series = new ISeries[]
                {
                    new PieSeries<int> { Values = new[] { present }, Name = "Present",
                        Fill = new SolidColorPaint(new SKColor(102, 187, 106)), // pie color
                        DataLabelsSize = 11,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = p => $"Present ({p.Model})" },

                    new PieSeries<int> { Values = new[] { late }, Name = "Late",
                        Fill = new SolidColorPaint(SKColors.Orange), // pie color
                        DataLabelsSize = 11,
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = p => $"Late ({p.Model})" },

                    new PieSeries<int> { Values = new[] { onLeave }, Name = "Leave",
                        Fill = new SolidColorPaint(SKColors.IndianRed), // pie color
                         DataLabelsSize = 11, // slightly bigger
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = p => $"Leave ({p.Model})" }
                };
            }
            else //if there is no count
            {
                rightPieChart.Series = Array.Empty<ISeries>();

                rightPieChart.Series = new ISeries[]
                {
                    new PieSeries<double>
                    {
                        Values = new double[] { 1 }, // must be greater than 0 man daw
                        Fill = new SolidColorPaint(SKColors.Gray),
                        InnerRadius = 70, // create a hole in pie for me to put a label
                        IsHoverable = false
                    }
                };

            }

        }


        ///
        /// Dashboard based on role
        ///
        ///

        private void ApplyRole(string role)
        {

            if (role == "Admin")
            {
                payrollBtn.Visible = true;
                payrollBtn.Enabled = true;
                attendanceB.Visible = true;
                attendanceB.Enabled = true;
                usersB.Visible = true;
                usersB.Enabled = true;

            }
            else if (role == "Manager" || role == "Accountant")
            {
                payrollBtn.Visible = true;
                payrollBtn.Enabled = true;
                attendanceB.Visible = true;
                attendanceB.Enabled = true;
                attendanceB.Location = new Point(14, 168);
                attendanceDashboard.Visible = true;
                attendanceDashboard.Enabled = true;
                attendanceDashboard.Location = new Point(16, 228);

                usersDashboard.Visible = false;
                usersDashboard.Enabled = false;



            }
            else if (role == "Employee")
            {
                payrollBtn.Visible = true;
                payrollBtn.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
