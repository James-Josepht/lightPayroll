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
        AdUI customMessages;
        AttendanceService attendanceService = new AttendanceService();
        GeneralDataService dataAccess = new GeneralDataService();
        RequestsService requestsService = new RequestsService();
        HBorderRadius borderRadius = new HBorderRadius();

        private const string FEATURE_USER = "user";
        private const string FEATURE_ATTENDANCE = "attendance";
        private const string FEATURE_REQUESTS = "requests";

        private string user_role, user_name, button_features;
        private int user_id, currentYear, minYear, maxYear;


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
            LoadUserPieChart(FEATURE_USER);
            LoadUserFeature();
           
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

            firstCountLbl.Text = $"Total Count: {count.ToString()}";
            secondCountLbl.Text = $"Approved Count: {approvedCount.ToString()}";
            thirdCountLbl.Text = $"Pending Count: {pendingCount.ToString()}";

            secondCountLbl.Visible = true;

            thirdCountLbl.Visible = true;

            return count;
        }

        private void LoadRegisteredChartCount() //line chart
        {

            var data = dataAccess.GetRegistrationsPerMonth(currentYear);
            yearLbl.Text = currentYear.ToString();


            // data returns: IEnumerable<(int Month, int Total)>
            //  So I need:
            //X axis → months
            //Y axis → totals

            XYAxis("Registered Users", data);
        }

        private void LoadRequestsChartCount() //line chart
        {

            var data = requestsService.GetRequestsPerMonth(currentYear);
            yearLbl.Text = currentYear.ToString();

            if (!data.Any())
            {
                leftCartesianChart.Series = Array.Empty<ISeries>();
                noDataLabel.Text = "No data found.";
                noDataLabel.Visible = true;
                return;
            }
            noDataLabel.Visible = false;
            XYAxis("Requests", data);
        }

        private int LoadRequestsCount()
        {
            int pending = requestsService.GetRequestCountByStatus("Pending");
            int approved = requestsService.GetRequestCountByStatus("Approved");
            int rejected = requestsService.GetRequestCountByStatus("Rejected");

            yearLbl.Text = currentYear.ToString();

            yearRangeLbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            firstCountLbl.Text = $"Pending: {pending.ToString()}";
            secondCountLbl.Text = $"Approved: {approved.ToString()}";
            thirdCountLbl.Text = $"Rejected: {rejected.ToString()}";

            int count = pending + approved + rejected;
            return count;
        }

        private int LoadAttendanceCount()
        {
            var (present, late, leave) = attendanceService.GetAttendanceCountToday();
            yearLbl.Text = currentYear.ToString();

            yearRangeLbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            firstCountLbl.Text = $"Present: {present.ToString()}";
            secondCountLbl.Text = $"Late: {late.ToString()}";
            thirdCountLbl.Text = $"Leave: {leave.ToString()}";

            var data = attendanceService.GetMonthlyAttendanceBreakdown(currentYear);
            LoadAttendanceTrendChart(data);

            int count = present + late + leave;
            return count;
        }

       



        private void LoadRequestsFeature()
        {
            button_features = FEATURE_REQUESTS;
            //right chart focus
            rightPieChart.Visible = true;
            firstCountLbl.Visible = true;
            countPanel.Visible = true;
            yearLbl.Visible = true;

            //left chart focus
            leftCartesianChart.Visible = true;
            cartesianPlane.Visible = true;
            modifyYearPanel.Visible = true;


            var range = requestsService.GetRequestYearRange();
            minYear = range.MinYear;
            maxYear = range.MaxYear;

            //after getting year range
            yearRangeLbl.Text = $"{minYear} - {maxYear}";
            yearRangeLbl.Visible = true;
            yearRangePanel.Visible = true;



            currentYear = maxYear; // start at latest year

            int count = LoadRequestsCount();

            if (count == 0)
            {
                LoadUserPieChart("empty");
                noDataLabel.Visible = true;
                return;
            }
            else
            {
                LoadUserPieChart(FEATURE_REQUESTS);
                LoadRequestsChartCount();
                noDataLabel.Visible = false;
            }

        }

        private void LoadUserFeature()
        {
            button_features = FEATURE_USER;
            //right chart focus
            rightPieChart.Visible = true;
            firstCountLbl.Visible = true;
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
            yearRangeLbl.Text = $"{minYear} - {maxYear}";
            yearRangeLbl.Visible = true;
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
                LoadUserPieChart(FEATURE_USER);
                LoadRegisteredChartCount();
                noDataLabel.Visible = false;
            }

        }
        private void LoadAttendanceFeature()
        {
            button_features = FEATURE_ATTENDANCE;

            //focus on right chart
            rightPieChart.Visible = true;
            yearRangePanel.Visible = true;
            firstCountLbl.Visible = true;
            firstCountLbl.Text = "Present Count: ";
            secondCountLbl.Text = "Leave Count: ";
            thirdCountLbl.Text = "Late Count: ";
            countPanel.Visible = true;

            //focus on left chart
            leftCartesianChart.Visible = true;
            cartesianPlane.Visible = true;
            modifyYearPanel.Visible = true;


            var range = attendanceService.GetAttendanceYearRange();
            minYear = range.MinYear;
            maxYear = range.MaxYear;

            currentYear = maxYear; // start at latest year

            yearLbl.Text = currentYear.ToString();

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
                LoadUserPieChart(FEATURE_ATTENDANCE);
                noDataLabel.Visible = false;
                noDataLabel.Enabled = false;
            }

        }



        /// 
        /// STARTING IN HERE IT SHOWS WHEN A USER CLICKS ON LEFT BUTTONS
        /// 
        ///  IT WILL SHOW DIFFERENT CHART
        /// 

        private void leaveB_Click(object sender, EventArgs e)
        {
            LoadRequestsFeature();

        }

        private void usersB_Click(object sender, EventArgs e)
        {

            LoadUserFeature();
        }

        private void attendanceB_Click(object sender, EventArgs e)
        {
            LoadAttendanceFeature();   
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (currentYear > minYear)
            {
                currentYear--;
                ApplyYearChange();
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

                ApplyYearChange();

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
                AdUI home = new AdUI(user_id);
                home.Show();

            }

            this.Hide();
        }


        //this is the pie that would appear on the right side of the dashboard
        private void LoadUserPieChart(string button)
        {
            if (button == FEATURE_USER)
            {
                int adminCount = dataAccess.GetUserCountByRole("Admin");
                int managerCount = dataAccess.GetUserCountByRole("Manager");
                int accountantCount = dataAccess.GetUserCountByRole("Accountant");
                int employeeCount = dataAccess.GetUserCountByRole("Employee");

                rightPieChart.Series = new ISeries[]
                {
                    new PieSeries<int>
                    {
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

                rightPieChart.Update();
            }
            else if (button == FEATURE_REQUESTS)
            {

                int pending = requestsService.GetRequestCountByStatus("Pending");
                int approved = requestsService.GetRequestCountByStatus("Approved");
                int rejected = requestsService.GetRequestCountByStatus("Rejected");

                rightPieChart.Series = new ISeries[]
                {
                    new PieSeries<int> { Values = new[] { pending }, Name = "Pending" },
                    new PieSeries<int> { Values = new[] { approved }, Name = "Approved" },
                    new PieSeries<int> { Values = new[] { rejected }, Name = "Rejected" }
                };

            }
            else if (button == FEATURE_ATTENDANCE)
            {
                var (present, late, leave) = attendanceService.GetAttendanceCountToday();

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

                    new PieSeries<int> { Values = new[] { leave }, Name = "Leave",
                        Fill = new SolidColorPaint(SKColors.IndianRed), // pie color
                         DataLabelsSize = 11, // slightly bigger
                        DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                        DataLabelsFormatter = p => $"Leave ({p.Model})" }
                };

                rightPieChart.Update();
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

                rightPieChart.Update();

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
                attendanceB.Visible = true;
                attendanceB.Enabled = true;
                usersB.Visible = true;
                usersB.Enabled = true;

            }
            else if (role == "Manager" || role == "Accountant")
            {
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
              
            }
        }

        private void ApplyYearChange()
        {
            yearLbl.Text = currentYear.ToString();

            if (button_features == FEATURE_USER)
            {
                LoadUserCount();    
                LoadUserPieChart(FEATURE_USER);
                LoadRegisteredChartCount();
            }
            else if (button_features == FEATURE_ATTENDANCE)
            {
                LoadAttendanceCount();
            }
            else if (button_features == FEATURE_REQUESTS)
            {
                LoadRequestsCount();
                LoadUserPieChart(FEATURE_REQUESTS);
                LoadRequestsChartCount();
                
            }
        }


        private void XYAxis(string buttonFeature, IEnumerable<(int Month, int Total)> data)
        {
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
                    Name = buttonFeature,

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

        private void LoadAttendanceTrendChart(IEnumerable<(int Month, int Present, int Late, int Leave)> data)
        {
                double[] present = new double[12];
                double[] late = new double[12];
                double[] leave = new double[12];

                foreach (var item in data)
                {
                    int index = item.Month - 1;

                    present[index] = item.Present;
                    late[index] = item.Late;
                    leave[index] = item.Leave;
                }

                leftCartesianChart.Series = new ISeries[]
                {
                    new LineSeries<double>
                    {
                        Name = "Present",
                        Values = present
                    },
                    new LineSeries<double>
                    {
                        Name = "Late",
                        Values = late
                    },
                    new LineSeries<double>
                    {
                        Name = "Leave",
                        Values = leave
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

            leftCartesianChart.YAxes = new[]
            {
                new Axis
                {
                    Name = "Attendance Count",
                    LabelsPaint = new SolidColorPaint(SKColors.Beige),

                    NamePaint = new SolidColorPaint(SKColors.DarkGray)
                }
            };
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
