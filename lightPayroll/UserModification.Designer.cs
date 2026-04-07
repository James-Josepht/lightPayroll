namespace lighPayrollUI
{
    partial class UserModification
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
            headPanel = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            bodyPanel = new Panel();
            roleComboBox = new ComboBox();
            statusComboBox = new ComboBox();
            lastNameLabel = new Label();
            panel3 = new Panel();
            searchUserButton = new Button();
            modifyRowButton = new Button();
            deleteUserButton = new Button();
            addUserButton = new Button();
            userLabel = new Label();
            nameOrIDLabel = new Label();
            label2 = new Label();
            nameLabel = new Label();
            attendanceGrid = new DataGridView();
            noteLabel = new Label();
            nameOrIDTxtBox = new TextBox();
            loadButton = new Button();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bodyPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).BeginInit();
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
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(roleComboBox);
            bodyPanel.Controls.Add(statusComboBox);
            bodyPanel.Controls.Add(lastNameLabel);
            bodyPanel.Controls.Add(panel3);
            bodyPanel.Controls.Add(userLabel);
            bodyPanel.Controls.Add(nameOrIDLabel);
            bodyPanel.Controls.Add(label2);
            bodyPanel.Controls.Add(nameLabel);
            bodyPanel.Controls.Add(attendanceGrid);
            bodyPanel.Controls.Add(noteLabel);
            bodyPanel.Controls.Add(nameOrIDTxtBox);
            bodyPanel.Controls.Add(loadButton);
            bodyPanel.Location = new Point(0, 115);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(937, 495);
            bodyPanel.TabIndex = 4;
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
            // panel3
            // 
            panel3.Controls.Add(searchUserButton);
            panel3.Controls.Add(modifyRowButton);
            panel3.Controls.Add(deleteUserButton);
            panel3.Controls.Add(addUserButton);
            panel3.Location = new Point(572, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 34);
            panel3.TabIndex = 24;
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
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.FromArgb(33, 44, 66);
            userLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.Beige;
            userLabel.Location = new Point(38, 39);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(216, 27);
            userLabel.TabIndex = 21;
            userLabel.Text = "User Modification";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 44, 66);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(42, 74);
            label2.Name = "label2";
            label2.Size = new Size(208, 17);
            label2.TabIndex = 22;
            label2.Text = "Trust, but always verify!";
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
            // attendanceGrid
            // 
            attendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendanceGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            attendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceGrid.Location = new Point(96, 167);
            attendanceGrid.Name = "attendanceGrid";
            attendanceGrid.RowHeadersWidth = 51;
            attendanceGrid.Size = new Size(758, 210);
            attendanceGrid.TabIndex = 23;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.BackColor = Color.FromArgb(33, 44, 66);
            noteLabel.Cursor = Cursors.Hand;
            noteLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteLabel.ForeColor = Color.Beige;
            noteLabel.Location = new Point(241, 395);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(456, 17);
            noteLabel.TabIndex = 25;
            noteLabel.Text = "NOTE: ONLY SEARCH BUTTON IS REQUIRED TO BE PRESSED FIRST\r\n";
            // 
            // nameOrIDTxtBox
            // 
            nameOrIDTxtBox.Location = new Point(754, 32);
            nameOrIDTxtBox.Name = "nameOrIDTxtBox";
            nameOrIDTxtBox.Size = new Size(100, 25);
            nameOrIDTxtBox.TabIndex = 27;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.Beige;
            loadButton.BackgroundImageLayout = ImageLayout.Stretch;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadButton.ForeColor = Color.FromArgb(33, 44, 66);
            loadButton.Location = new Point(96, 120);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(186, 34);
            loadButton.TabIndex = 26;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // UserModification
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(937, 548);
            Controls.Add(bodyPanel);
            Controls.Add(headPanel);
            Name = "UserModification";
            StartPosition = FormStartPosition.CenterScreen;
            Load += UsersUI_Load;
            headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headPanel;
        private PictureBox pictureBox1;
        private Panel bodyPanel;
        private Label lastNameLabel;
        private Panel panel3;
        private Button modifyRowButton;
        private Button deleteUserButton;
        private Button addUserButton;
        private Label userLabel;
        private Label nameOrIDLabel;
        private Label label2;
        private Label nameLabel;
        private DataGridView attendanceGrid;
        private Label noteLabel;
        private TextBox nameOrIDTxtBox;
        private Button loadButton;
        private ComboBox roleComboBox;
        private ComboBox statusComboBox;
        private Button searchUserButton;
        private PictureBox pictureBox2;
    }
}