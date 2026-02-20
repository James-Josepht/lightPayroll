namespace lighPayroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel6 = new Panel();
            joinHomeBut = new Button();
            loginHomeBut = new Button();
            panel5 = new Panel();
            menuStrip2 = new MenuStrip();
            searchMS = new ToolStripMenuItem();
            searchBox = new ToolStripComboBox();
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
            label7 = new Label();
            panel4 = new Panel();
            menuStrip1 = new MenuStrip();
            featuresMS = new ToolStripMenuItem();
            clockInFeatureTab = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            attendanceFeatureTab = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            payrollFeatureTab = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem18 = new ToolStripMenuItem();
            toolStripMenuItem20 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip2.SuspendLayout();
            panel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 128);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.Controls.Add(joinHomeBut);
            panel6.Controls.Add(loginHomeBut);
            panel6.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(762, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(297, 84);
            panel6.TabIndex = 3;
            // 
            // joinHomeBut
            // 
            joinHomeBut.BackColor = Color.Beige;
            joinHomeBut.BackgroundImage = (Image)resources.GetObject("joinHomeBut.BackgroundImage");
            joinHomeBut.BackgroundImageLayout = ImageLayout.Stretch;
            joinHomeBut.Cursor = Cursors.Hand;
            joinHomeBut.FlatAppearance.BorderSize = 0;
            joinHomeBut.FlatStyle = FlatStyle.Flat;
            joinHomeBut.Font = new Font("Ubuntu Mono", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            joinHomeBut.Location = new Point(150, 3);
            joinHomeBut.Name = "joinHomeBut";
            joinHomeBut.Size = new Size(144, 75);
            joinHomeBut.TabIndex = 2;
            joinHomeBut.Text = "Join for FREE";
            joinHomeBut.UseVisualStyleBackColor = false;
            joinHomeBut.Click += joinHomeBut_Click;
            // 
            // loginHomeBut
            // 
            loginHomeBut.BackColor = Color.Beige;
            loginHomeBut.BackgroundImage = (Image)resources.GetObject("loginHomeBut.BackgroundImage");
            loginHomeBut.BackgroundImageLayout = ImageLayout.Stretch;
            loginHomeBut.Cursor = Cursors.Hand;
            loginHomeBut.FlatAppearance.BorderSize = 0;
            loginHomeBut.FlatStyle = FlatStyle.Flat;
            loginHomeBut.Font = new Font("Ubuntu Mono", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginHomeBut.ForeColor = Color.White;
            loginHomeBut.Location = new Point(0, 3);
            loginHomeBut.Name = "loginHomeBut";
            loginHomeBut.Size = new Size(148, 75);
            loginHomeBut.TabIndex = 1;
            loginHomeBut.Text = "Log In";
            loginHomeBut.UseVisualStyleBackColor = false;
            loginHomeBut.Click += loginHomeBut_Click;
            // 
            // panel5
            // 
            panel5.AllowDrop = true;
            panel5.AutoScroll = true;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(menuStrip2);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(667, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(61, 39);
            panel5.TabIndex = 2;
            // 
            // menuStrip2
            // 
            menuStrip2.BackgroundImage = (Image)resources.GetObject("menuStrip2.BackgroundImage");
            menuStrip2.BackgroundImageLayout = ImageLayout.None;
            menuStrip2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { searchMS, toolStripMenuItem12, toolStripMenuItem13, toolStripMenuItem14, toolStripMenuItem15, toolStripMenuItem16, toolStripMenuItem17, toolStripMenuItem19, toolStripMenuItem21, toolStripMenuItem22 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RightToLeft = RightToLeft.Yes;
            menuStrip2.Size = new Size(61, 35);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
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
            searchBox.AutoSize = false;
            searchBox.BackColor = Color.White;
            searchBox.FlatStyle = FlatStyle.Standard;
            searchBox.Font = new Font("Ubuntu Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(121, 26);
            searchBox.Click += searchBox_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(221, 6);
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
            featureStrip1.Size = new Size(224, 26);
            featureStrip1.Text = "Feature 1";
            featureStrip1.Click += featureStrip1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = SystemColors.Info;
            toolStripSeparator1.ForeColor = SystemColors.ActiveCaption;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // featureStrip2
            // 
            featureStrip2.BackColor = Color.Beige;
            featureStrip2.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip2.Name = "featureStrip2";
            featureStrip2.Size = new Size(224, 26);
            featureStrip2.Text = "Feature 2";
            featureStrip2.Click += featureStrip2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = SystemColors.Info;
            toolStripSeparator2.ForeColor = SystemColors.ActiveCaption;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // featureStrip3
            // 
            featureStrip3.BackColor = Color.Beige;
            featureStrip3.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureStrip3.Name = "featureStrip3";
            featureStrip3.Size = new Size(224, 26);
            featureStrip3.Text = "Feature 3";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Beige;
            label7.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(33, 44, 66);
            label7.Location = new Point(341, 85);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 10;
            label7.Text = "Features";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(menuStrip1);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(335, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(107, 80);
            panel4.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = (Image)resources.GetObject("menuStrip1.BackgroundImage");
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { featuresMS, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem18, toolStripMenuItem20, toolStripMenuItem9, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(107, 59);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // featuresMS
            // 
            featuresMS.BackColor = Color.Beige;
            featuresMS.BackgroundImage = (Image)resources.GetObject("featuresMS.BackgroundImage");
            featuresMS.BackgroundImageLayout = ImageLayout.Stretch;
            featuresMS.DropDownItems.AddRange(new ToolStripItem[] { clockInFeatureTab, toolStripSeparator4, attendanceFeatureTab, toolStripSeparator3, payrollFeatureTab });
            featuresMS.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            featuresMS.ImageTransparentColor = Color.Transparent;
            featuresMS.Name = "featuresMS";
            featuresMS.Size = new Size(94, 55);
            featuresMS.Text = "                             ";
            // 
            // clockInFeatureTab
            // 
            clockInFeatureTab.BackgroundImage = (Image)resources.GetObject("clockInFeatureTab.BackgroundImage");
            clockInFeatureTab.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockInFeatureTab.Name = "clockInFeatureTab";
            clockInFeatureTab.Size = new Size(173, 26);
            clockInFeatureTab.Text = "Clock In";
            clockInFeatureTab.Click += clockInFeatureTab_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.ForeColor = Color.FromArgb(33, 44, 66);
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(170, 6);
            // 
            // attendanceFeatureTab
            // 
            attendanceFeatureTab.BackgroundImage = (Image)resources.GetObject("attendanceFeatureTab.BackgroundImage");
            attendanceFeatureTab.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceFeatureTab.Name = "attendanceFeatureTab";
            attendanceFeatureTab.Size = new Size(173, 26);
            attendanceFeatureTab.Text = "Attendance";
            attendanceFeatureTab.Click += attendanceFeatureTab_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = SystemColors.ActiveCaption;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(170, 6);
            // 
            // payrollFeatureTab
            // 
            payrollFeatureTab.BackColor = Color.Beige;
            payrollFeatureTab.Font = new Font("Ubuntu Mono Medium", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payrollFeatureTab.Name = "payrollFeatureTab";
            payrollFeatureTab.Size = new Size(173, 26);
            payrollFeatureTab.Text = "Payroll";
            payrollFeatureTab.Click += payrollFeatureTab_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(14, 55);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(14, 55);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(14, 55);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(14, 55);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(14, 55);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(14, 55);
            // 
            // toolStripMenuItem18
            // 
            toolStripMenuItem18.Name = "toolStripMenuItem18";
            toolStripMenuItem18.Size = new Size(14, 55);
            // 
            // toolStripMenuItem20
            // 
            toolStripMenuItem20.Name = "toolStripMenuItem20";
            toolStripMenuItem20.Size = new Size(14, 55);
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(14, 55);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 55);
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.smart_idea;
            pictureBox1.Location = new Point(12, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(49, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 386);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 44, 66);
            label2.Font = new Font("Ubuntu Mono", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 219);
            label2.Name = "label2";
            label2.Size = new Size(428, 48);
            label2.TabIndex = 6;
            label2.Text = "Hands-on accounting through real world\r\nscenario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(33, 44, 66);
            label1.Font = new Font("Ubuntu Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(32, 87);
            label1.Name = "label1";
            label1.Size = new Size(493, 116);
            label1.TabIndex = 5;
            label1.Text = "Experience growth \r\nwith Ligh♱Payroll\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.BackgroundImage = Properties.Resources.background;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-135, -23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(851, 406);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(46, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 69);
            panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.background;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(560, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(562, 406);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(33, 44, 66);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(725, 269);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(224, 178);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 44, 66);
            label3.Font = new Font("Ubuntu Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(680, 487);
            label3.Name = "label3";
            label3.Size = new Size(28, 28);
            label3.TabIndex = 7;
            label3.Text = "✓";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(33, 44, 66);
            label4.Font = new Font("Ubuntu Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(680, 537);
            label4.Name = "label4";
            label4.Size = new Size(28, 28);
            label4.TabIndex = 8;
            label4.Text = "✓";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(33, 44, 66);
            label5.Font = new Font("Ubuntu Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(709, 537);
            label5.Name = "label5";
            label5.Size = new Size(207, 28);
            label5.TabIndex = 7;
            label5.Text = "Improved Growth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(33, 44, 66);
            label6.Font = new Font("Ubuntu Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(709, 487);
            label6.Name = "label6";
            label6.Size = new Size(233, 28);
            label6.TabIndex = 9;
            label6.Text = "Beginner Friendly";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1071, 645);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem featuresMS;
        private ToolStripMenuItem clockInFeatureTab;
        private ToolStripMenuItem attendanceFeatureTab;
        private ToolStripMenuItem payrollFeatureTab;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private Panel panel5;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem searchMS;
        private ToolStripMenuItem featureStrip1;
        private ToolStripMenuItem featureStrip2;
        private ToolStripMenuItem featureStrip3;
        private ToolStripMenuItem toolStripMenuItem12;
        private Panel panel6;
        private Button joinHomeBut;
        private Button loginHomeBut;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem20;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripMenuItem toolStripMenuItem21;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripComboBox searchBox;
        private ToolStripTextBox recentSearches;
        private ToolStripMenuItem toolStripMenuItem22;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
