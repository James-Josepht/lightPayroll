namespace lighPayrollUI
{
    partial class EmployeeFeature
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            employeeFeatures = new TabControl();
            clock = new TabPage();
            panel6 = new Panel();
            insideClockPanel = new Panel();
            employeePayroll = new TabPage();
            profilePage = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            employeeFeatures.SuspendLayout();
            clock.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 100);
            panel1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.smart_idea;
            pictureBox2.Location = new Point(367, -23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel1.Controls.Add(employeeFeatures, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.3333359F));
            tableLayoutPanel1.Size = new Size(937, 548);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(3, 127);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(931, 418);
            tabControl1.TabIndex = 26;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = Color.FromArgb(33, 44, 66);
            tabPage1.Controls.Add(panel2);
            tabPage1.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.FromArgb(33, 44, 66);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(923, 389);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Clock In / Out";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(28, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(868, 414);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 44, 66);
            panel3.Location = new Point(148, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(585, 100);
            panel3.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(33, 44, 66);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(923, 389);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Payslip";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(33, 44, 66);
            tabPage3.Location = new Point(4, 25);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(923, 389);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Profile";
            // 
            // employeeFeatures
            // 
            employeeFeatures.Controls.Add(clock);
            employeeFeatures.Controls.Add(employeePayroll);
            employeeFeatures.Controls.Add(profilePage);
            employeeFeatures.DrawMode = TabDrawMode.OwnerDrawFixed;
            employeeFeatures.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeFeatures.Location = new Point(3, 3);
            employeeFeatures.Name = "employeeFeatures";
            employeeFeatures.SelectedIndex = 0;
            employeeFeatures.Size = new Size(794, 96);
            employeeFeatures.TabIndex = 25;
            // 
            // clock
            // 
            clock.AutoScroll = true;
            clock.BackColor = Color.FromArgb(33, 44, 66);
            clock.Controls.Add(panel6);
            clock.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clock.ForeColor = Color.FromArgb(33, 44, 66);
            clock.Location = new Point(4, 25);
            clock.Name = "clock";
            clock.Padding = new Padding(3);
            clock.Size = new Size(786, 67);
            clock.TabIndex = 0;
            clock.Text = "Clock In / Out";
            // 
            // panel6
            // 
            panel6.Controls.Add(insideClockPanel);
            panel6.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel6.Location = new Point(28, 27);
            panel6.Name = "panel6";
            panel6.Size = new Size(713, 356);
            panel6.TabIndex = 0;
            // 
            // insideClockPanel
            // 
            insideClockPanel.BackColor = Color.FromArgb(33, 44, 66);
            insideClockPanel.Location = new Point(52, 3);
            insideClockPanel.Name = "insideClockPanel";
            insideClockPanel.Size = new Size(585, 100);
            insideClockPanel.TabIndex = 0;
            // 
            // employeePayroll
            // 
            employeePayroll.BackColor = Color.Beige;
            employeePayroll.Location = new Point(4, 25);
            employeePayroll.Name = "employeePayroll";
            employeePayroll.Padding = new Padding(3);
            employeePayroll.Size = new Size(786, 67);
            employeePayroll.TabIndex = 1;
            employeePayroll.Text = "Payslip";
            // 
            // profilePage
            // 
            profilePage.BackColor = Color.Beige;
            profilePage.Location = new Point(4, 25);
            profilePage.Name = "profilePage";
            profilePage.Padding = new Padding(3);
            profilePage.Size = new Size(786, 67);
            profilePage.TabIndex = 2;
            profilePage.Text = "Profile";
            // 
            // EmployeeFeature
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(937, 548);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "EmployeeFeature";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EmployeeFeature_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            employeeFeatures.ResumeLayout(false);
            clock.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel2;
        private Panel panel3;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabControl employeeFeatures;
        private TabPage clock;
        private Panel panel6;
        private Panel insideClockPanel;
        private TabPage employeePayroll;
        private TabPage profilePage;
        private PictureBox pictureBox2;
    }
}