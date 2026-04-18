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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdDashboard));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
            delORmod = new ContextMenuStrip(components);
            panel4 = new Panel();
            headPanel = new Panel();
            homeButton = new PictureBox();
            bodyPanel = new Panel();
            panel3 = new Panel();
            Dashboard = new Label();
            attendanceB = new Button();
            usersB = new Button();
            taskB = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            labelTaskCount = new Label();
            labelUserCount = new Label();
            usersChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            profileChart = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            countPanel = new Panel();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeButton).BeginInit();
            bodyPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel3.Controls.Add(Dashboard);
            panel3.Controls.Add(attendanceB);
            panel3.Controls.Add(usersB);
            panel3.Controls.Add(taskB);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 426);
            panel3.TabIndex = 0;
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
            attendanceB.Location = new Point(14, 225);
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
            usersB.Location = new Point(14, 152);
            usersB.Name = "usersB";
            usersB.Size = new Size(172, 57);
            usersB.TabIndex = 1;
            usersB.UseVisualStyleBackColor = false;
            usersB.Visible = false;
            usersB.Click += usersB_Click;
            // 
            // taskB
            // 
            taskB.BackgroundImage = Resources.users;
            taskB.BackgroundImageLayout = ImageLayout.Zoom;
            taskB.Enabled = false;
            taskB.FlatAppearance.BorderColor = Color.Beige;
            taskB.FlatAppearance.MouseDownBackColor = Color.Beige;
            taskB.FlatStyle = FlatStyle.Flat;
            taskB.Location = new Point(14, 80);
            taskB.Name = "taskB";
            taskB.Size = new Size(172, 57);
            taskB.TabIndex = 0;
            taskB.UseVisualStyleBackColor = false;
            taskB.Visible = false;
            taskB.Click += taskB_Click;
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(labelTaskCount);
            panel2.Controls.Add(labelUserCount);
            panel2.Controls.Add(usersChart);
            panel2.Controls.Add(profileChart);
            panel2.Controls.Add(countPanel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 426);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ubuntu Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(22, 379);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 5;
            label3.Text = "NOTE: MESSAGE";
            // 
            // labelTaskCount
            // 
            labelTaskCount.AutoSize = true;
            labelTaskCount.Enabled = false;
            labelTaskCount.Font = new Font("Ubuntu Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTaskCount.ForeColor = Color.Beige;
            labelTaskCount.Location = new Point(267, 240);
            labelTaskCount.Name = "labelTaskCount";
            labelTaskCount.Size = new Size(65, 23);
            labelTaskCount.TabIndex = 4;
            labelTaskCount.Text = "Tasks";
            labelTaskCount.Visible = false;
            // 
            // labelUserCount
            // 
            labelUserCount.AutoSize = true;
            labelUserCount.Enabled = false;
            labelUserCount.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserCount.ForeColor = Color.Beige;
            labelUserCount.Location = new Point(502, 241);
            labelUserCount.Name = "labelUserCount";
            labelUserCount.Size = new Size(84, 16);
            labelUserCount.TabIndex = 3;
            labelUserCount.Text = "User Count:";
            labelUserCount.Visible = false;
            // 
            // usersChart
            // 
            usersChart.AutoUpdateEnabled = true;
            usersChart.BackColor = Color.FromArgb(33, 44, 66);
            usersChart.BorderStyle = BorderStyle.FixedSingle;
            usersChart.ChartTheme = null;
            usersChart.Enabled = false;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            usersChart.Legend = skDefaultLegend1;
            usersChart.Location = new Point(497, 31);
            usersChart.Name = "usersChart";
            usersChart.Size = new Size(200, 200);
            usersChart.TabIndex = 1;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            usersChart.Tooltip = skDefaultTooltip1;
            usersChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            usersChart.Visible = false;
            // 
            // profileChart
            // 
            profileChart.AutoUpdateEnabled = true;
            profileChart.BackColor = Color.FromArgb(255, 255, 192);
            profileChart.ChartTheme = null;
            profileChart.Enabled = false;
            skDefaultLegend2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend2.Content = null;
            skDefaultLegend2.IsValid = false;
            skDefaultLegend2.Opacity = 1F;
            padding3.Bottom = 0F;
            padding3.Left = 0F;
            padding3.Right = 0F;
            padding3.Top = 0F;
            skDefaultLegend2.Padding = padding3;
            skDefaultLegend2.RemoveOnCompleted = false;
            skDefaultLegend2.RotateTransform = 0F;
            skDefaultLegend2.X = 0F;
            skDefaultLegend2.Y = 0F;
            profileChart.Legend = skDefaultLegend2;
            profileChart.Location = new Point(228, 31);
            profileChart.Name = "profileChart";
            profileChart.Size = new Size(150, 150);
            profileChart.TabIndex = 0;
            skDefaultTooltip2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip2.Content = null;
            skDefaultTooltip2.IsValid = false;
            skDefaultTooltip2.Opacity = 1F;
            padding4.Bottom = 0F;
            padding4.Left = 0F;
            padding4.Right = 0F;
            padding4.Top = 0F;
            skDefaultTooltip2.Padding = padding4;
            skDefaultTooltip2.RemoveOnCompleted = false;
            skDefaultTooltip2.RotateTransform = 0F;
            skDefaultTooltip2.Wedge = 10;
            skDefaultTooltip2.X = 0F;
            skDefaultTooltip2.Y = 0F;
            profileChart.Tooltip = skDefaultTooltip2;
            profileChart.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            profileChart.Visible = false;
            // 
            // countPanel
            // 
            countPanel.BorderStyle = BorderStyle.FixedSingle;
            countPanel.Enabled = false;
            countPanel.Location = new Point(497, 238);
            countPanel.Name = "countPanel";
            countPanel.Size = new Size(200, 23);
            countPanel.TabIndex = 6;
            countPanel.Visible = false;
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
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
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
        private Button taskB;
        private Button addUserButton;
        private Button modifyRowButton;
        private Button deleteRowButton;
        private Label label1;
        private Button loadButton;
        private Label label4;
        private Label nameLabel;
        private TextBox nameTxtBox;
        private TextBox idTxtBox;
        private Label lastNameLabel;
        private TextBox fNameTxtBox;
        private Label Dashboard;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart profileChart;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart usersChart;
        private Label labelTaskCount;
        private Label labelUserCount;
        private Label label3;
        private Panel countPanel;
    }
}