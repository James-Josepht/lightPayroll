namespace lighPayrollUI
{
    partial class EFeatures
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            employeeFeatures = new TabControl();
            clockPage = new TabPage();
            panel2 = new Panel();
            statusPanel = new Panel();
            clockGrid = new DataGridView();
            label1 = new Label();
            clockInButton = new Button();
            clockInLabel = new Label();
            clockOutButton = new Button();
            panel3 = new Panel();
            clockStatusReal = new Label();
            clockStatus = new Label();
            payslipPage = new TabPage();
            payslipPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            payslipInnerPanel = new Panel();
            headPayslipPanel = new Panel();
            payslipSmallLbl = new Label();
            companyPayslip = new Label();
            payslipBodyPanel = new Panel();
            paySlipRecords = new DataGridView();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            attendancePage = new TabPage();
            attendanceGrid = new DataGridView();
            attendanceSearchPnl = new Panel();
            attendanceSearch = new TextBox();
            searchAttendancePic = new PictureBox();
            attendancePanel = new Panel();
            attendanceNoteLbl = new Label();
            payrollPage = new TabPage();
            payrollGrid = new DataGridView();
            payrollSearchPanel = new Panel();
            searchBox = new TextBox();
            pictureBox1 = new PictureBox();
            payrollPanel = new Panel();
            notePayrollL = new Label();
            modifyPayrollB = new Button();
            requestPage = new TabPage();
            profilePage = new TabPage();
            profilePanel = new Panel();
            profileTableLayout = new TableLayoutPanel();
            insideProfile = new Panel();
            email = new Label();
            salaryRate = new Label();
            role = new Label();
            middleName = new Label();
            firstName = new Label();
            lastName = new Label();
            userID = new Label();
            emailLbl = new Label();
            modifyProfile = new Button();
            salaryRateLabel = new Label();
            employeeIDL = new Label();
            roleL = new Label();
            finalNameLabel = new Label();
            middleNameLabel = new Label();
            firstNameLabel = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            profileNote = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            employeeFeatures.SuspendLayout();
            clockPage.SuspendLayout();
            panel2.SuspendLayout();
            statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clockGrid).BeginInit();
            panel3.SuspendLayout();
            payslipPage.SuspendLayout();
            payslipPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            payslipInnerPanel.SuspendLayout();
            headPayslipPanel.SuspendLayout();
            payslipBodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paySlipRecords).BeginInit();
            attendancePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).BeginInit();
            attendanceSearchPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchAttendancePic).BeginInit();
            attendancePanel.SuspendLayout();
            payrollPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payrollGrid).BeginInit();
            payrollSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            payrollPanel.SuspendLayout();
            profilePage.SuspendLayout();
            profilePanel.SuspendLayout();
            profileTableLayout.SuspendLayout();
            insideProfile.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 109);
            panel1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.smart_idea;
            pictureBox2.Location = new Point(350, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(236, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += HomeUser_Click;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9781017F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.0219F));
            tableLayoutPanel1.Size = new Size(937, 548);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // employeeFeatures
            // 
            employeeFeatures.Controls.Add(clockPage);
            employeeFeatures.Controls.Add(payslipPage);
            employeeFeatures.Controls.Add(attendancePage);
            employeeFeatures.Controls.Add(payrollPage);
            employeeFeatures.Controls.Add(requestPage);
            employeeFeatures.Controls.Add(profilePage);
            employeeFeatures.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeFeatures.Location = new Point(3, 107);
            employeeFeatures.Name = "employeeFeatures";
            employeeFeatures.SelectedIndex = 0;
            employeeFeatures.Size = new Size(931, 438);
            employeeFeatures.TabIndex = 26;
            employeeFeatures.DrawItem += tabControl1_DrawItem;
            // 
            // clockPage
            // 
            clockPage.AutoScroll = true;
            clockPage.BackColor = SystemColors.ActiveCaption;
            clockPage.Controls.Add(panel2);
            clockPage.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockPage.ForeColor = Color.FromArgb(33, 44, 66);
            clockPage.Location = new Point(4, 25);
            clockPage.Name = "clockPage";
            clockPage.Padding = new Padding(3);
            clockPage.Size = new Size(923, 409);
            clockPage.TabIndex = 0;
            clockPage.Text = "Clock In / Out";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(statusPanel);
            panel2.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(28, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(872, 360);
            panel2.TabIndex = 0;
            // 
            // statusPanel
            // 
            statusPanel.BackColor = Color.FromArgb(33, 44, 66);
            statusPanel.Controls.Add(clockGrid);
            statusPanel.Controls.Add(label1);
            statusPanel.Controls.Add(clockInButton);
            statusPanel.Controls.Add(clockInLabel);
            statusPanel.Controls.Add(clockOutButton);
            statusPanel.Controls.Add(panel3);
            statusPanel.Location = new Point(42, 39);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(789, 309);
            statusPanel.TabIndex = 0;
            // 
            // clockGrid
            // 
            clockGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clockGrid.BorderStyle = BorderStyle.None;
            clockGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 44, 66);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            clockGrid.DefaultCellStyle = dataGridViewCellStyle1;
            clockGrid.GridColor = SystemColors.ActiveBorder;
            clockGrid.Location = new Point(43, 137);
            clockGrid.Name = "clockGrid";
            clockGrid.ReadOnly = true;
            clockGrid.Size = new Size(705, 135);
            clockGrid.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(658, 85);
            label1.Name = "label1";
            label1.Size = new Size(70, 16);
            label1.TabIndex = 4;
            label1.Text = "Clock Out";
            // 
            // clockInButton
            // 
            clockInButton.BackgroundImage = Properties.Resources.clock_in;
            clockInButton.BackgroundImageLayout = ImageLayout.Zoom;
            clockInButton.Cursor = Cursors.Hand;
            clockInButton.Location = new Point(457, 16);
            clockInButton.Name = "clockInButton";
            clockInButton.Size = new Size(110, 66);
            clockInButton.TabIndex = 1;
            clockInButton.Text = "n";
            clockInButton.UseVisualStyleBackColor = true;
            clockInButton.Click += clockInButton_Click;
            // 
            // clockInLabel
            // 
            clockInLabel.AutoSize = true;
            clockInLabel.ForeColor = Color.Beige;
            clockInLabel.Location = new Point(483, 85);
            clockInLabel.Name = "clockInLabel";
            clockInLabel.Size = new Size(63, 16);
            clockInLabel.TabIndex = 3;
            clockInLabel.Text = "Clock In";
            // 
            // clockOutButton
            // 
            clockOutButton.BackgroundImage = Properties.Resources.clock_out;
            clockOutButton.BackgroundImageLayout = ImageLayout.Zoom;
            clockOutButton.Cursor = Cursors.Hand;
            clockOutButton.Location = new Point(638, 16);
            clockOutButton.Name = "clockOutButton";
            clockOutButton.Size = new Size(110, 66);
            clockOutButton.TabIndex = 2;
            clockOutButton.UseVisualStyleBackColor = true;
            clockOutButton.Click += clockOutButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(clockStatusReal);
            panel3.Controls.Add(clockStatus);
            panel3.Location = new Point(40, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 65);
            panel3.TabIndex = 7;
            // 
            // clockStatusReal
            // 
            clockStatusReal.AutoSize = true;
            clockStatusReal.Font = new Font("Ubuntu Mono", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockStatusReal.ForeColor = Color.FromArgb(255, 255, 128);
            clockStatusReal.Location = new Point(136, 15);
            clockStatusReal.Name = "clockStatusReal";
            clockStatusReal.Size = new Size(120, 34);
            clockStatusReal.TabIndex = 6;
            clockStatusReal.Text = "Pending";
            // 
            // clockStatus
            // 
            clockStatus.AutoSize = true;
            clockStatus.Font = new Font("Ubuntu Mono", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockStatus.ForeColor = Color.Beige;
            clockStatus.Location = new Point(3, 13);
            clockStatus.Name = "clockStatus";
            clockStatus.Size = new Size(127, 36);
            clockStatus.TabIndex = 5;
            clockStatus.Text = "Status:";
            // 
            // payslipPage
            // 
            payslipPage.BackColor = SystemColors.ActiveCaption;
            payslipPage.Controls.Add(payslipPanel);
            payslipPage.Location = new Point(4, 25);
            payslipPage.Name = "payslipPage";
            payslipPage.Padding = new Padding(3);
            payslipPage.Size = new Size(923, 409);
            payslipPage.TabIndex = 1;
            payslipPage.Text = "Payslip";
            // 
            // payslipPanel
            // 
            payslipPanel.BackColor = Color.FromArgb(33, 44, 66);
            payslipPanel.Controls.Add(tableLayoutPanel2);
            payslipPanel.Location = new Point(23, 21);
            payslipPanel.Name = "payslipPanel";
            payslipPanel.Size = new Size(876, 367);
            payslipPanel.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.41516256F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.58484F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.Controls.Add(payslipInnerPanel, 1, 1);
            tableLayoutPanel2.Controls.Add(panel9, 2, 1);
            tableLayoutPanel2.Controls.Add(panel10, 0, 1);
            tableLayoutPanel2.Controls.Add(panel11, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.05952358F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 94.9404755F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(876, 367);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // payslipInnerPanel
            // 
            payslipInnerPanel.AutoScroll = true;
            payslipInnerPanel.BackColor = Color.FromArgb(33, 44, 66);
            payslipInnerPanel.Controls.Add(headPayslipPanel);
            payslipInnerPanel.Controls.Add(payslipBodyPanel);
            payslipInnerPanel.Dock = DockStyle.Fill;
            payslipInnerPanel.Location = new Point(48, 20);
            payslipInnerPanel.Name = "payslipInnerPanel";
            payslipInnerPanel.Size = new Size(780, 313);
            payslipInnerPanel.TabIndex = 1;
            // 
            // headPayslipPanel
            // 
            headPayslipPanel.BackColor = Color.FromArgb(60, 80, 100);
            headPayslipPanel.Controls.Add(payslipSmallLbl);
            headPayslipPanel.Controls.Add(companyPayslip);
            headPayslipPanel.Dock = DockStyle.Top;
            headPayslipPanel.Location = new Point(0, 0);
            headPayslipPanel.Name = "headPayslipPanel";
            headPayslipPanel.Size = new Size(780, 76);
            headPayslipPanel.TabIndex = 25;
            headPayslipPanel.Paint += headPayslipPanel_Paint;
            // 
            // payslipSmallLbl
            // 
            payslipSmallLbl.AutoSize = true;
            payslipSmallLbl.ForeColor = Color.Beige;
            payslipSmallLbl.Location = new Point(354, 50);
            payslipSmallLbl.Name = "payslipSmallLbl";
            payslipSmallLbl.Size = new Size(56, 16);
            payslipSmallLbl.TabIndex = 27;
            payslipSmallLbl.Text = "Payslip";
            // 
            // companyPayslip
            // 
            companyPayslip.AutoSize = true;
            companyPayslip.Font = new Font("Ubuntu Mono", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            companyPayslip.ForeColor = Color.Beige;
            companyPayslip.Location = new Point(254, 13);
            companyPayslip.Name = "companyPayslip";
            companyPayslip.Size = new Size(270, 34);
            companyPayslip.TabIndex = 27;
            companyPayslip.Text = "Light Payroll Inc";
            // 
            // payslipBodyPanel
            // 
            payslipBodyPanel.Controls.Add(paySlipRecords);
            payslipBodyPanel.Dock = DockStyle.Bottom;
            payslipBodyPanel.Location = new Point(0, 109);
            payslipBodyPanel.Name = "payslipBodyPanel";
            payslipBodyPanel.Size = new Size(780, 204);
            payslipBodyPanel.TabIndex = 26;
            // 
            // paySlipRecords
            // 
            paySlipRecords.AllowUserToAddRows = false;
            paySlipRecords.AllowUserToDeleteRows = false;
            paySlipRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paySlipRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            paySlipRecords.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Ubuntu Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            paySlipRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            paySlipRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            paySlipRecords.DefaultCellStyle = dataGridViewCellStyle3;
            paySlipRecords.Dock = DockStyle.Fill;
            paySlipRecords.Location = new Point(0, 0);
            paySlipRecords.Name = "paySlipRecords";
            paySlipRecords.ReadOnly = true;
            paySlipRecords.Size = new Size(780, 204);
            paySlipRecords.TabIndex = 2;
            paySlipRecords.CellClick += paySlipRecords_CellClick;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(834, 20);
            panel9.Name = "panel9";
            panel9.Size = new Size(39, 313);
            panel9.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 20);
            panel10.Name = "panel10";
            panel10.Size = new Size(39, 313);
            panel10.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(48, 339);
            panel11.Name = "panel11";
            panel11.Size = new Size(780, 25);
            panel11.TabIndex = 4;
            // 
            // attendancePage
            // 
            attendancePage.BackColor = SystemColors.ActiveCaption;
            attendancePage.Controls.Add(attendanceGrid);
            attendancePage.Controls.Add(attendanceSearchPnl);
            attendancePage.Controls.Add(attendancePanel);
            attendancePage.Location = new Point(4, 25);
            attendancePage.Name = "attendancePage";
            attendancePage.Padding = new Padding(3);
            attendancePage.Size = new Size(923, 409);
            attendancePage.TabIndex = 2;
            attendancePage.Text = "Attendance";
            // 
            // attendanceGrid
            // 
            attendanceGrid.AllowUserToAddRows = false;
            attendanceGrid.AllowUserToDeleteRows = false;
            attendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendanceGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            attendanceGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Ubuntu Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            attendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            attendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            attendanceGrid.DefaultCellStyle = dataGridViewCellStyle5;
            attendanceGrid.Location = new Point(82, 132);
            attendanceGrid.Name = "attendanceGrid";
            attendanceGrid.ReadOnly = true;
            attendanceGrid.Size = new Size(766, 221);
            attendanceGrid.TabIndex = 4;
            // 
            // attendanceSearchPnl
            // 
            attendanceSearchPnl.BackColor = Color.FromArgb(60, 80, 110);
            attendanceSearchPnl.Controls.Add(attendanceSearch);
            attendanceSearchPnl.Controls.Add(searchAttendancePic);
            attendanceSearchPnl.Location = new Point(82, 41);
            attendanceSearchPnl.Name = "attendanceSearchPnl";
            attendanceSearchPnl.Size = new Size(766, 56);
            attendanceSearchPnl.TabIndex = 3;
            // 
            // attendanceSearch
            // 
            attendanceSearch.BackColor = Color.FromArgb(60, 80, 110);
            attendanceSearch.BorderStyle = BorderStyle.None;
            attendanceSearch.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceSearch.ForeColor = Color.Beige;
            attendanceSearch.Location = new Point(59, 17);
            attendanceSearch.Name = "attendanceSearch";
            attendanceSearch.Size = new Size(687, 26);
            attendanceSearch.TabIndex = 2;
            attendanceSearch.KeyDown += attendanceSearchEnter;
            // 
            // searchAttendancePic
            // 
            searchAttendancePic.BackgroundImage = Properties.Resources.search_interface_symbol;
            searchAttendancePic.BackgroundImageLayout = ImageLayout.Zoom;
            searchAttendancePic.Location = new Point(3, 15);
            searchAttendancePic.Name = "searchAttendancePic";
            searchAttendancePic.Size = new Size(52, 30);
            searchAttendancePic.TabIndex = 1;
            searchAttendancePic.TabStop = false;
            // 
            // attendancePanel
            // 
            attendancePanel.BackColor = Color.FromArgb(33, 44, 66);
            attendancePanel.Controls.Add(attendanceNoteLbl);
            attendancePanel.Location = new Point(24, 21);
            attendancePanel.Name = "attendancePanel";
            attendancePanel.Size = new Size(876, 367);
            attendancePanel.TabIndex = 5;
            // 
            // attendanceNoteLbl
            // 
            attendanceNoteLbl.AutoSize = true;
            attendanceNoteLbl.ForeColor = Color.Beige;
            attendanceNoteLbl.Location = new Point(351, 342);
            attendanceNoteLbl.Name = "attendanceNoteLbl";
            attendanceNoteLbl.Size = new Size(161, 16);
            attendanceNoteLbl.TabIndex = 1;
            attendanceNoteLbl.Text = "NOTE: EMPLOYEE ID ONLY";
            // 
            // payrollPage
            // 
            payrollPage.BackColor = SystemColors.ActiveCaption;
            payrollPage.Controls.Add(payrollGrid);
            payrollPage.Controls.Add(payrollSearchPanel);
            payrollPage.Controls.Add(payrollPanel);
            payrollPage.Location = new Point(4, 25);
            payrollPage.Name = "payrollPage";
            payrollPage.Padding = new Padding(3);
            payrollPage.Size = new Size(923, 409);
            payrollPage.TabIndex = 3;
            payrollPage.Text = "Payroll";
            // 
            // payrollGrid
            // 
            payrollGrid.AllowUserToAddRows = false;
            payrollGrid.AllowUserToDeleteRows = false;
            payrollGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            payrollGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            payrollGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Ubuntu Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            payrollGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            payrollGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            payrollGrid.DefaultCellStyle = dataGridViewCellStyle7;
            payrollGrid.Location = new Point(83, 132);
            payrollGrid.Name = "payrollGrid";
            payrollGrid.ReadOnly = true;
            payrollGrid.Size = new Size(766, 221);
            payrollGrid.TabIndex = 1;
            payrollGrid.CellClick += payrollGrid_CellClick;
            // 
            // payrollSearchPanel
            // 
            payrollSearchPanel.BackColor = Color.FromArgb(60, 80, 110);
            payrollSearchPanel.Controls.Add(searchBox);
            payrollSearchPanel.Controls.Add(pictureBox1);
            payrollSearchPanel.Location = new Point(83, 41);
            payrollSearchPanel.Name = "payrollSearchPanel";
            payrollSearchPanel.Size = new Size(496, 56);
            payrollSearchPanel.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(60, 80, 110);
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.Beige;
            searchBox.Location = new Point(59, 17);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(419, 26);
            searchBox.TabIndex = 2;
            searchBox.KeyDown += searchEnterPayroll;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.search_interface_symbol;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 30);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // payrollPanel
            // 
            payrollPanel.BackColor = Color.FromArgb(33, 44, 66);
            payrollPanel.Controls.Add(notePayrollL);
            payrollPanel.Controls.Add(modifyPayrollB);
            payrollPanel.Location = new Point(24, 21);
            payrollPanel.Name = "payrollPanel";
            payrollPanel.Size = new Size(876, 367);
            payrollPanel.TabIndex = 2;
            // 
            // notePayrollL
            // 
            notePayrollL.AutoSize = true;
            notePayrollL.ForeColor = Color.Beige;
            notePayrollL.Location = new Point(256, 342);
            notePayrollL.Name = "notePayrollL";
            notePayrollL.Size = new Size(364, 16);
            notePayrollL.TabIndex = 1;
            notePayrollL.Text = "NOTE: SEARCH NAME THEN EMPLOYEE ID FOR MODIFICATION";
            // 
            // modifyPayrollB
            // 
            modifyPayrollB.BackgroundImage = Properties.Resources.modify;
            modifyPayrollB.BackgroundImageLayout = ImageLayout.Zoom;
            modifyPayrollB.Cursor = Cursors.Hand;
            modifyPayrollB.FlatAppearance.BorderColor = Color.FromArgb(33, 44, 66);
            modifyPayrollB.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 44, 66);
            modifyPayrollB.FlatStyle = FlatStyle.Flat;
            modifyPayrollB.Location = new Point(760, 20);
            modifyPayrollB.Name = "modifyPayrollB";
            modifyPayrollB.Size = new Size(75, 56);
            modifyPayrollB.TabIndex = 0;
            modifyPayrollB.UseVisualStyleBackColor = true;
            modifyPayrollB.Click += modifyPayrollB_Click;
            // 
            // requestPage
            // 
            requestPage.BackColor = Color.FromArgb(33, 44, 66);
            requestPage.Location = new Point(4, 25);
            requestPage.Name = "requestPage";
            requestPage.Padding = new Padding(3);
            requestPage.Size = new Size(923, 409);
            requestPage.TabIndex = 4;
            requestPage.Text = "Requests";
            // 
            // profilePage
            // 
            profilePage.BackColor = SystemColors.ActiveCaption;
            profilePage.Controls.Add(profilePanel);
            profilePage.Location = new Point(4, 25);
            profilePage.Name = "profilePage";
            profilePage.Padding = new Padding(3);
            profilePage.Size = new Size(923, 409);
            profilePage.TabIndex = 5;
            profilePage.Text = "Profile";
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.FromArgb(33, 44, 66);
            profilePanel.Controls.Add(profileTableLayout);
            profilePanel.Location = new Point(24, 21);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(876, 367);
            profilePanel.TabIndex = 3;
            // 
            // profileTableLayout
            // 
            profileTableLayout.ColumnCount = 3;
            profileTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.41516256F));
            profileTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.58484F));
            profileTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            profileTableLayout.Controls.Add(insideProfile, 1, 1);
            profileTableLayout.Controls.Add(panel5, 2, 1);
            profileTableLayout.Controls.Add(panel6, 0, 1);
            profileTableLayout.Controls.Add(panel4, 1, 2);
            profileTableLayout.Dock = DockStyle.Fill;
            profileTableLayout.Location = new Point(0, 0);
            profileTableLayout.Name = "profileTableLayout";
            profileTableLayout.RowCount = 3;
            profileTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1265821F));
            profileTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 89.87342F));
            profileTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            profileTableLayout.Size = new Size(876, 367);
            profileTableLayout.TabIndex = 0;
            // 
            // insideProfile
            // 
            insideProfile.BackColor = Color.FromArgb(60, 80, 110);
            insideProfile.Controls.Add(email);
            insideProfile.Controls.Add(salaryRate);
            insideProfile.Controls.Add(role);
            insideProfile.Controls.Add(middleName);
            insideProfile.Controls.Add(firstName);
            insideProfile.Controls.Add(lastName);
            insideProfile.Controls.Add(userID);
            insideProfile.Controls.Add(emailLbl);
            insideProfile.Controls.Add(modifyProfile);
            insideProfile.Controls.Add(salaryRateLabel);
            insideProfile.Controls.Add(employeeIDL);
            insideProfile.Controls.Add(roleL);
            insideProfile.Controls.Add(finalNameLabel);
            insideProfile.Controls.Add(middleNameLabel);
            insideProfile.Controls.Add(firstNameLabel);
            insideProfile.Dock = DockStyle.Fill;
            insideProfile.Location = new Point(48, 29);
            insideProfile.Name = "insideProfile";
            insideProfile.Size = new Size(780, 231);
            insideProfile.TabIndex = 1;
            // 
            // email
            // 
            email.AutoSize = true;
            email.ForeColor = Color.Beige;
            email.Location = new Point(120, 157);
            email.Name = "email";
            email.Size = new Size(14, 16);
            email.TabIndex = 14;
            email.Text = "-";
            // 
            // salaryRate
            // 
            salaryRate.AutoSize = true;
            salaryRate.ForeColor = Color.Beige;
            salaryRate.Location = new Point(120, 184);
            salaryRate.Name = "salaryRate";
            salaryRate.Size = new Size(14, 16);
            salaryRate.TabIndex = 18;
            salaryRate.Text = "-";
            // 
            // role
            // 
            role.AutoSize = true;
            role.ForeColor = Color.Beige;
            role.Location = new Point(120, 132);
            role.Name = "role";
            role.Size = new Size(14, 16);
            role.TabIndex = 17;
            role.Text = "-";
            // 
            // middleName
            // 
            middleName.AutoSize = true;
            middleName.ForeColor = Color.Beige;
            middleName.Location = new Point(120, 77);
            middleName.Name = "middleName";
            middleName.Size = new Size(14, 16);
            middleName.TabIndex = 16;
            middleName.Text = "-";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.ForeColor = Color.Beige;
            firstName.Location = new Point(120, 48);
            firstName.Name = "firstName";
            firstName.Size = new Size(14, 16);
            firstName.TabIndex = 15;
            firstName.Text = "-";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.ForeColor = Color.Beige;
            lastName.Location = new Point(120, 107);
            lastName.Name = "lastName";
            lastName.Size = new Size(14, 16);
            lastName.TabIndex = 13;
            lastName.Text = "-";
            // 
            // userID
            // 
            userID.AutoSize = true;
            userID.ForeColor = Color.Beige;
            userID.Location = new Point(120, 22);
            userID.Name = "userID";
            userID.Size = new Size(14, 16);
            userID.TabIndex = 12;
            userID.Text = "-";
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.ForeColor = Color.Beige;
            emailLbl.Location = new Point(12, 157);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(49, 16);
            emailLbl.TabIndex = 6;
            emailLbl.Text = "Email:";
            // 
            // modifyProfile
            // 
            modifyProfile.BackgroundImage = Properties.Resources.modify;
            modifyProfile.BackgroundImageLayout = ImageLayout.Zoom;
            modifyProfile.Cursor = Cursors.Hand;
            modifyProfile.FlatAppearance.BorderColor = Color.FromArgb(60, 80, 110);
            modifyProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 80, 110);
            modifyProfile.FlatStyle = FlatStyle.Flat;
            modifyProfile.Location = new Point(697, 22);
            modifyProfile.Name = "modifyProfile";
            modifyProfile.Size = new Size(75, 56);
            modifyProfile.TabIndex = 11;
            modifyProfile.UseVisualStyleBackColor = true;
            modifyProfile.Click += modifyProfile_Click;
            // 
            // salaryRateLabel
            // 
            salaryRateLabel.AutoSize = true;
            salaryRateLabel.ForeColor = Color.Beige;
            salaryRateLabel.Location = new Point(12, 184);
            salaryRateLabel.Name = "salaryRateLabel";
            salaryRateLabel.Size = new Size(91, 16);
            salaryRateLabel.TabIndex = 5;
            salaryRateLabel.Text = "Salary Rate:";
            // 
            // employeeIDL
            // 
            employeeIDL.AutoSize = true;
            employeeIDL.ForeColor = Color.Beige;
            employeeIDL.Location = new Point(12, 22);
            employeeIDL.Name = "employeeIDL";
            employeeIDL.Size = new Size(91, 16);
            employeeIDL.TabIndex = 4;
            employeeIDL.Text = "Employee ID:";
            // 
            // roleL
            // 
            roleL.AutoSize = true;
            roleL.ForeColor = Color.Beige;
            roleL.Location = new Point(12, 132);
            roleL.Name = "roleL";
            roleL.Size = new Size(42, 16);
            roleL.TabIndex = 3;
            roleL.Text = "Role:";
            // 
            // finalNameLabel
            // 
            finalNameLabel.AutoSize = true;
            finalNameLabel.ForeColor = Color.Beige;
            finalNameLabel.Location = new Point(12, 107);
            finalNameLabel.Name = "finalNameLabel";
            finalNameLabel.Size = new Size(77, 16);
            finalNameLabel.TabIndex = 2;
            finalNameLabel.Text = "Last Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.ForeColor = Color.Beige;
            middleNameLabel.Location = new Point(12, 77);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(91, 16);
            middleNameLabel.TabIndex = 1;
            middleNameLabel.Text = "Middle Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.ForeColor = Color.Beige;
            firstNameLabel.Location = new Point(12, 48);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(84, 16);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(834, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(39, 231);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 29);
            panel6.Name = "panel6";
            panel6.Size = new Size(39, 231);
            panel6.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(profileNote);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(48, 266);
            panel4.Name = "panel4";
            panel4.Size = new Size(780, 98);
            panel4.TabIndex = 4;
            // 
            // profileNote
            // 
            profileNote.AutoSize = true;
            profileNote.Font = new Font("Ubuntu Mono", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileNote.ForeColor = Color.Beige;
            profileNote.Location = new Point(12, 46);
            profileNote.Name = "profileNote";
            profileNote.Size = new Size(72, 26);
            profileNote.TabIndex = 19;
            profileNote.Text = "NOTE:";
            // 
            // EFeatures
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(937, 548);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "EFeatures";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EmployeeFeature_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            employeeFeatures.ResumeLayout(false);
            clockPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clockGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            payslipPage.ResumeLayout(false);
            payslipPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            payslipInnerPanel.ResumeLayout(false);
            headPayslipPanel.ResumeLayout(false);
            headPayslipPanel.PerformLayout();
            payslipBodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)paySlipRecords).EndInit();
            attendancePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).EndInit();
            attendanceSearchPnl.ResumeLayout(false);
            attendanceSearchPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchAttendancePic).EndInit();
            attendancePanel.ResumeLayout(false);
            attendancePanel.PerformLayout();
            payrollPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payrollGrid).EndInit();
            payrollSearchPanel.ResumeLayout(false);
            payrollSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            payrollPanel.ResumeLayout(false);
            payrollPanel.PerformLayout();
            profilePage.ResumeLayout(false);
            profilePanel.ResumeLayout(false);
            profileTableLayout.ResumeLayout(false);
            insideProfile.ResumeLayout(false);
            insideProfile.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl employeeFeatures;
        private TabPage clockPage;
        private TabPage payslipPage;
        private TabPage attendancePage;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel statusPanel;
        private Label clockStatus;
        private Label label1;
        private Button clockInButton;
        private Label clockInLabel;
        private Button clockOutButton;
        private Label clockStatusReal;
        private Panel panel3;
        private DataGridView clockGrid;
        private TabPage payrollPage;
        private TabPage requestPage;
        private TabPage profilePage;
        private Panel payrollSearchPanel;
        private PictureBox pictureBox1;
        private DataGridView payrollGrid;
        private Panel payrollPanel;
        private TextBox searchBox;
        private Button modifyPayrollB;
        private Panel profilePanel;
        private TableLayoutPanel profileTableLayout;
        private Label firstNameLabel;
        private Panel insideProfile;
        private Label finalNameLabel;
        private Label middleNameLabel;
        private Label roleL;
        private Label employeeIDL;
        private Panel panel5;
        private Label salaryRateLabel;
        private Button modifyProfile;
        private Label emailLbl;
        private Label email;
        private Label role;
        private Label middleName;
        private Label firstName;
        private Label lastName;
        private Label userID;
        private Panel panel6;
        private Label salaryRate;
        private Panel panel4;
        private Label profileNote;
        private Label notePayrollL;
        private DataGridView attendanceGrid;
        private Panel attendanceSearchPnl;
        private TextBox attendanceSearch;
        private PictureBox searchAttendancePic;
        private Panel attendancePanel;
        private Label attendanceNoteLbl;
        private Panel payslipPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel payslipInnerPanel;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel headPayslipPanel;
        private Panel payslipBodyPanel;
        private Label companyPayslip;
        private Label payslipSmallLbl;
        private DataGridView paySlipRecords;
    }
}