namespace lighPayroll
{
    partial class AttendanceRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceRecords));
            label2 = new Label();
            bodyPanel = new Panel();
            loadButton = new Button();
            label1 = new Label();
            panel3 = new Panel();
            addUserButton = new Button();
            modifyRowButton = new Button();
            deleteRowButton = new Button();
            attendanceGrid = new DataGridView();
            taskLabel = new Label();
            delORmod = new ContextMenuStrip(components);
            panel4 = new Panel();
            panel2 = new Panel();
            headPanel = new Panel();
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            bodyPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).BeginInit();
            headPanel.SuspendLayout();
            panel5.SuspendLayout();
            searchMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 44, 66);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(36, 58);
            label2.Name = "label2";
            label2.Size = new Size(288, 17);
            label2.TabIndex = 10;
            label2.Text = "Verify and modify attedance records";
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(label4);
            bodyPanel.Controls.Add(label3);
            bodyPanel.Controls.Add(textBox2);
            bodyPanel.Controls.Add(textBox1);
            bodyPanel.Controls.Add(loadButton);
            bodyPanel.Controls.Add(label1);
            bodyPanel.Controls.Add(panel3);
            bodyPanel.Controls.Add(attendanceGrid);
            bodyPanel.Controls.Add(label2);
            bodyPanel.Controls.Add(taskLabel);
            bodyPanel.Location = new Point(0, 52);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(937, 495);
            bodyPanel.TabIndex = 2;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.Beige;
            loadButton.BackgroundImageLayout = ImageLayout.Stretch;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadButton.ForeColor = Color.FromArgb(33, 44, 66);
            loadButton.Location = new Point(90, 104);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(186, 34);
            loadButton.TabIndex = 14;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(33, 44, 66);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(312, 371);
            label1.Name = "label1";
            label1.Size = new Size(312, 17);
            label1.TabIndex = 13;
            label1.Text = "NOTE: SELECT A ROW TO DELETE OR MODIFY";
            // 
            // panel3
            // 
            panel3.Controls.Add(addUserButton);
            panel3.Controls.Add(modifyRowButton);
            panel3.Controls.Add(deleteRowButton);
            panel3.Location = new Point(566, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 34);
            panel3.TabIndex = 12;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.FromArgb(33, 44, 66);
            addUserButton.BackgroundImage = (Image)resources.GetObject("addUserButton.BackgroundImage");
            addUserButton.BackgroundImageLayout = ImageLayout.Stretch;
            addUserButton.Cursor = Cursors.Hand;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.ForeColor = Color.FromArgb(33, 44, 66);
            addUserButton.Location = new Point(248, 7);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(43, 25);
            addUserButton.TabIndex = 2;
            addUserButton.UseVisualStyleBackColor = false;
            // 
            // modifyRowButton
            // 
            modifyRowButton.BackColor = Color.FromArgb(33, 44, 66);
            modifyRowButton.BackgroundImage = (Image)resources.GetObject("modifyRowButton.BackgroundImage");
            modifyRowButton.BackgroundImageLayout = ImageLayout.Stretch;
            modifyRowButton.Cursor = Cursors.Hand;
            modifyRowButton.FlatStyle = FlatStyle.Flat;
            modifyRowButton.ForeColor = Color.FromArgb(33, 44, 66);
            modifyRowButton.Location = new Point(187, 7);
            modifyRowButton.Name = "modifyRowButton";
            modifyRowButton.Size = new Size(43, 25);
            modifyRowButton.TabIndex = 1;
            modifyRowButton.UseVisualStyleBackColor = false;
            // 
            // deleteRowButton
            // 
            deleteRowButton.BackColor = Color.FromArgb(33, 44, 66);
            deleteRowButton.BackgroundImage = (Image)resources.GetObject("deleteRowButton.BackgroundImage");
            deleteRowButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteRowButton.Cursor = Cursors.Hand;
            deleteRowButton.FlatStyle = FlatStyle.Flat;
            deleteRowButton.ForeColor = Color.FromArgb(33, 44, 66);
            deleteRowButton.Location = new Point(128, 7);
            deleteRowButton.Name = "deleteRowButton";
            deleteRowButton.Size = new Size(43, 25);
            deleteRowButton.TabIndex = 0;
            deleteRowButton.UseVisualStyleBackColor = false;
            // 
            // attendanceGrid
            // 
            attendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendanceGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            attendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceGrid.Location = new Point(90, 151);
            attendanceGrid.Name = "attendanceGrid";
            attendanceGrid.RowHeadersWidth = 51;
            attendanceGrid.Size = new Size(758, 210);
            attendanceGrid.TabIndex = 11;
            attendanceGrid.CellContentClick += attendanceGrid_CellContentClick;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.BackColor = Color.FromArgb(33, 44, 66);
            taskLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskLabel.ForeColor = Color.Beige;
            taskLabel.Location = new Point(32, 23);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(132, 27);
            taskLabel.TabIndex = 9;
            taskLabel.Text = "Attendance";
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 44, 66);
            panel2.Location = new Point(73, 490);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 58);
            panel2.TabIndex = 4;
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(panel5);
            headPanel.Controls.Add(pictureBox2);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(937, 101);
            headPanel.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.AllowDrop = true;
            panel5.AutoScroll = true;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(searchMenuStrip);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(605, 42);
            panel5.Name = "panel5";
            panel5.Size = new Size(58, 33);
            panel5.TabIndex = 6;
            // 
            // searchMenuStrip
            // 
            searchMenuStrip.BackgroundImage = Properties.Resources.search_interface_symbol;
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
            searchMS.Click += searchMS_Click;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.White;
            searchBox.Name = "searchBox";
            searchBox.RightToLeft = RightToLeft.No;
            searchBox.Size = new Size(100, 25);
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
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.smart_idea;
            pictureBox2.Location = new Point(10, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(bodyPanel);
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 499);
            panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(748, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(748, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 44, 66);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(689, 72);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 17;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(33, 44, 66);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(641, 47);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 18;
            label4.Text = "Student ID:";
            // 
            // AttendanceRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 548);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            Controls.Add(panel1);
            Name = "AttendanceRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AttendanceRecords_Load;
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).EndInit();
            headPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            searchMenuStrip.ResumeLayout(false);
            searchMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel bodyPanel;
        private Label taskLabel;
        private Panel panel4;
        private Panel panel2;
        private Panel headPanel;
        private PictureBox pictureBox2;
        private Panel panel1;
        private DataGridView attendanceGrid;
        private ContextMenuStrip delORmod;
        private Panel panel3;
        private Button addUserButton;
        private Button modifyRowButton;
        private Button deleteRowButton;
        private Label label1;
        private Button loadButton;
        private Panel panel5;
        private MenuStrip searchMenuStrip;
        private ToolStripMenuItem searchMS;
        private ToolStripTextBox searchBox;
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
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}