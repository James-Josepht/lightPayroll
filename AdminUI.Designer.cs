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
            bodyPanel = new Panel();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            taskLabel = new Label();
            attendanceTool = new Panel();
            userRmTool = new Panel();
            payrollTool = new Panel();
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
            bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            greetingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(pictureBox2);
            headPanel.Controls.Add(panel5);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(1071, 119);
            headPanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.smart_idea;
            pictureBox2.Location = new Point(12, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 145);
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
            panel5.Location = new Point(667, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(61, 39);
            panel5.TabIndex = 3;
            // 
            // searchMenuStrip
            // 
            searchMenuStrip.BackgroundImage = (Image)resources.GetObject("searchMenuStrip.BackgroundImage");
            searchMenuStrip.BackgroundImageLayout = ImageLayout.None;
            searchMenuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMenuStrip.ImageScalingSize = new Size(20, 20);
            searchMenuStrip.Items.AddRange(new ToolStripItem[] { searchMS, toolStripMenuItem12, toolStripMenuItem13, toolStripMenuItem14, toolStripMenuItem15, toolStripMenuItem16, toolStripMenuItem17, toolStripMenuItem19, toolStripMenuItem21, toolStripMenuItem22 });
            searchMenuStrip.Location = new Point(0, 0);
            searchMenuStrip.Name = "searchMenuStrip";
            searchMenuStrip.RightToLeft = RightToLeft.Yes;
            searchMenuStrip.Size = new Size(61, 35);
            searchMenuStrip.TabIndex = 0;
            searchMenuStrip.Text = "menuStrip2";
            // 
            // searchMS
            // 
            searchMS.BackColor = Color.Beige;
            searchMS.BackgroundImage = (Image)resources.GetObject("searchMS.BackgroundImage");
            searchMS.BackgroundImageLayout = ImageLayout.Stretch;
            searchMS.DropDownItems.AddRange(new ToolStripItem[] { searchBox, toolStripSeparator5, recentSearches, featureStrip1, toolStripSeparator1, featureStrip2, toolStripSeparator2, featureStrip3 });
            searchMS.Font = new Font("Sans Serif Collection", 4.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMS.Name = "searchMS";
            searchMS.Size = new Size(55, 31);
            searchMS.Text = "                             ";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.White;
            searchBox.Name = "searchBox";
            searchBox.RightToLeft = RightToLeft.No;
            searchBox.Size = new Size(100, 27);
            searchBox.KeyDown += searchBox_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(174, 6);
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
            recentSearches.Size = new Size(100, 16);
            recentSearches.Text = "Recent Features";
            // 
            // featureStrip1
            // 
            featureStrip1.BackColor = Color.Beige;
            featureStrip1.BackgroundImage = (Image)resources.GetObject("featureStrip1.BackgroundImage");
            featureStrip1.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip1.Name = "featureStrip1";
            featureStrip1.Size = new Size(177, 26);
            featureStrip1.Text = "Attendance";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = SystemColors.Info;
            toolStripSeparator1.ForeColor = SystemColors.ActiveCaption;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(174, 6);
            // 
            // featureStrip2
            // 
            featureStrip2.BackColor = Color.Beige;
            featureStrip2.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip2.Name = "featureStrip2";
            featureStrip2.Size = new Size(177, 26);
            featureStrip2.Text = "User Removal";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = SystemColors.Info;
            toolStripSeparator2.ForeColor = SystemColors.ActiveCaption;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(174, 6);
            // 
            // featureStrip3
            // 
            featureStrip3.BackColor = Color.Beige;
            featureStrip3.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip3.Name = "featureStrip3";
            featureStrip3.Size = new Size(177, 26);
            featureStrip3.Text = "Payroll";
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(14, 31);
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.Size = new Size(14, 31);
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.Size = new Size(14, 31);
            // 
            // toolStripMenuItem15
            // 
            toolStripMenuItem15.Name = "toolStripMenuItem15";
            toolStripMenuItem15.Size = new Size(14, 31);
            // 
            // toolStripMenuItem16
            // 
            toolStripMenuItem16.Name = "toolStripMenuItem16";
            toolStripMenuItem16.Size = new Size(14, 31);
            // 
            // toolStripMenuItem17
            // 
            toolStripMenuItem17.Name = "toolStripMenuItem17";
            toolStripMenuItem17.Size = new Size(14, 31);
            // 
            // toolStripMenuItem19
            // 
            toolStripMenuItem19.Name = "toolStripMenuItem19";
            toolStripMenuItem19.Size = new Size(14, 31);
            // 
            // toolStripMenuItem21
            // 
            toolStripMenuItem21.Name = "toolStripMenuItem21";
            toolStripMenuItem21.Size = new Size(14, 31);
            // 
            // toolStripMenuItem22
            // 
            toolStripMenuItem22.Name = "toolStripMenuItem22";
            toolStripMenuItem22.Size = new Size(14, 31);
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(label6);
            bodyPanel.Controls.Add(label7);
            bodyPanel.Controls.Add(label4);
            bodyPanel.Controls.Add(label5);
            bodyPanel.Controls.Add(label3);
            bodyPanel.Controls.Add(label2);
            bodyPanel.Controls.Add(pictureBox5);
            bodyPanel.Controls.Add(pictureBox4);
            bodyPanel.Controls.Add(pictureBox3);
            bodyPanel.Controls.Add(taskLabel);
            bodyPanel.Controls.Add(attendanceTool);
            bodyPanel.Controls.Add(userRmTool);
            bodyPanel.Controls.Add(payrollTool);
            bodyPanel.Location = new Point(83, 184);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(895, 362);
            bodyPanel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(33, 44, 66);
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Beige;
            label6.Location = new Point(189, 285);
            label6.Name = "label6";
            label6.Size = new Size(195, 34);
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
            label7.Location = new Point(192, 319);
            label7.Name = "label7";
            label7.Size = new Size(290, 21);
            label7.TabIndex = 15;
            label7.Text = "Look and secure payroll logs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(33, 44, 66);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(192, 186);
            label4.Name = "label4";
            label4.Size = new Size(255, 34);
            label4.TabIndex = 12;
            label4.Text = "Employee Removal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(33, 44, 66);
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Beige;
            label5.Location = new Point(195, 220);
            label5.Name = "label5";
            label5.Size = new Size(370, 21);
            label5.TabIndex = 13;
            label5.Text = "Be careful in handling user accounts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 44, 66);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(192, 96);
            label3.Name = "label3";
            label3.Size = new Size(165, 34);
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
            label2.Location = new Point(195, 130);
            label2.Name = "label2";
            label2.Size = new Size(360, 21);
            label2.TabIndex = 10;
            label2.Text = "Verify and modify attedance records";
            label2.Click += attendanceToolClick;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(69, 186);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(77, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(69, 281);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(77, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(69, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += attendanceToolClick;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.BackColor = Color.FromArgb(33, 44, 66);
            taskLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskLabel.ForeColor = Color.Beige;
            taskLabel.Location = new Point(37, 27);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(135, 34);
            taskLabel.TabIndex = 9;
            taskLabel.Text = "My Tools";
            // 
            // attendanceTool
            // 
            attendanceTool.Cursor = Cursors.Hand;
            attendanceTool.Location = new Point(41, 92);
            attendanceTool.Name = "attendanceTool";
            attendanceTool.Size = new Size(816, 66);
            attendanceTool.TabIndex = 16;
            attendanceTool.Click += attendanceToolClick;
            // 
            // userRmTool
            // 
            userRmTool.Cursor = Cursors.Hand;
            userRmTool.Location = new Point(37, 179);
            userRmTool.Name = "userRmTool";
            userRmTool.Size = new Size(816, 66);
            userRmTool.TabIndex = 17;
            // 
            // payrollTool
            // 
            payrollTool.Cursor = Cursors.Hand;
            payrollTool.Location = new Point(37, 274);
            payrollTool.Name = "payrollTool";
            payrollTool.Size = new Size(816, 66);
            payrollTool.TabIndex = 17;
            // 
            // greetingPanel
            // 
            greetingPanel.BackColor = Color.FromArgb(33, 44, 66);
            greetingPanel.Controls.Add(pictureBox1);
            greetingPanel.Controls.Add(label1);
            greetingPanel.Controls.Add(greetingLabel);
            greetingPanel.Location = new Point(83, 42);
            greetingPanel.Name = "greetingPanel";
            greetingPanel.Size = new Size(895, 115);
            greetingPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 74);
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
            label1.Location = new Point(127, 68);
            label1.Name = "label1";
            label1.Size = new Size(506, 28);
            label1.TabIndex = 7;
            label1.Text = "Welcome back! Ready to maintain stuff?";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.BackColor = Color.FromArgb(33, 44, 66);
            greetingLabel.Font = new Font("Ubuntu Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetingLabel.ForeColor = Color.Beige;
            greetingLabel.Location = new Point(124, 22);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(234, 41);
            greetingLabel.TabIndex = 6;
            greetingLabel.Text = "Hello Admin!";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(83, 729);
            panel4.Name = "panel4";
            panel4.Size = new Size(895, 39);
            panel4.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(greetingPanel);
            panel1.Controls.Add(bodyPanel);
            panel1.Location = new Point(0, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 520);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(83, 552);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 25);
            panel2.TabIndex = 4;
            // 
            // AdminUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1071, 645);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            Controls.Add(panel1);
            Name = "AdminUI";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminUI_Load;
            headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            searchMenuStrip.ResumeLayout(false);
            searchMenuStrip.PerformLayout();
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            greetingPanel.ResumeLayout(false);
            greetingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
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
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel attendanceTool;
        private Panel userRmTool;
        private Panel payrollTool;
    }
}