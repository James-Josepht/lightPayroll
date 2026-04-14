using lighPayrollUI.Properties;

namespace lighPayroll
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            headPanel = new Panel();
            exitLabel = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            searchMenuStrip = new MenuStrip();
            searchMS = new ToolStripMenuItem();
            searchBox = new ToolStripTextBox();
            toolStripSeparator5 = new ToolStripSeparator();
            recentSearches = new ToolStripTextBox();
            featureStrip1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            featureStrip2 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            featureStrip3 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            toolStripMenuItem13 = new ToolStripMenuItem();
            toolStripMenuItem14 = new ToolStripMenuItem();
            toolStripMenuItem15 = new ToolStripMenuItem();
            toolStripMenuItem16 = new ToolStripMenuItem();
            toolStripMenuItem17 = new ToolStripMenuItem();
            toolStripMenuItem19 = new ToolStripMenuItem();
            toolStripMenuItem21 = new ToolStripMenuItem();
            toolStripMenuItem22 = new ToolStripMenuItem();
            panel6 = new Panel();
            exitButton = new Button();
            bodyPanel = new Panel();
            label4 = new Label();
            encourageVerses = new Label();
            attendanceTool = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            taskPanel = new Panel();
            taskListsWordLabel = new Label();
            toDoLabel = new Label();
            toDoPicture = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            taskLabel = new Label();
            payrollTool = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            userControlPanel = new Panel();
            userModificationLabel = new Label();
            userModificationPic = new PictureBox();
            userModificationShort = new Label();
            greetingPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            greetingLabel = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            searchMenuStrip.SuspendLayout();
            panel6.SuspendLayout();
            bodyPanel.SuspendLayout();
            attendanceTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            taskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toDoPicture).BeginInit();
            payrollTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            userControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userModificationPic).BeginInit();
            greetingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(exitLabel);
            headPanel.Controls.Add(pictureBox2);
            headPanel.Controls.Add(panel5);
            headPanel.Controls.Add(panel6);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(937, 101);
            headPanel.TabIndex = 1;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.FromArgb(33, 44, 66);
            exitLabel.Location = new Point(852, 60);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(63, 16);
            exitLabel.TabIndex = 7;
            exitLabel.Text = "Sign Out";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Resources.smart_idea;
            pictureBox2.Location = new Point(10, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.AllowDrop = true;
            panel5.AutoScroll = true;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(searchMenuStrip);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(761, 34);
            panel5.Name = "panel5";
            panel5.Size = new Size(58, 33);
            panel5.TabIndex = 3;
            // 
            // searchMenuStrip
            // 
            searchMenuStrip.BackgroundImage = Resources.search_interface_symbol;
            searchMenuStrip.BackgroundImageLayout = ImageLayout.Stretch;
            searchMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMenuStrip.ImageScalingSize = new Size(20, 20);
            searchMenuStrip.Items.AddRange(new ToolStripItem[] { searchMS, toolStripMenuItem12, toolStripMenuItem13, toolStripMenuItem14, toolStripMenuItem15, toolStripMenuItem16, toolStripMenuItem17, toolStripMenuItem19, toolStripMenuItem21, toolStripMenuItem22 });
            searchMenuStrip.Location = new Point(0, 0);
            searchMenuStrip.Name = "searchMenuStrip";
            searchMenuStrip.Padding = new Padding(5, 2, 0, 2);
            searchMenuStrip.RightToLeft = RightToLeft.Yes;
            searchMenuStrip.Size = new Size(58, 29);
            searchMenuStrip.TabIndex = 0;
            searchMenuStrip.Text = "menuStrip2";
            // 
            // searchMS
            // 
            searchMS.BackColor = Color.Transparent;
            searchMS.BackgroundImageLayout = ImageLayout.Stretch;
            searchMS.DropDownItems.AddRange(new ToolStripItem[] { searchBox, toolStripSeparator5, recentSearches, featureStrip1, toolStripSeparator1, featureStrip2, toolStripSeparator2, featureStrip3 });
            searchMS.Font = new Font("Sans Serif Collection", 4.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMS.Name = "searchMS";
            searchMS.Size = new Size(51, 25);
            searchMS.Text = "                             ";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.White;
            searchBox.Name = "searchBox";
            searchBox.RightToLeft = RightToLeft.No;
            searchBox.Size = new Size(100, 25);
            searchBox.KeyDown += searchBox_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(157, 6);
            // 
            // recentSearches
            // 
            recentSearches.BackColor = Color.Beige;
            recentSearches.BorderStyle = BorderStyle.None;
            recentSearches.Enabled = false;
            recentSearches.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recentSearches.Name = "recentSearches";
            recentSearches.ReadOnly = true;
            recentSearches.RightToLeft = RightToLeft.No;
            recentSearches.Size = new Size(100, 13);
            recentSearches.Text = "Recent Features";
            // 
            // featureStrip1
            // 
            featureStrip1.BackColor = Color.Beige;
            featureStrip1.BackgroundImage = (Image)resources.GetObject("featureStrip1.BackgroundImage");
            featureStrip1.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip1.Name = "featureStrip1";
            featureStrip1.Size = new Size(160, 22);
            featureStrip1.Text = "Attendance";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = SystemColors.Info;
            toolStripSeparator1.ForeColor = SystemColors.ActiveCaption;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // featureStrip2
            // 
            featureStrip2.BackColor = Color.Beige;
            featureStrip2.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip2.Name = "featureStrip2";
            featureStrip2.Size = new Size(160, 22);
            featureStrip2.Text = "User Removal";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = SystemColors.Info;
            toolStripSeparator2.ForeColor = SystemColors.ActiveCaption;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(157, 6);
            // 
            // featureStrip3
            // 
            featureStrip3.BackColor = Color.Beige;
            featureStrip3.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip3.Name = "featureStrip3";
            featureStrip3.Size = new Size(160, 22);
            featureStrip3.Text = "Payroll";
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(12, 25);
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.Size = new Size(12, 25);
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.Size = new Size(12, 25);
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            toolStripMenuItem15.Size = new Size(12, 25);
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            toolStripMenuItem16.Size = new Size(12, 25);
            // 
            // toolStripMenuItem17
            // 
            toolStripMenuItem17.Name = "toolStripMenuItem17";
            toolStripMenuItem17.Size = new Size(12, 25);
            // 
            // toolStripMenuItem19
            // 
            toolStripMenuItem19.Name = "toolStripMenuItem19";
            toolStripMenuItem19.Size = new Size(12, 25);
            // 
            // toolStripMenuItem21
            // 
            toolStripMenuItem21.Name = "toolStripMenuItem21";
            toolStripMenuItem21.Size = new Size(12, 25);
            // 
            // toolStripMenuItem22
            // 
            toolStripMenuItem22.Name = "toolStripMenuItem22";
            toolStripMenuItem22.Size = new Size(12, 25);
            // 
            // panel6
            // 
            panel6.Controls.Add(exitButton);
            panel6.Location = new Point(840, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(85, 67);
            panel6.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = Resources.exit;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderColor = Color.White;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(26, 14);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(40, 23);
            exitButton.TabIndex = 6;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(label4);
            bodyPanel.Controls.Add(encourageVerses);
            bodyPanel.Controls.Add(attendanceTool);
            bodyPanel.Controls.Add(taskPanel);
            bodyPanel.Controls.Add(label6);
            bodyPanel.Controls.Add(label7);
            bodyPanel.Controls.Add(taskLabel);
            bodyPanel.Controls.Add(payrollTool);
            bodyPanel.Controls.Add(userControlPanel);
            bodyPanel.Location = new Point(73, 156);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(783, 445);
            bodyPanel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ubuntu Mono", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(32, 394);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 22;
            label4.Text = "Bible Verse:";
            // 
            // encourageVerses
            // 
            encourageVerses.AutoSize = true;
            encourageVerses.Font = new Font("Ubuntu Mono", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encourageVerses.ForeColor = Color.Beige;
            encourageVerses.Location = new Point(155, 395);
            encourageVerses.Name = "encourageVerses";
            encourageVerses.Size = new Size(96, 18);
            encourageVerses.TabIndex = 8;
            encourageVerses.Text = "Bible Verse";
            // 
            // attendanceTool
            // 
            attendanceTool.BorderStyle = BorderStyle.FixedSingle;
            attendanceTool.Controls.Add(pictureBox3);
            attendanceTool.Controls.Add(label3);
            attendanceTool.Controls.Add(label2);
            attendanceTool.Cursor = Cursors.Hand;
            attendanceTool.Location = new Point(32, 232);
            attendanceTool.Name = "attendanceTool";
            attendanceTool.Size = new Size(724, 56);
            attendanceTool.TabIndex = 16;
            attendanceTool.Click += attendanceToolClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += attendanceToolClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 44, 66);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(139, 5);
            label3.Name = "label3";
            label3.Size = new Size(132, 27);
            label3.TabIndex = 9;
            label3.Text = "Attendance";
            label3.Click += attendanceToolClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 44, 66);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(141, 32);
            label2.Name = "label2";
            label2.Size = new Size(296, 17);
            label2.TabIndex = 10;
            label2.Text = "Verify and modify attendance records";
            label2.Click += attendanceToolClick;
            // 
            // taskPanel
            // 
            taskPanel.BorderStyle = BorderStyle.FixedSingle;
            taskPanel.Controls.Add(taskListsWordLabel);
            taskPanel.Controls.Add(toDoLabel);
            taskPanel.Controls.Add(toDoPicture);
            taskPanel.Cursor = Cursors.Hand;
            taskPanel.Location = new Point(32, 78);
            taskPanel.Name = "taskPanel";
            taskPanel.Size = new Size(724, 56);
            taskPanel.TabIndex = 21;
            taskPanel.Click += toDoPanel_Click;
            // 
            // taskListsWordLabel
            // 
            taskListsWordLabel.AutoSize = true;
            taskListsWordLabel.BackColor = Color.FromArgb(33, 44, 66);
            taskListsWordLabel.Cursor = Cursors.Hand;
            taskListsWordLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskListsWordLabel.ForeColor = Color.Beige;
            taskListsWordLabel.Location = new Point(139, 31);
            taskListsWordLabel.Name = "taskListsWordLabel";
            taskListsWordLabel.Size = new Size(104, 17);
            taskListsWordLabel.TabIndex = 22;
            taskListsWordLabel.Text = "Let's start!";
            taskListsWordLabel.Click += toDoPanel_Click;
            // 
            // toDoLabel
            // 
            toDoLabel.AutoSize = true;
            toDoLabel.BackColor = Color.FromArgb(33, 44, 66);
            toDoLabel.Cursor = Cursors.Hand;
            toDoLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toDoLabel.ForeColor = Color.Beige;
            toDoLabel.Location = new Point(136, 7);
            toDoLabel.Name = "toDoLabel";
            toDoLabel.Size = new Size(120, 27);
            toDoLabel.TabIndex = 22;
            toDoLabel.Text = "Task List";
            toDoLabel.Click += toDoPanel_Click;
            // 
            // toDoPicture
            // 
            toDoPicture.Cursor = Cursors.Hand;
            toDoPicture.Image = Resources.to_do_list;
            toDoPicture.Location = new Point(23, 0);
            toDoPicture.Name = "toDoPicture";
            toDoPicture.Size = new Size(67, 50);
            toDoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            toDoPicture.TabIndex = 18;
            toDoPicture.TabStop = false;
            toDoPicture.Click += toDoPanel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(33, 44, 66);
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Beige;
            label6.Location = new Point(165, 242);
            label6.Name = "label6";
            label6.Size = new Size(156, 27);
            label6.TabIndex = 14;
            label6.Text = "Payroll Logs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(33, 44, 66);
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Beige;
            label7.Location = new Point(168, 271);
            label7.Name = "label7";
            label7.Size = new Size(232, 17);
            label7.TabIndex = 15;
            label7.Text = "Look and secure payroll logs";
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.BackColor = Color.FromArgb(33, 44, 66);
            taskLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskLabel.ForeColor = Color.Beige;
            taskLabel.Location = new Point(32, 23);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(108, 27);
            taskLabel.TabIndex = 9;
            taskLabel.Text = "My Tools";
            // 
            // payrollTool
            // 
            payrollTool.BorderStyle = BorderStyle.FixedSingle;
            payrollTool.Controls.Add(label9);
            payrollTool.Controls.Add(label8);
            payrollTool.Controls.Add(pictureBox4);
            payrollTool.Cursor = Cursors.Hand;
            payrollTool.Location = new Point(32, 312);
            payrollTool.Name = "payrollTool";
            payrollTool.Size = new Size(724, 56);
            payrollTool.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(33, 44, 66);
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Beige;
            label9.Location = new Point(133, 33);
            label9.Name = "label9";
            label9.Size = new Size(232, 17);
            label9.TabIndex = 21;
            label9.Text = "Look and secure payroll logs";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(33, 44, 66);
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Beige;
            label8.Location = new Point(133, 8);
            label8.Name = "label8";
            label8.Size = new Size(156, 27);
            label8.TabIndex = 20;
            label8.Text = "Payroll Logs";
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
         
            // 
            // userControlPanel
            // 
            userControlPanel.BorderStyle = BorderStyle.FixedSingle;
            userControlPanel.Controls.Add(userModificationLabel);
            userControlPanel.Controls.Add(userModificationPic);
            userControlPanel.Controls.Add(userModificationShort);
            userControlPanel.Cursor = Cursors.Hand;
            userControlPanel.Location = new Point(32, 152);
            userControlPanel.Name = "userControlPanel";
            userControlPanel.Size = new Size(724, 56);
            userControlPanel.TabIndex = 17;
            userControlPanel.Click += userControlPanel_Click;
            // 
            // userModificationLabel
            // 
            userModificationLabel.AutoSize = true;
            userModificationLabel.BackColor = Color.FromArgb(33, 44, 66);
            userModificationLabel.Cursor = Cursors.Hand;
            userModificationLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userModificationLabel.ForeColor = Color.Beige;
            userModificationLabel.Location = new Point(139, 5);
            userModificationLabel.Name = "userModificationLabel";
            userModificationLabel.Size = new Size(216, 27);
            userModificationLabel.TabIndex = 12;
            userModificationLabel.Text = "User Modification";
            userModificationLabel.Click += userControlPanel_Click;
            // 
            // userModificationPic
            // 
            userModificationPic.Cursor = Cursors.Hand;
            userModificationPic.Image = (Image)resources.GetObject("userModificationPic.Image");
            userModificationPic.Location = new Point(23, 1);
            userModificationPic.Name = "userModificationPic";
            userModificationPic.Size = new Size(67, 50);
            userModificationPic.SizeMode = PictureBoxSizeMode.StretchImage;
            userModificationPic.TabIndex = 11;
            userModificationPic.TabStop = false;
            userModificationPic.Click += userControlPanel_Click;
            // 
            // userModificationShort
            // 
            userModificationShort.AutoSize = true;
            userModificationShort.BackColor = Color.FromArgb(33, 44, 66);
            userModificationShort.Cursor = Cursors.Hand;
            userModificationShort.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userModificationShort.ForeColor = Color.Beige;
            userModificationShort.Location = new Point(141, 32);
            userModificationShort.Name = "userModificationShort";
            userModificationShort.Size = new Size(296, 17);
            userModificationShort.TabIndex = 13;
            userModificationShort.Text = "Be careful in handling user accounts";
            userModificationShort.Click += userControlPanel_Click;
            // 
            // greetingPanel
            // 
            greetingPanel.BackColor = Color.FromArgb(33, 44, 66);
            greetingPanel.Controls.Add(pictureBox1);
            greetingPanel.Controls.Add(label1);
            greetingPanel.Controls.Add(greetingLabel);
            greetingPanel.Location = new Point(73, 36);
            greetingPanel.Name = "greetingPanel";
            greetingPanel.Size = new Size(783, 98);
            greetingPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.good_evening_get_greeting;
            pictureBox1.Location = new Point(17, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(33, 44, 66);
            label1.Font = new Font("Ubuntu Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(111, 58);
            label1.Name = "label1";
            label1.Size = new Size(428, 23);
            label1.TabIndex = 7;
            label1.Text = "Welcome back! Ready to maintain stuff?";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.BackColor = Color.FromArgb(33, 44, 66);
            greetingLabel.Font = new Font("Ubuntu Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetingLabel.ForeColor = Color.Beige;
            greetingLabel.Location = new Point(108, 19);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(195, 34);
            greetingLabel.TabIndex = 6;
            greetingLabel.Text = "Hello Admin!";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(73, 620);
            panel4.Name = "panel4";
            panel4.Size = new Size(783, 33);
            panel4.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(greetingPanel);
            panel1.Controls.Add(bodyPanel);
            panel1.Location = new Point(3, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 445);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(73, 604);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 80);
            panel2.TabIndex = 4;
            // 
            // AdminUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(937, 574);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            Controls.Add(panel1);
            Name = "AdminUI";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminUI_Load;
            headPanel.ResumeLayout(false);
            headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            searchMenuStrip.ResumeLayout(false);
            searchMenuStrip.PerformLayout();
            panel6.ResumeLayout(false);
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            attendanceTool.ResumeLayout(false);
            attendanceTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            taskPanel.ResumeLayout(false);
            taskPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toDoPicture).EndInit();
            payrollTool.ResumeLayout(false);
            payrollTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            userControlPanel.ResumeLayout(false);
            userControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userModificationPic).EndInit();
            greetingPanel.ResumeLayout(false);
            greetingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void TaskListsWordLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel headPanel;
        private Panel bodyPanel;
        private Panel greetingPanel;
        private Panel panel4;
        private Panel panel1;
        private Panel panel2;
        private Label greetingLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel5;
        private MenuStrip searchMenuStrip;
        private ToolStripMenuItem searchMS;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripTextBox recentSearches;
        private ToolStripMenuItem featureStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem featureStrip2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem featureStrip3;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripMenuItem toolStripMenuItem21;
        private ToolStripMenuItem toolStripMenuItem22;
        private PictureBox pictureBox2;
        private Label taskLabel;
        private ToolStripTextBox searchBox;
        private PictureBox userModificationPic;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Label userModificationLabel;
        private Label userModificationShort;
        private Label label3;
        private Label label2;
        private Panel attendanceTool;
        private Panel userControlPanel;
        private Panel payrollTool;
        private PictureBox toDoPicture;
        private Panel taskPanel;
        private Label label9;
        private Label label8;
        private Label taskListsWordLabel;
        private Label toDoLabel;
        private Label encourageVerses;
        private Label label4;
        private Button exitButton;
        private Label exitLabel;
        private Panel panel6;
    }
}