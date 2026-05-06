namespace lighPayrollUI
{
    partial class AdFeature
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            headPanel = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            bodyPanel = new Panel();
            requestsPanel = new Panel();
            requestsTabPage = new TabControl();
            leaveTabPage = new TabPage();
            statusPanel = new Panel();
            clockGrid = new DataGridView();
            label1 = new Label();
            clockInButton = new Button();
            clockInLabel = new Label();
            clockOutButton = new Button();
            panel3 = new Panel();
            clockStatusReal = new Label();
            clockStatus = new Label();
            overtimeTabPage = new TabPage();
            panel1 = new Panel();
            overtimeLoadPnl = new Panel();
            overtimeLoadBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            tabPage1 = new TabPage();
            dataGridView2 = new DataGridView();
            panel5 = new Panel();
            leaveLoadPnl = new Panel();
            leaveLoadBtn = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            comboBox4 = new ComboBox();
            label11 = new Label();
            textBox2 = new TextBox();
            panel7 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            dataGrid = new DataGridView();
            noteLabel = new Label();
            upperBodyPanel = new Panel();
            loadPanel = new Panel();
            loadButton = new Button();
            titleMessage = new Label();
            titleLabel = new Label();
            nameOrIDLabel = new Label();
            roleComboBox = new ComboBox();
            nameLabel = new Label();
            statusComboBox = new ComboBox();
            lastNameLabel = new Label();
            nameOrIDTxtBox = new TextBox();
            buttonsPanel = new Panel();
            modifyRowButton = new Button();
            deleteUserButton = new Button();
            addUserButton = new Button();
            searchUserButton = new Button();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bodyPanel.SuspendLayout();
            requestsPanel.SuspendLayout();
            requestsTabPage.SuspendLayout();
            leaveTabPage.SuspendLayout();
            statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clockGrid).BeginInit();
            panel3.SuspendLayout();
            overtimeTabPage.SuspendLayout();
            panel1.SuspendLayout();
            overtimeLoadPnl.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            leaveLoadPnl.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            upperBodyPanel.SuspendLayout();
            loadPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(pictureBox2);
            headPanel.Controls.Add(pictureBox1);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.RightToLeft = RightToLeft.No;
            headPanel.Size = new Size(937, 109);
            headPanel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(754, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.smart_idea;
            pictureBox1.Location = new Point(3, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // bodyPanel
            // 
            bodyPanel.AutoScroll = true;
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(requestsPanel);
            bodyPanel.Controls.Add(dataGrid);
            bodyPanel.Controls.Add(noteLabel);
            bodyPanel.Controls.Add(upperBodyPanel);
            bodyPanel.Location = new Point(0, 115);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(937, 495);
            bodyPanel.TabIndex = 4;
            // 
            // requestsPanel
            // 
            requestsPanel.BorderStyle = BorderStyle.FixedSingle;
            requestsPanel.Controls.Add(requestsTabPage);
            requestsPanel.Dock = DockStyle.Bottom;
            requestsPanel.Location = new Point(0, 430);
            requestsPanel.Name = "requestsPanel";
            requestsPanel.Size = new Size(920, 496);
            requestsPanel.TabIndex = 36;
            // 
            // requestsTabPage
            // 
            requestsTabPage.Controls.Add(leaveTabPage);
            requestsTabPage.Controls.Add(overtimeTabPage);
            requestsTabPage.Controls.Add(tabPage1);
            requestsTabPage.DrawMode = TabDrawMode.OwnerDrawFixed;
            requestsTabPage.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestsTabPage.Location = new Point(2, 3);
            requestsTabPage.Name = "requestsTabPage";
            requestsTabPage.SelectedIndex = 0;
            requestsTabPage.Size = new Size(913, 496);
            requestsTabPage.TabIndex = 4;
            requestsTabPage.DrawItem += otherFeatures_DrawItem;
            // 
            // leaveTabPage
            // 
            leaveTabPage.BackColor = Color.FromArgb(33, 44, 66);
            leaveTabPage.Controls.Add(statusPanel);
            leaveTabPage.Location = new Point(4, 26);
            leaveTabPage.Name = "leaveTabPage";
            leaveTabPage.Padding = new Padding(3);
            leaveTabPage.Size = new Size(905, 466);
            leaveTabPage.TabIndex = 0;
            leaveTabPage.Text = "Clock In / Out";
            // 
            // statusPanel
            // 
            statusPanel.BackColor = Color.FromArgb(60, 80, 110);
            statusPanel.Controls.Add(clockGrid);
            statusPanel.Controls.Add(label1);
            statusPanel.Controls.Add(clockInButton);
            statusPanel.Controls.Add(clockInLabel);
            statusPanel.Controls.Add(clockOutButton);
            statusPanel.Controls.Add(panel3);
            statusPanel.Location = new Point(67, 48);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(789, 309);
            statusPanel.TabIndex = 1;
            // 
            // clockGrid
            // 
            clockGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clockGrid.BorderStyle = BorderStyle.None;
            clockGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(33, 44, 66);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            clockGrid.DefaultCellStyle = dataGridViewCellStyle11;
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
            label1.Size = new Size(64, 17);
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
            clockInButton.UseVisualStyleBackColor = true;
            // 
            // clockInLabel
            // 
            clockInLabel.AutoSize = true;
            clockInLabel.ForeColor = Color.Beige;
            clockInLabel.Location = new Point(483, 85);
            clockInLabel.Name = "clockInLabel";
            clockInLabel.Size = new Size(53, 17);
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
            // overtimeTabPage
            // 
            overtimeTabPage.BackColor = Color.FromArgb(33, 44, 66);
            overtimeTabPage.Controls.Add(panel1);
            overtimeTabPage.Controls.Add(dataGridView1);
            overtimeTabPage.Location = new Point(4, 26);
            overtimeTabPage.Name = "overtimeTabPage";
            overtimeTabPage.Padding = new Padding(3);
            overtimeTabPage.Size = new Size(905, 466);
            overtimeTabPage.TabIndex = 1;
            overtimeTabPage.Text = "Overtime";
            // 
            // panel1
            // 
            panel1.Controls.Add(overtimeLoadPnl);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 145);
            panel1.TabIndex = 39;
            // 
            // overtimeLoadPnl
            // 
            overtimeLoadPnl.Controls.Add(overtimeLoadBtn);
            overtimeLoadPnl.Location = new Point(96, 92);
            overtimeLoadPnl.Name = "overtimeLoadPnl";
            overtimeLoadPnl.Size = new Size(186, 34);
            overtimeLoadPnl.TabIndex = 35;
            // 
            // overtimeLoadBtn
            // 
            overtimeLoadBtn.BackColor = Color.Beige;
            overtimeLoadBtn.BackgroundImageLayout = ImageLayout.Stretch;
            overtimeLoadBtn.Dock = DockStyle.Fill;
            overtimeLoadBtn.FlatStyle = FlatStyle.Flat;
            overtimeLoadBtn.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            overtimeLoadBtn.ForeColor = Color.FromArgb(33, 44, 66);
            overtimeLoadBtn.Location = new Point(0, 0);
            overtimeLoadBtn.Name = "overtimeLoadBtn";
            overtimeLoadBtn.Size = new Size(186, 34);
            overtimeLoadBtn.TabIndex = 26;
            overtimeLoadBtn.Text = "Load";
            overtimeLoadBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 44, 66);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(36, 41);
            label2.Name = "label2";
            label2.Size = new Size(208, 17);
            label2.TabIndex = 22;
            label2.Text = "Trust, but always verify!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 44, 66);
            label3.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(32, 14);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 21;
            label3.Text = "Overtime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(33, 44, 66);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(605, 22);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 30;
            label4.Text = "Username or ID:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Accountant", "Employee", "Manager", "Admin" });
            comboBox1.Location = new Point(744, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 25);
            comboBox1.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(33, 44, 66);
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Beige;
            label5.Location = new Point(669, 49);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 29;
            label5.Text = "Status:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Active", "Pending", "Rejected" });
            comboBox2.Location = new Point(744, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 25);
            comboBox2.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(33, 44, 66);
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Beige;
            label6.Location = new Point(685, 76);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 32;
            label6.Text = "Role:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(744, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 27;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Location = new Point(562, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(320, 34);
            panel4.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 44, 66);
            button2.BackgroundImage = Properties.Resources.modify;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(33, 44, 66);
            button2.Location = new Point(248, 7);
            button2.Name = "button2";
            button2.Size = new Size(43, 25);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(33, 44, 66);
            button3.BackgroundImage = Properties.Resources.minus;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(33, 44, 66);
            button3.Location = new Point(187, 7);
            button3.Name = "button3";
            button3.Size = new Size(43, 25);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(33, 44, 66);
            button4.BackgroundImage = Properties.Resources.plus;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(33, 44, 66);
            button4.Location = new Point(128, 7);
            button4.Name = "button4";
            button4.Size = new Size(43, 25);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.FromArgb(33, 44, 66);
            button5.BackgroundImage = Properties.Resources.search;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(33, 44, 66);
            button5.Location = new Point(66, 7);
            button5.Name = "button5";
            button5.Size = new Size(43, 25);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle12.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.Location = new Point(89, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(758, 224);
            dataGridView1.TabIndex = 24;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(33, 44, 66);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(panel5);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(905, 466);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Leave";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle15.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridView2.Location = new Point(89, 154);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.Size = new Size(758, 224);
            dataGridView2.TabIndex = 41;
            // 
            // panel5
            // 
            panel5.Controls.Add(leaveLoadPnl);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(comboBox4);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(899, 145);
            panel5.TabIndex = 40;
            // 
            // leaveLoadPnl
            // 
            leaveLoadPnl.Controls.Add(leaveLoadBtn);
            leaveLoadPnl.Location = new Point(96, 92);
            leaveLoadPnl.Name = "leaveLoadPnl";
            leaveLoadPnl.Size = new Size(186, 34);
            leaveLoadPnl.TabIndex = 35;
            // 
            // leaveLoadBtn
            // 
            leaveLoadBtn.BackColor = Color.Beige;
            leaveLoadBtn.BackgroundImageLayout = ImageLayout.Stretch;
            leaveLoadBtn.Dock = DockStyle.Fill;
            leaveLoadBtn.FlatStyle = FlatStyle.Flat;
            leaveLoadBtn.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leaveLoadBtn.ForeColor = Color.FromArgb(33, 44, 66);
            leaveLoadBtn.Location = new Point(0, 0);
            leaveLoadBtn.Name = "leaveLoadBtn";
            leaveLoadBtn.Size = new Size(186, 34);
            leaveLoadBtn.TabIndex = 26;
            leaveLoadBtn.Text = "Load";
            leaveLoadBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(33, 44, 66);
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Beige;
            label7.Location = new Point(36, 41);
            label7.Name = "label7";
            label7.Size = new Size(208, 17);
            label7.TabIndex = 22;
            label7.Text = "Trust, but always verify!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(33, 44, 66);
            label8.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Beige;
            label8.Location = new Point(32, 14);
            label8.Name = "label8";
            label8.Size = new Size(72, 27);
            label8.TabIndex = 21;
            label8.Text = "Leave";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(33, 44, 66);
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Beige;
            label9.Location = new Point(605, 22);
            label9.Name = "label9";
            label9.Size = new Size(128, 17);
            label9.TabIndex = 30;
            label9.Text = "Username or ID:";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Accountant", "Employee", "Manager", "Admin" });
            comboBox3.Location = new Point(744, 73);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 25);
            comboBox3.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(33, 44, 66);
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Beige;
            label10.Location = new Point(669, 49);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 29;
            label10.Text = "Status:";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Active", "Pending", "Rejected" });
            comboBox4.Location = new Point(744, 45);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(100, 25);
            comboBox4.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(33, 44, 66);
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Beige;
            label11.Location = new Point(685, 76);
            label11.Name = "label11";
            label11.Size = new Size(48, 17);
            label11.TabIndex = 32;
            label11.Text = "Role:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(744, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 27;
            // 
            // panel7
            // 
            panel7.Controls.Add(button7);
            panel7.Controls.Add(button8);
            panel7.Controls.Add(button9);
            panel7.Controls.Add(button10);
            panel7.Location = new Point(562, 104);
            panel7.Name = "panel7";
            panel7.Size = new Size(320, 34);
            panel7.TabIndex = 24;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(33, 44, 66);
            button7.BackgroundImage = Properties.Resources.modify;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.FromArgb(33, 44, 66);
            button7.Location = new Point(248, 7);
            button7.Name = "button7";
            button7.Size = new Size(43, 25);
            button7.TabIndex = 2;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(33, 44, 66);
            button8.BackgroundImage = Properties.Resources.minus;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.FromArgb(33, 44, 66);
            button8.Location = new Point(187, 7);
            button8.Name = "button8";
            button8.Size = new Size(43, 25);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(33, 44, 66);
            button9.BackgroundImage = Properties.Resources.plus;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.FromArgb(33, 44, 66);
            button9.Location = new Point(128, 7);
            button9.Name = "button9";
            button9.Size = new Size(43, 25);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button10.BackColor = Color.FromArgb(33, 44, 66);
            button10.BackgroundImage = Properties.Resources.search;
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.Cursor = Cursors.Hand;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.FromArgb(33, 44, 66);
            button10.Location = new Point(66, 7);
            button10.Name = "button10";
            button10.Size = new Size(43, 25);
            button10.TabIndex = 3;
            button10.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle18.Font = new Font("Ubuntu Mono Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Window;
            dataGridViewCellStyle19.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(68, 68, 68);
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle19.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle19;
            dataGrid.Location = new Point(96, 167);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(60, 80, 100);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 40;
            dataGrid.Size = new Size(758, 243);
            dataGrid.TabIndex = 23;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.BackColor = Color.FromArgb(33, 44, 66);
            noteLabel.Cursor = Cursors.Hand;
            noteLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteLabel.ForeColor = Color.Beige;
            noteLabel.Location = new Point(292, 413);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(400, 17);
            noteLabel.TabIndex = 25;
            noteLabel.Text = "                                                 ";
            // 
            // upperBodyPanel
            // 
            upperBodyPanel.Controls.Add(loadPanel);
            upperBodyPanel.Controls.Add(titleMessage);
            upperBodyPanel.Controls.Add(titleLabel);
            upperBodyPanel.Controls.Add(nameOrIDLabel);
            upperBodyPanel.Controls.Add(roleComboBox);
            upperBodyPanel.Controls.Add(nameLabel);
            upperBodyPanel.Controls.Add(statusComboBox);
            upperBodyPanel.Controls.Add(lastNameLabel);
            upperBodyPanel.Controls.Add(nameOrIDTxtBox);
            upperBodyPanel.Controls.Add(buttonsPanel);
            upperBodyPanel.Dock = DockStyle.Top;
            upperBodyPanel.Location = new Point(0, 0);
            upperBodyPanel.Name = "upperBodyPanel";
            upperBodyPanel.Size = new Size(920, 161);
            upperBodyPanel.TabIndex = 38;
            upperBodyPanel.Visible = false;
            // 
            // loadPanel
            // 
            loadPanel.Controls.Add(loadButton);
            loadPanel.Location = new Point(96, 120);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new Size(186, 34);
            loadPanel.TabIndex = 35;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.Beige;
            loadButton.BackgroundImageLayout = ImageLayout.Stretch;
            loadButton.Dock = DockStyle.Fill;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadButton.ForeColor = Color.FromArgb(33, 44, 66);
            loadButton.Location = new Point(0, 0);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(186, 34);
            loadButton.TabIndex = 26;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // titleMessage
            // 
            titleMessage.AutoSize = true;
            titleMessage.BackColor = Color.FromArgb(33, 44, 66);
            titleMessage.Cursor = Cursors.Hand;
            titleMessage.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleMessage.ForeColor = Color.Beige;
            titleMessage.Location = new Point(42, 74);
            titleMessage.Name = "titleMessage";
            titleMessage.Size = new Size(208, 17);
            titleMessage.TabIndex = 22;
            titleMessage.Text = "Trust, but always verify!";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.FromArgb(33, 44, 66);
            titleLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.Beige;
            titleLabel.Location = new Point(38, 39);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(216, 27);
            titleLabel.TabIndex = 21;
            titleLabel.Text = "User Modification";
            // 
            // nameOrIDLabel
            // 
            nameOrIDLabel.AutoSize = true;
            nameOrIDLabel.BackColor = Color.FromArgb(33, 44, 66);
            nameOrIDLabel.Cursor = Cursors.Hand;
            nameOrIDLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameOrIDLabel.ForeColor = Color.Beige;
            nameOrIDLabel.Location = new Point(615, 38);
            nameOrIDLabel.Name = "nameOrIDLabel";
            nameOrIDLabel.Size = new Size(128, 17);
            nameOrIDLabel.TabIndex = 30;
            nameOrIDLabel.Text = "Username or ID:";
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Accountant", "Employee", "Manager", "Admin" });
            roleComboBox.Location = new Point(754, 89);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(100, 25);
            roleComboBox.TabIndex = 34;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.FromArgb(33, 44, 66);
            nameLabel.Cursor = Cursors.Hand;
            nameLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.Beige;
            nameLabel.Location = new Point(679, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(64, 17);
            nameLabel.TabIndex = 29;
            nameLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Active", "Pending", "Rejected" });
            statusComboBox.Location = new Point(754, 61);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(100, 25);
            statusComboBox.TabIndex = 33;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.FromArgb(33, 44, 66);
            lastNameLabel.Cursor = Cursors.Hand;
            lastNameLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.Beige;
            lastNameLabel.Location = new Point(695, 92);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(48, 17);
            lastNameLabel.TabIndex = 32;
            lastNameLabel.Text = "Role:";
            // 
            // nameOrIDTxtBox
            // 
            nameOrIDTxtBox.Location = new Point(754, 32);
            nameOrIDTxtBox.Name = "nameOrIDTxtBox";
            nameOrIDTxtBox.Size = new Size(100, 25);
            nameOrIDTxtBox.TabIndex = 27;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(modifyRowButton);
            buttonsPanel.Controls.Add(deleteUserButton);
            buttonsPanel.Controls.Add(addUserButton);
            buttonsPanel.Controls.Add(searchUserButton);
            buttonsPanel.Location = new Point(572, 120);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(320, 34);
            buttonsPanel.TabIndex = 24;
            // 
            // modifyRowButton
            // 
            modifyRowButton.BackColor = Color.FromArgb(33, 44, 66);
            modifyRowButton.BackgroundImage = Properties.Resources.modify;
            modifyRowButton.BackgroundImageLayout = ImageLayout.Stretch;
            modifyRowButton.Cursor = Cursors.Hand;
            modifyRowButton.FlatStyle = FlatStyle.Flat;
            modifyRowButton.ForeColor = Color.FromArgb(33, 44, 66);
            modifyRowButton.Location = new Point(248, 7);
            modifyRowButton.Name = "modifyRowButton";
            modifyRowButton.Size = new Size(43, 25);
            modifyRowButton.TabIndex = 2;
            modifyRowButton.UseVisualStyleBackColor = false;
            modifyRowButton.Click += modifyRowButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackColor = Color.FromArgb(33, 44, 66);
            deleteUserButton.BackgroundImage = Properties.Resources.minus;
            deleteUserButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteUserButton.Cursor = Cursors.Hand;
            deleteUserButton.FlatStyle = FlatStyle.Flat;
            deleteUserButton.ForeColor = Color.FromArgb(33, 44, 66);
            deleteUserButton.Location = new Point(187, 7);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(43, 25);
            deleteUserButton.TabIndex = 1;
            deleteUserButton.UseVisualStyleBackColor = false;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.FromArgb(33, 44, 66);
            addUserButton.BackgroundImage = Properties.Resources.plus;
            addUserButton.BackgroundImageLayout = ImageLayout.Stretch;
            addUserButton.Cursor = Cursors.Hand;
            addUserButton.FlatStyle = FlatStyle.Flat;
            addUserButton.ForeColor = Color.FromArgb(33, 44, 66);
            addUserButton.Location = new Point(128, 7);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(43, 25);
            addUserButton.TabIndex = 0;
            addUserButton.UseVisualStyleBackColor = false;
            // 
            // searchUserButton
            // 
            searchUserButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchUserButton.BackColor = Color.FromArgb(33, 44, 66);
            searchUserButton.BackgroundImage = Properties.Resources.search;
            searchUserButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchUserButton.Cursor = Cursors.Hand;
            searchUserButton.FlatStyle = FlatStyle.Flat;
            searchUserButton.ForeColor = Color.FromArgb(33, 44, 66);
            searchUserButton.Location = new Point(66, 7);
            searchUserButton.Name = "searchUserButton";
            searchUserButton.Size = new Size(43, 25);
            searchUserButton.TabIndex = 3;
            searchUserButton.UseVisualStyleBackColor = false;
            searchUserButton.Click += searchUserButton_Click;
            // 
            // AdFeature
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(937, 548);
            Controls.Add(bodyPanel);
            Controls.Add(headPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdFeature";
            StartPosition = FormStartPosition.CenterScreen;
            Load += UsersUI_Load;
            Shown += AdFeature_Shown;
            headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            requestsPanel.ResumeLayout(false);
            requestsTabPage.ResumeLayout(false);
            leaveTabPage.ResumeLayout(false);
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clockGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            overtimeTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            overtimeLoadPnl.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            leaveLoadPnl.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            upperBodyPanel.ResumeLayout(false);
            upperBodyPanel.PerformLayout();
            loadPanel.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headPanel;
        private PictureBox pictureBox1;
        private Panel bodyPanel;
        private Label lastNameLabel;
        private Panel buttonsPanel;
        private Button modifyRowButton;
        private Button deleteUserButton;
        private Button addUserButton;
        private Label titleLabel;
        private Label nameOrIDLabel;
        private Label titleMessage;
        private Label nameLabel;
        private DataGridView dataGrid;
        private TextBox nameOrIDTxtBox;
        private Button loadButton;
        private ComboBox roleComboBox;
        private ComboBox statusComboBox;
        private Button searchUserButton;
        private PictureBox pictureBox2;
        private Panel loadPanel;
        private Panel requestsPanel;
        private Label noteLabel;
        private Panel upperBodyPanel;
        private TabControl requestsTabPage;
        private TabPage leaveTabPage;
        private TabPage overtimeTabPage;
        private TabPage tabPage1;
        private Panel statusPanel;
        private DataGridView clockGrid;
        private Label label1;
        private Button clockInButton;
        private Label clockInLabel;
        private Button clockOutButton;
        private Panel panel3;
        private Label clockStatusReal;
        private Label clockStatus;
        private Panel panel1;
        private Panel overtimeLoadPnl;
        private Button overtimeLoadBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBox1;
        private Panel panel4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Panel leaveLoadPnl;
        private Button leaveLoadBtn;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox3;
        private Label label10;
        private ComboBox comboBox4;
        private Label label11;
        private TextBox textBox2;
        private Panel panel7;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private DataGridView dataGridView2;
    }
}