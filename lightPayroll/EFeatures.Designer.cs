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
            attendancePage = new TabPage();
            payrollPage = new TabPage();
            payrollGrid = new DataGridView();
            payrollSearchPanel = new Panel();
            searchBox = new TextBox();
            pictureBox1 = new PictureBox();
            payrollPanel = new Panel();
            notePayrollL = new Label();
            modifyPayrollB = new Button();
            overTimePage = new TabPage();
            profilePage = new TabPage();
            profilePanel = new Panel();
            profileTableLayout = new TableLayoutPanel();
            insideProfile = new Panel();
            department = new Label();
            salaryRate = new Label();
            role = new Label();
            middleName = new Label();
            firstName = new Label();
            lastName = new Label();
            userID = new Label();
            departmentL = new Label();
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
            employeeFeatures.Controls.Add(overTimePage);
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
            payslipPage.BackColor = Color.FromArgb(33, 44, 66);
            payslipPage.Location = new Point(4, 25);
            payslipPage.Name = "payslipPage";
            payslipPage.Padding = new Padding(3);
            payslipPage.Size = new Size(923, 409);
            payslipPage.TabIndex = 1;
            payslipPage.Text = "Payslip";
            // 
            // attendancePage
            // 
            attendancePage.BackColor = Color.FromArgb(33, 44, 66);
            attendancePage.Location = new Point(4, 25);
            attendancePage.Name = "attendancePage";
            attendancePage.Padding = new Padding(3);
            attendancePage.Size = new Size(923, 409);
            attendancePage.TabIndex = 2;
            attendancePage.Text = "Attendance";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ubuntu Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            payrollGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            payrollGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            payrollGrid.DefaultCellStyle = dataGridViewCellStyle2;
            payrollGrid.Location = new Point(83, 132);
            payrollGrid.Name = "payrollGrid";
            payrollGrid.ReadOnly = true;
            payrollGrid.Size = new Size(766, 221);
            payrollGrid.TabIndex = 1;
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
            searchBox.Size = new Size(695, 26);
            searchBox.TabIndex = 2;
            searchBox.KeyDown += searchEnter;
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
            // 
            // overTimePage
            // 
            overTimePage.BackColor = Color.FromArgb(33, 44, 66);
            overTimePage.Location = new Point(4, 25);
            overTimePage.Name = "overTimePage";
            overTimePage.Padding = new Padding(3);
            overTimePage.Size = new Size(923, 409);
            overTimePage.TabIndex = 4;
            overTimePage.Text = "Overtime";
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
            profileTableLayout.Paint += profileTableLayout_Paint;
            // 
            // insideProfile
            // 
            insideProfile.BackColor = Color.FromArgb(60, 80, 110);
            insideProfile.Controls.Add(department);
            insideProfile.Controls.Add(salaryRate);
            insideProfile.Controls.Add(role);
            insideProfile.Controls.Add(middleName);
            insideProfile.Controls.Add(firstName);
            insideProfile.Controls.Add(lastName);
            insideProfile.Controls.Add(userID);
            insideProfile.Controls.Add(departmentL);
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
            // department
            // 
            department.AutoSize = true;
            department.ForeColor = Color.Beige;
            department.Location = new Point(120, 157);
            department.Name = "department";
            department.Size = new Size(77, 16);
            department.TabIndex = 14;
            department.Text = "Department";
            // 
            // salaryRate
            // 
            salaryRate.AutoSize = true;
            salaryRate.ForeColor = Color.Beige;
            salaryRate.Location = new Point(120, 184);
            salaryRate.Name = "salaryRate";
            salaryRate.Size = new Size(84, 16);
            salaryRate.TabIndex = 18;
            salaryRate.Text = "Salary Rate";
            // 
            // role
            // 
            role.AutoSize = true;
            role.ForeColor = Color.Beige;
            role.Location = new Point(120, 132);
            role.Name = "role";
            role.Size = new Size(35, 16);
            role.TabIndex = 17;
            role.Text = "Role";
            // 
            // middleName
            // 
            middleName.AutoSize = true;
            middleName.ForeColor = Color.Beige;
            middleName.Location = new Point(120, 77);
            middleName.Name = "middleName";
            middleName.Size = new Size(84, 16);
            middleName.TabIndex = 16;
            middleName.Text = "Middle Name";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.ForeColor = Color.Beige;
            firstName.Location = new Point(120, 48);
            firstName.Name = "firstName";
            firstName.Size = new Size(77, 16);
            firstName.TabIndex = 15;
            firstName.Text = "First Name";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.ForeColor = Color.Beige;
            lastName.Location = new Point(120, 107);
            lastName.Name = "lastName";
            lastName.Size = new Size(70, 16);
            lastName.TabIndex = 13;
            lastName.Text = "Last Name";
            // 
            // userID
            // 
            userID.AutoSize = true;
            userID.ForeColor = Color.Beige;
            userID.Location = new Point(120, 22);
            userID.Name = "userID";
            userID.Size = new Size(56, 16);
            userID.TabIndex = 12;
            userID.Text = "User ID";
            // 
            // departmentL
            // 
            departmentL.AutoSize = true;
            departmentL.ForeColor = Color.Beige;
            departmentL.Location = new Point(12, 157);
            departmentL.Name = "departmentL";
            departmentL.Size = new Size(84, 16);
            departmentL.TabIndex = 6;
            departmentL.Text = "Department:";
            // 
            // modifyProfile
            // 
            modifyProfile.BackgroundImage = Properties.Resources.modify;
            modifyProfile.BackgroundImageLayout = ImageLayout.Zoom;
            modifyProfile.Cursor = Cursors.Hand;
            modifyProfile.FlatAppearance.BorderColor = Color.FromArgb(60, 80, 110);
            modifyProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 44, 66);
            modifyProfile.FlatStyle = FlatStyle.Flat;
            modifyProfile.Location = new Point(697, 22);
            modifyProfile.Name = "modifyProfile";
            modifyProfile.Size = new Size(75, 56);
            modifyProfile.TabIndex = 11;
            modifyProfile.UseVisualStyleBackColor = true;
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
        private TabPage overTimePage;
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
        private Label departmentL;
        private Label department;
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
    }
}