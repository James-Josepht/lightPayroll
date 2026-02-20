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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceRecords));
            toolStripMenuItem22 = new ToolStripMenuItem();
            label2 = new Label();
            bodyPanel = new Panel();
            dataGridView1 = new DataGridView();
            userIDColumn = new DataGridViewTextBoxColumn();
            userNameColumn = new DataGridViewTextBoxColumn();
            emailAccontColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            decisionColumn = new DataGridViewButtonColumn();
            taskLabel = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            toolStripMenuItem21 = new ToolStripMenuItem();
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
            panel1 = new Panel();
            bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            searchMenuStrip.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenuItem22
            // 
            toolStripMenuItem22.Name = "toolStripMenuItem22";
            toolStripMenuItem22.Size = new Size(14, 31);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 44, 66);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(41, 68);
            label2.Name = "label2";
            label2.Size = new Size(360, 21);
            label2.TabIndex = 10;
            label2.Text = "Verify and modify attedance records";
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(dataGridView1);
            bodyPanel.Controls.Add(label2);
            bodyPanel.Controls.Add(taskLabel);
            bodyPanel.Location = new Point(80, 104);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(908, 466);
            bodyPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIDColumn, userNameColumn, emailAccontColumn, dateColumn, decisionColumn });
            dataGridView1.Location = new Point(41, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(829, 247);
            dataGridView1.TabIndex = 11;
            // 
            // userIDColumn
            // 
            userIDColumn.HeaderText = "User ID";
            userIDColumn.MinimumWidth = 6;
            userIDColumn.Name = "userIDColumn";
            // 
            // userNameColumn
            // 
            userNameColumn.HeaderText = "Username";
            userNameColumn.MinimumWidth = 6;
            userNameColumn.Name = "userNameColumn";
            userNameColumn.ReadOnly = true;
            // 
            // emailAccontColumn
            // 
            emailAccontColumn.HeaderText = "Emails";
            emailAccontColumn.MinimumWidth = 6;
            emailAccontColumn.Name = "emailAccontColumn";
            emailAccontColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.MinimumWidth = 6;
            dateColumn.Name = "dateColumn";
            dateColumn.ReadOnly = true;
            // 
            // decisionColumn
            // 
            decisionColumn.HeaderText = "Decision";
            decisionColumn.MinimumWidth = 6;
            decisionColumn.Name = "decisionColumn";
            decisionColumn.ReadOnly = true;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.BackColor = Color.FromArgb(33, 44, 66);
            taskLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskLabel.ForeColor = Color.Beige;
            taskLabel.Location = new Point(37, 27);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(165, 34);
            taskLabel.TabIndex = 9;
            taskLabel.Text = "Attendance";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(83, 667);
            panel4.Name = "panel4";
            panel4.Size = new Size(895, 39);
            panel4.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(83, 576);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 68);
            panel2.TabIndex = 4;
            // 
            // toolStripMenuItem21
            // 
            toolStripMenuItem21.Name = "toolStripMenuItem21";
            toolStripMenuItem21.Size = new Size(14, 31);
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
            headPanel.TabIndex = 6;
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
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(bodyPanel);
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 587);
            panel1.TabIndex = 8;
            // 
            // AttendanceRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 645);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            Controls.Add(panel1);
            Name = "AttendanceRecords";
            StartPosition = FormStartPosition.CenterScreen;
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            searchMenuStrip.ResumeLayout(false);
            searchMenuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStripMenuItem toolStripMenuItem22;
        private Label label2;
        private Panel bodyPanel;
        private Label taskLabel;
        private Panel panel4;
        private Panel panel2;
        private ToolStripMenuItem toolStripMenuItem21;
        private Panel headPanel;
        private PictureBox pictureBox2;
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
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userIDColumn;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn emailAccontColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewButtonColumn decisionColumn;
    }
}