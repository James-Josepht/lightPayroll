using lighPayrollUI.Properties;

namespace lighPayroll
{
    partial class AdDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend10 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdDashboard));
            LiveChartsCore.Drawing.Padding padding19 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip10 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding20 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend11 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding21 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip11 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding22 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend12 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding23 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip12 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding24 = new LiveChartsCore.Drawing.Padding();
            delORmod = new ContextMenuStrip(components);
            panel4 = new Panel();
            headPanel = new Panel();
            homeButton = new PictureBox();
            bodyPanel = new Panel();
            panel3 = new Panel();
            attendanceDashboard = new Label();
            usersDashboard = new Label();
            Dashboard = new Label();
            attendanceB = new Button();
            usersB = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            yearRangePanel = new Panel();
            dataLbl = new Label();
            modifyYearPanel = new Panel();
            yearLbl = new Label();
            nextButton = new Button();
            backButton = new Button();
            cartesianPlane = new Panel();
            leftCartesianChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel5 = new Panel();
            noDataLabel = new Label();
            rightPieChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            labelTaskCount = new Label();
            profileChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            countPanel = new Panel();
            pendingUsersLbl = new Label();
            approvedCountLbl = new Label();
            totalUsersLbl = new Label();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeButton).BeginInit();
            bodyPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            yearRangePanel.SuspendLayout();
            modifyYearPanel.SuspendLayout();
            cartesianPlane.SuspendLayout();
            panel5.SuspendLayout();
            countPanel.SuspendLayout();
            SuspendLayout();
            // 
            // delORmod
            // 
            delORmod.ImageScalingSize = new Size(20, 20);
            delORmod.Name = "delORmod";
            delORmod.Size = new Size(61, 4);
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(73, 567);
            panel4.Name = "panel4";
            panel4.Size = new Size(783, 33);
            panel4.TabIndex = 7;
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(homeButton);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(937, 101);
            headPanel.TabIndex = 6;
            // 
            // homeButton
            // 
            homeButton.Cursor = Cursors.Hand;
            homeButton.Image = Resources.smart_idea;
            homeButton.Location = new Point(10, -7);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(203, 123);
            homeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            homeButton.TabIndex = 5;
            homeButton.TabStop = false;
            homeButton.Click += homeButton_Click;
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = SystemColors.ActiveCaption;
            bodyPanel.Controls.Add(panel3);
            bodyPanel.Dock = DockStyle.Left;
            bodyPanel.Location = new Point(0, 101);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(200, 447);
            bodyPanel.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 35, 55);
            panel3.Controls.Add(attendanceDashboard);
            panel3.Controls.Add(usersDashboard);
            panel3.Controls.Add(Dashboard);
            panel3.Controls.Add(attendanceB);
            panel3.Controls.Add(usersB);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 426);
            panel3.TabIndex = 0;
            // 
            // attendanceDashboard
            // 
            attendanceDashboard.AutoSize = true;
            attendanceDashboard.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceDashboard.ForeColor = Color.Beige;
            attendanceDashboard.Location = new Point(16, 228);
            attendanceDashboard.Name = "attendanceDashboard";
            attendanceDashboard.Size = new Size(77, 16);
            attendanceDashboard.TabIndex = 9;
            attendanceDashboard.Text = "Attendance";
            // 
            // usersDashboard
            // 
            usersDashboard.AutoSize = true;
            usersDashboard.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersDashboard.ForeColor = Color.Beige;
            usersDashboard.Location = new Point(14, 135);
            usersDashboard.Name = "usersDashboard";
            usersDashboard.Size = new Size(42, 16);
            usersDashboard.TabIndex = 8;
            usersDashboard.Text = "Users";
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Ubuntu Mono", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.Beige;
            Dashboard.Location = new Point(14, 21);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(120, 26);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            // 
            // attendanceB
            // 
            attendanceB.BackColor = Color.FromArgb(25, 35, 55);
            attendanceB.BackgroundImage = Resources.attendance;
            attendanceB.BackgroundImageLayout = ImageLayout.Zoom;
            attendanceB.FlatAppearance.BorderColor = Color.Beige;
            attendanceB.FlatAppearance.MouseDownBackColor = Color.Beige;
            attendanceB.FlatStyle = FlatStyle.Flat;
            attendanceB.Location = new Point(16, 168);
            attendanceB.Name = "attendanceB";
            attendanceB.Size = new Size(172, 57);
            attendanceB.TabIndex = 2;
            attendanceB.UseVisualStyleBackColor = false;
            attendanceB.Visible = false;
            attendanceB.Click += attendanceB_Click;
            // 
            // usersB
            // 
            usersB.BackColor = Color.FromArgb(25, 35, 55);
            usersB.BackgroundImage = Resources.users1;
            usersB.BackgroundImageLayout = ImageLayout.Zoom;
            usersB.FlatAppearance.BorderColor = Color.Beige;
            usersB.FlatAppearance.MouseDownBackColor = Color.Beige;
            usersB.FlatStyle = FlatStyle.Flat;
            usersB.ForeColor = SystemColors.Control;
            usersB.Location = new Point(14, 75);
            usersB.Name = "usersB";
            usersB.Size = new Size(172, 57);
            usersB.TabIndex = 1;
            usersB.UseVisualStyleBackColor = false;
            usersB.Visible = false;
            usersB.Click += usersB_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 447);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 44, 66);
            panel2.Controls.Add(yearRangePanel);
            panel2.Controls.Add(modifyYearPanel);
            panel2.Controls.Add(cartesianPlane);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(labelTaskCount);
            panel2.Controls.Add(profileChart);
            panel2.Controls.Add(countPanel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 426);
            panel2.TabIndex = 0;
            // 
            // yearRangePanel
            // 
            yearRangePanel.BorderStyle = BorderStyle.FixedSingle;
            yearRangePanel.Controls.Add(dataLbl);
            yearRangePanel.Location = new Point(425, 21);
            yearRangePanel.Name = "yearRangePanel";
            yearRangePanel.Size = new Size(290, 26);
            yearRangePanel.TabIndex = 7;
            yearRangePanel.Visible = false;
            // 
            // dataLbl
            // 
            dataLbl.AutoSize = true;
            dataLbl.Font = new Font("Ubuntu Mono", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataLbl.ForeColor = Color.Beige;
            dataLbl.Location = new Point(97, 3);
            dataLbl.Name = "dataLbl";
            dataLbl.Size = new Size(96, 18);
            dataLbl.TabIndex = 9;
            dataLbl.Text = "2000 - 2000";
            dataLbl.Visible = false;
            dataLbl.Click += label1_Click;
            // 
            // modifyYearPanel
            // 
            modifyYearPanel.Controls.Add(yearLbl);
            modifyYearPanel.Controls.Add(nextButton);
            modifyYearPanel.Controls.Add(backButton);
            modifyYearPanel.Location = new Point(6, 312);
            modifyYearPanel.Name = "modifyYearPanel";
            modifyYearPanel.Size = new Size(394, 74);
            modifyYearPanel.TabIndex = 11;
            modifyYearPanel.Visible = false;
            // 
            // yearLbl
            // 
            yearLbl.AutoSize = true;
            yearLbl.Font = new Font("Ubuntu Mono Medium", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearLbl.ForeColor = Color.Beige;
            yearLbl.Location = new Point(90, 24);
            yearLbl.Name = "yearLbl";
            yearLbl.Size = new Size(40, 18);
            yearLbl.TabIndex = 12;
            yearLbl.Text = "2000";
            // 
            // nextButton
            // 
            nextButton.BackgroundImage = Resources.next;
            nextButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderColor = Color.FromArgb(33, 44, 66);
            nextButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 44, 66);
            nextButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 44, 66);
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Location = new Point(153, 16);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(41, 35);
            nextButton.TabIndex = 11;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // backButton
            // 
            backButton.BackgroundImage = Resources.back;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderColor = Color.FromArgb(33, 44, 66);
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 44, 66);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 44, 66);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(6, 10);
            backButton.Name = "backButton";
            backButton.Size = new Size(70, 47);
            backButton.TabIndex = 10;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // cartesianPlane
            // 
            cartesianPlane.BackColor = Color.FromArgb(33, 44, 66);
            cartesianPlane.BorderStyle = BorderStyle.FixedSingle;
            cartesianPlane.Controls.Add(leftCartesianChart);
            cartesianPlane.Location = new Point(22, 21);
            cartesianPlane.Name = "cartesianPlane";
            cartesianPlane.Size = new Size(379, 275);
            cartesianPlane.TabIndex = 9;
            cartesianPlane.Visible = false;
            // 
            // leftCartesianChart
            // 
            leftCartesianChart.AutoUpdateEnabled = true;
            leftCartesianChart.ChartTheme = null;
            leftCartesianChart.Dock = DockStyle.Fill;
            skDefaultLegend10.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend10.Content = null;
            skDefaultLegend10.IsValid = false;
            skDefaultLegend10.Opacity = 1F;
            padding19.Bottom = 0F;
            padding19.Left = 0F;
            padding19.Right = 0F;
            padding19.Top = 0F;
            skDefaultLegend10.Padding = padding19;
            skDefaultLegend10.RemoveOnCompleted = false;
            skDefaultLegend10.RotateTransform = 0F;
            skDefaultLegend10.X = 0F;
            skDefaultLegend10.Y = 0F;
            leftCartesianChart.Legend = skDefaultLegend10;
            leftCartesianChart.Location = new Point(0, 0);
            leftCartesianChart.MatchAxesScreenDataRatio = false;
            leftCartesianChart.Name = "leftCartesianChart";
            leftCartesianChart.Size = new Size(377, 273);
            leftCartesianChart.TabIndex = 8;
            skDefaultTooltip10.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip10.Content = null;
            skDefaultTooltip10.IsValid = false;
            skDefaultTooltip10.Opacity = 1F;
            padding20.Bottom = 0F;
            padding20.Left = 0F;
            padding20.Right = 0F;
            padding20.Top = 0F;
            skDefaultTooltip10.Padding = padding20;
            skDefaultTooltip10.RemoveOnCompleted = false;
            skDefaultTooltip10.RotateTransform = 0F;
            skDefaultTooltip10.Wedge = 10;
            skDefaultTooltip10.X = 0F;
            skDefaultTooltip10.Y = 0F;
            leftCartesianChart.Tooltip = skDefaultTooltip10;
            leftCartesianChart.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            leftCartesianChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            leftCartesianChart.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(noDataLabel);
            panel5.Controls.Add(rightPieChart);
            panel5.Location = new Point(425, 53);
            panel5.Name = "panel5";
            panel5.Size = new Size(290, 243);
            panel5.TabIndex = 7;
            // 
            // noDataLabel
            // 
            noDataLabel.AutoSize = true;
            noDataLabel.Enabled = false;
            noDataLabel.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noDataLabel.ForeColor = Color.Beige;
            noDataLabel.Location = new Point(93, 112);
            noDataLabel.Name = "noDataLabel";
            noDataLabel.Size = new Size(105, 16);
            noDataLabel.TabIndex = 8;
            noDataLabel.Text = "No data found.";
            noDataLabel.Visible = false;
            // 
            // rightPieChart
            // 
            rightPieChart.AutoUpdateEnabled = true;
            rightPieChart.BackColor = Color.FromArgb(33, 44, 66);
            rightPieChart.BorderStyle = BorderStyle.FixedSingle;
            rightPieChart.ChartTheme = null;
            rightPieChart.Dock = DockStyle.Fill;
            skDefaultLegend11.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend11.Content = null;
            skDefaultLegend11.IsValid = false;
            skDefaultLegend11.Opacity = 1F;
            padding21.Bottom = 0F;
            padding21.Left = 0F;
            padding21.Right = 0F;
            padding21.Top = 0F;
            skDefaultLegend11.Padding = padding21;
            skDefaultLegend11.RemoveOnCompleted = false;
            skDefaultLegend11.RotateTransform = 0F;
            skDefaultLegend11.X = 0F;
            skDefaultLegend11.Y = 0F;
            rightPieChart.Legend = skDefaultLegend11;
            rightPieChart.Location = new Point(0, 0);
            rightPieChart.Name = "rightPieChart";
            rightPieChart.Size = new Size(290, 243);
            rightPieChart.TabIndex = 1;
            skDefaultTooltip11.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip11.Content = null;
            skDefaultTooltip11.IsValid = false;
            skDefaultTooltip11.Opacity = 1F;
            padding22.Bottom = 0F;
            padding22.Left = 0F;
            padding22.Right = 0F;
            padding22.Top = 0F;
            skDefaultTooltip11.Padding = padding22;
            skDefaultTooltip11.RemoveOnCompleted = false;
            skDefaultTooltip11.RotateTransform = 0F;
            skDefaultTooltip11.Wedge = 10;
            skDefaultTooltip11.X = 0F;
            skDefaultTooltip11.Y = 0F;
            rightPieChart.Tooltip = skDefaultTooltip11;
            rightPieChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            rightPieChart.Visible = false;
            // 
            // labelTaskCount
            // 
            labelTaskCount.AutoSize = true;
            labelTaskCount.Enabled = false;
            labelTaskCount.Font = new Font("Ubuntu Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTaskCount.ForeColor = Color.Beige;
            labelTaskCount.Location = new Point(60, 202);
            labelTaskCount.Name = "labelTaskCount";
            labelTaskCount.Size = new Size(65, 23);
            labelTaskCount.TabIndex = 4;
            labelTaskCount.Text = "Tasks";
            labelTaskCount.Visible = false;
            // 
            // profileChart
            // 
            profileChart.AutoUpdateEnabled = true;
            profileChart.BackColor = Color.FromArgb(255, 255, 192);
            profileChart.ChartTheme = null;
            profileChart.Enabled = false;
            skDefaultLegend12.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend12.Content = null;
            skDefaultLegend12.IsValid = false;
            skDefaultLegend12.Opacity = 1F;
            padding23.Bottom = 0F;
            padding23.Left = 0F;
            padding23.Right = 0F;
            padding23.Top = 0F;
            skDefaultLegend12.Padding = padding23;
            skDefaultLegend12.RemoveOnCompleted = false;
            skDefaultLegend12.RotateTransform = 0F;
            skDefaultLegend12.X = 0F;
            skDefaultLegend12.Y = 0F;
            profileChart.Legend = skDefaultLegend12;
            profileChart.Location = new Point(22, 31);
            profileChart.Name = "profileChart";
            profileChart.Size = new Size(150, 150);
            profileChart.TabIndex = 0;
            skDefaultTooltip12.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip12.Content = null;
            skDefaultTooltip12.IsValid = false;
            skDefaultTooltip12.Opacity = 1F;
            padding24.Bottom = 0F;
            padding24.Left = 0F;
            padding24.Right = 0F;
            padding24.Top = 0F;
            skDefaultTooltip12.Padding = padding24;
            skDefaultTooltip12.RemoveOnCompleted = false;
            skDefaultTooltip12.RotateTransform = 0F;
            skDefaultTooltip12.Wedge = 10;
            skDefaultTooltip12.X = 0F;
            skDefaultTooltip12.Y = 0F;
            profileChart.Tooltip = skDefaultTooltip12;
            profileChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            profileChart.Visible = false;
            // 
            // countPanel
            // 
            countPanel.BorderStyle = BorderStyle.FixedSingle;
            countPanel.Controls.Add(pendingUsersLbl);
            countPanel.Controls.Add(approvedCountLbl);
            countPanel.Controls.Add(totalUsersLbl);
            countPanel.Location = new Point(425, 308);
            countPanel.Name = "countPanel";
            countPanel.Size = new Size(290, 78);
            countPanel.TabIndex = 6;
            countPanel.Visible = false;
            // 
            // pendingUsersLbl
            // 
            pendingUsersLbl.AutoSize = true;
            pendingUsersLbl.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingUsersLbl.ForeColor = Color.Beige;
            pendingUsersLbl.Location = new Point(3, 54);
            pendingUsersLbl.Name = "pendingUsersLbl";
            pendingUsersLbl.Size = new Size(105, 16);
            pendingUsersLbl.TabIndex = 5;
            pendingUsersLbl.Text = "Pending Count:";
            pendingUsersLbl.Visible = false;
            // 
            // approvedCountLbl
            // 
            approvedCountLbl.AutoSize = true;
            approvedCountLbl.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            approvedCountLbl.ForeColor = Color.Beige;
            approvedCountLbl.Location = new Point(3, 27);
            approvedCountLbl.Name = "approvedCountLbl";
            approvedCountLbl.Size = new Size(112, 16);
            approvedCountLbl.TabIndex = 4;
            approvedCountLbl.Text = "Approved Count:";
            approvedCountLbl.Visible = false;
            // 
            // totalUsersLbl
            // 
            totalUsersLbl.AutoSize = true;
            totalUsersLbl.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalUsersLbl.ForeColor = Color.Beige;
            totalUsersLbl.Location = new Point(3, 3);
            totalUsersLbl.Name = "totalUsersLbl";
            totalUsersLbl.Size = new Size(91, 16);
            totalUsersLbl.TabIndex = 3;
            totalUsersLbl.Text = "Total Count:";
            totalUsersLbl.Visible = false;
            // 
            // AdDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 548);
            Controls.Add(panel1);
            Controls.Add(bodyPanel);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            MaximizeBox = false;
            Name = "AdDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminDashboard_Load;
            headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homeButton).EndInit();
            bodyPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            yearRangePanel.ResumeLayout(false);
            yearRangePanel.PerformLayout();
            modifyYearPanel.ResumeLayout(false);
            modifyYearPanel.PerformLayout();
            cartesianPlane.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            countPanel.ResumeLayout(false);
            countPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Panel headPanel;
        private PictureBox homeButton;
        private DataGridView attendanceGrid;
        private ContextMenuStrip delORmod;
        private Panel bodyPanel;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button attendanceB;
        private Button usersB;
        private Button addUserButton;
        private Button modifyRowButton;
        private Button deleteRowButton;
        private Label pendingUsersLbl;
        private Button loadButton;
        private Label nameLabel;
        private TextBox nameTxtBox;
        private TextBox idTxtBox;
        private Label lastNameLabel;
        private TextBox fNameTxtBox;
        private Label Dashboard;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart profileChart;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart rightPieChart;
        private Label totalUsersLbl;
        private Panel countPanel;
        private Label attendanceDashboard;
        private Label usersDashboard;
        private Panel panel5;
        private Label labelTaskCount;
        private Label noDataLabel;
        private Panel cartesianPlane;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart leftCartesianChart;
        private Label approvedCountLbl;
        private Panel modifyYearPanel;
        private Button nextButton;
        private Button backButton;
        private Label yearLbl;
        private Label dataLbl;
        private Panel yearRangePanel;
    }
}