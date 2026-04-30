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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend7 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdDashboard));
            LiveChartsCore.Drawing.Padding padding13 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip7 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding14 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend8 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding15 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip8 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding16 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend9 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding17 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip9 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding18 = new LiveChartsCore.Drawing.Padding();
            delORmod = new ContextMenuStrip(components);
            panel4 = new Panel();
            headPanel = new Panel();
            homeButton = new PictureBox();
            bodyPanel = new Panel();
            panel3 = new Panel();
            attendanceDashboard = new Label();
            usersDashboard = new Label();
            payrollDashboard = new Label();
            Dashboard = new Label();
            attendanceB = new Button();
            usersB = new Button();
            payrollBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            yearRangePanel = new Panel();
            yearRangeLbl = new Label();
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
            panel3.Controls.Add(payrollDashboard);
            panel3.Controls.Add(Dashboard);
            panel3.Controls.Add(attendanceB);
            panel3.Controls.Add(usersB);
            panel3.Controls.Add(payrollBtn);
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
            attendanceDashboard.Location = new Point(16, 315);
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
            usersDashboard.Location = new Point(16, 228);
            usersDashboard.Name = "usersDashboard";
            usersDashboard.Size = new Size(42, 16);
            usersDashboard.TabIndex = 8;
            usersDashboard.Text = "Users";
            // 
            // payrollDashboard
            // 
            payrollDashboard.AutoSize = true;
            payrollDashboard.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payrollDashboard.ForeColor = Color.Beige;
            payrollDashboard.Location = new Point(14, 142);
            payrollDashboard.Name = "payrollDashboard";
            payrollDashboard.Size = new Size(56, 16);
            payrollDashboard.TabIndex = 7;
            payrollDashboard.Text = "Payroll";
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
            attendanceB.Enabled = false;
            attendanceB.FlatAppearance.BorderColor = Color.Beige;
            attendanceB.FlatAppearance.MouseDownBackColor = Color.Beige;
            attendanceB.FlatStyle = FlatStyle.Flat;
            attendanceB.Location = new Point(14, 255);
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
            usersB.Enabled = false;
            usersB.FlatAppearance.BorderColor = Color.Beige;
            usersB.FlatAppearance.MouseDownBackColor = Color.Beige;
            usersB.FlatStyle = FlatStyle.Flat;
            usersB.ForeColor = SystemColors.Control;
            usersB.Location = new Point(14, 168);
            usersB.Name = "usersB";
            usersB.Size = new Size(172, 57);
            usersB.TabIndex = 1;
            usersB.UseVisualStyleBackColor = false;
            usersB.Visible = false;
            usersB.Click += usersB_Click;
            // 
            // payrollBtn
            // 
            payrollBtn.BackgroundImage = Resources.payroll;
            payrollBtn.BackgroundImageLayout = ImageLayout.Zoom;
            payrollBtn.Enabled = false;
            payrollBtn.FlatAppearance.BorderColor = Color.Beige;
            payrollBtn.FlatAppearance.MouseDownBackColor = Color.Beige;
            payrollBtn.FlatStyle = FlatStyle.Flat;
            payrollBtn.Location = new Point(14, 80);
            payrollBtn.Name = "payrollBtn";
            payrollBtn.Size = new Size(172, 57);
            payrollBtn.TabIndex = 0;
            payrollBtn.UseVisualStyleBackColor = false;
            payrollBtn.Visible = false;
            payrollBtn.Click += taskB_Click;
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
            yearRangePanel.Controls.Add(yearRangeLbl);
            yearRangePanel.Enabled = false;
            yearRangePanel.Location = new Point(425, 21);
            yearRangePanel.Name = "yearRangePanel";
            yearRangePanel.Size = new Size(290, 26);
            yearRangePanel.TabIndex = 7;
            yearRangePanel.Visible = false;
            // 
            // yearRangeLbl
            // 
            yearRangeLbl.AutoSize = true;
            yearRangeLbl.Enabled = false;
            yearRangeLbl.Font = new Font("Ubuntu Mono", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearRangeLbl.ForeColor = Color.Beige;
            yearRangeLbl.Location = new Point(97, 3);
            yearRangeLbl.Name = "yearRangeLbl";
            yearRangeLbl.Size = new Size(96, 18);
            yearRangeLbl.TabIndex = 9;
            yearRangeLbl.Text = "2000 - 2000";
            yearRangeLbl.Visible = false;
            yearRangeLbl.Click += label1_Click;
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
            yearLbl.Visible = false;
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
            nextButton.Visible = false;
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
            backButton.Visible = false;
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
            skDefaultLegend7.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend7.Content = null;
            skDefaultLegend7.IsValid = false;
            skDefaultLegend7.Opacity = 1F;
            padding13.Bottom = 0F;
            padding13.Left = 0F;
            padding13.Right = 0F;
            padding13.Top = 0F;
            skDefaultLegend7.Padding = padding13;
            skDefaultLegend7.RemoveOnCompleted = false;
            skDefaultLegend7.RotateTransform = 0F;
            skDefaultLegend7.X = 0F;
            skDefaultLegend7.Y = 0F;
            leftCartesianChart.Legend = skDefaultLegend7;
            leftCartesianChart.Location = new Point(0, 0);
            leftCartesianChart.MatchAxesScreenDataRatio = false;
            leftCartesianChart.Name = "leftCartesianChart";
            leftCartesianChart.Size = new Size(377, 273);
            leftCartesianChart.TabIndex = 8;
            skDefaultTooltip7.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip7.Content = null;
            skDefaultTooltip7.IsValid = false;
            skDefaultTooltip7.Opacity = 1F;
            padding14.Bottom = 0F;
            padding14.Left = 0F;
            padding14.Right = 0F;
            padding14.Top = 0F;
            skDefaultTooltip7.Padding = padding14;
            skDefaultTooltip7.RemoveOnCompleted = false;
            skDefaultTooltip7.RotateTransform = 0F;
            skDefaultTooltip7.Wedge = 10;
            skDefaultTooltip7.X = 0F;
            skDefaultTooltip7.Y = 0F;
            leftCartesianChart.Tooltip = skDefaultTooltip7;
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
            rightPieChart.Enabled = false;
            skDefaultLegend8.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend8.Content = null;
            skDefaultLegend8.IsValid = false;
            skDefaultLegend8.Opacity = 1F;
            padding15.Bottom = 0F;
            padding15.Left = 0F;
            padding15.Right = 0F;
            padding15.Top = 0F;
            skDefaultLegend8.Padding = padding15;
            skDefaultLegend8.RemoveOnCompleted = false;
            skDefaultLegend8.RotateTransform = 0F;
            skDefaultLegend8.X = 0F;
            skDefaultLegend8.Y = 0F;
            rightPieChart.Legend = skDefaultLegend8;
            rightPieChart.Location = new Point(0, 0);
            rightPieChart.Name = "rightPieChart";
            rightPieChart.Size = new Size(290, 243);
            rightPieChart.TabIndex = 1;
            skDefaultTooltip8.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip8.Content = null;
            skDefaultTooltip8.IsValid = false;
            skDefaultTooltip8.Opacity = 1F;
            padding16.Bottom = 0F;
            padding16.Left = 0F;
            padding16.Right = 0F;
            padding16.Top = 0F;
            skDefaultTooltip8.Padding = padding16;
            skDefaultTooltip8.RemoveOnCompleted = false;
            skDefaultTooltip8.RotateTransform = 0F;
            skDefaultTooltip8.Wedge = 10;
            skDefaultTooltip8.X = 0F;
            skDefaultTooltip8.Y = 0F;
            rightPieChart.Tooltip = skDefaultTooltip8;
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
            skDefaultLegend9.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend9.Content = null;
            skDefaultLegend9.IsValid = false;
            skDefaultLegend9.Opacity = 1F;
            padding17.Bottom = 0F;
            padding17.Left = 0F;
            padding17.Right = 0F;
            padding17.Top = 0F;
            skDefaultLegend9.Padding = padding17;
            skDefaultLegend9.RemoveOnCompleted = false;
            skDefaultLegend9.RotateTransform = 0F;
            skDefaultLegend9.X = 0F;
            skDefaultLegend9.Y = 0F;
            profileChart.Legend = skDefaultLegend9;
            profileChart.Location = new Point(22, 31);
            profileChart.Name = "profileChart";
            profileChart.Size = new Size(150, 150);
            profileChart.TabIndex = 0;
            skDefaultTooltip9.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip9.Content = null;
            skDefaultTooltip9.IsValid = false;
            skDefaultTooltip9.Opacity = 1F;
            padding18.Bottom = 0F;
            padding18.Left = 0F;
            padding18.Right = 0F;
            padding18.Top = 0F;
            skDefaultTooltip9.Padding = padding18;
            skDefaultTooltip9.RemoveOnCompleted = false;
            skDefaultTooltip9.RotateTransform = 0F;
            skDefaultTooltip9.Wedge = 10;
            skDefaultTooltip9.X = 0F;
            skDefaultTooltip9.Y = 0F;
            profileChart.Tooltip = skDefaultTooltip9;
            profileChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            profileChart.Visible = false;
            // 
            // countPanel
            // 
            countPanel.BorderStyle = BorderStyle.FixedSingle;
            countPanel.Controls.Add(pendingUsersLbl);
            countPanel.Controls.Add(approvedCountLbl);
            countPanel.Controls.Add(totalUsersLbl);
            countPanel.Enabled = false;
            countPanel.Location = new Point(425, 308);
            countPanel.Name = "countPanel";
            countPanel.Size = new Size(290, 78);
            countPanel.TabIndex = 6;
            countPanel.Visible = false;
            // 
            // pendingUsersLbl
            // 
            pendingUsersLbl.AutoSize = true;
            pendingUsersLbl.Enabled = false;
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
            approvedCountLbl.Enabled = false;
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
            totalUsersLbl.Enabled = false;
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
        private Button payrollBtn;
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
        private Label payrollDashboard;
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
        private Label yearRangeLbl;
        private Panel yearRangePanel;
    }
}