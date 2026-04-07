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
            employeeFeatures = new TabControl();
            clockPage = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            payslipPage = new TabPage();
            profilePage = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            employeeFeatures.SuspendLayout();
            clockPage.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(employeeFeatures, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.3333359F));
            tableLayoutPanel1.Size = new Size(937, 548);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // employeeFeatures
            // 
            employeeFeatures.Controls.Add(clockPage);
            employeeFeatures.Controls.Add(payslipPage);
            employeeFeatures.Controls.Add(profilePage);
            employeeFeatures.DrawMode = TabDrawMode.OwnerDrawFixed;
            employeeFeatures.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeFeatures.Location = new Point(3, 127);
            employeeFeatures.Name = "employeeFeatures";
            employeeFeatures.SelectedIndex = 0;
            employeeFeatures.Size = new Size(931, 418);
            employeeFeatures.TabIndex = 26;
            employeeFeatures.DrawItem += tabControl1_DrawItem;
            // 
            // clockPage
            // 
            clockPage.AutoScroll = true;
            clockPage.BackColor = Color.FromArgb(33, 44, 66);
            clockPage.Controls.Add(panel2);
            clockPage.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockPage.ForeColor = Color.FromArgb(33, 44, 66);
            clockPage.Location = new Point(4, 25);
            clockPage.Name = "clockPage";
            clockPage.Padding = new Padding(3);
            clockPage.Size = new Size(923, 389);
            clockPage.TabIndex = 0;
            clockPage.Text = "Clock In / Out";
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
            // payslipPage
            // 
            payslipPage.BackColor = Color.FromArgb(33, 44, 66);
            payslipPage.Location = new Point(4, 25);
            payslipPage.Name = "payslipPage";
            payslipPage.Padding = new Padding(3);
            payslipPage.Size = new Size(923, 389);
            payslipPage.TabIndex = 1;
            payslipPage.Text = "Payslip";
            // 
            // profilePage
            // 
            profilePage.BackColor = Color.FromArgb(33, 44, 66);
            profilePage.Location = new Point(4, 25);
            profilePage.Name = "profilePage";
            profilePage.Padding = new Padding(3);
            profilePage.Size = new Size(923, 389);
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
            employeeFeatures.ResumeLayout(false);
            clockPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl employeeFeatures;
        private TabPage clockPage;
        private Panel panel2;
        private Panel panel3;
        private TabPage payslipPage;
        private TabPage profilePage;
        private PictureBox pictureBox2;
    }
}