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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModification));
            headPanel = new Panel();
            pictureBox1 = new PictureBox();
            bodyPanel = new Panel();
            lastNameLabel = new Label();
            panel3 = new Panel();
            addUserButton = new Button();
            modifyRowButton = new Button();
            deleteRowButton = new Button();
            fNameTxtBox = new TextBox();
            userLabel = new Label();
            label4 = new Label();
            label2 = new Label();
            nameLabel = new Label();
            attendanceGrid = new DataGridView();
            nameTxtBox = new TextBox();
            label1 = new Label();
            idTxtBox = new TextBox();
            loadButton = new Button();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bodyPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(pictureBox1);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.RightToLeft = RightToLeft.No;
            headPanel.Size = new Size(937, 109);
            headPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.smart_idea;
            pictureBox1.Location = new Point(324, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(lastNameLabel);
            bodyPanel.Controls.Add(panel3);
            bodyPanel.Controls.Add(fNameTxtBox);
            bodyPanel.Controls.Add(userLabel);
            bodyPanel.Controls.Add(label4);
            bodyPanel.Controls.Add(label2);
            bodyPanel.Controls.Add(nameLabel);
            bodyPanel.Controls.Add(attendanceGrid);
            bodyPanel.Controls.Add(nameTxtBox);
            bodyPanel.Controls.Add(label1);
            bodyPanel.Controls.Add(idTxtBox);
            bodyPanel.Controls.Add(loadButton);
            bodyPanel.Location = new Point(0, 115);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(937, 495);
            bodyPanel.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.FromArgb(33, 44, 66);
            lastNameLabel.Cursor = Cursors.Hand;
            lastNameLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.Beige;
            lastNameLabel.Location = new Point(687, 92);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(48, 17);
            lastNameLabel.TabIndex = 32;
            lastNameLabel.Text = "Role:";
            // 
            // panel3
            // 
            panel3.Controls.Add(addUserButton);
            panel3.Controls.Add(modifyRowButton);
            panel3.Controls.Add(deleteRowButton);
            panel3.Location = new Point(572, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 34);
            panel3.TabIndex = 24;
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
            // fNameTxtBox
            // 
            fNameTxtBox.Location = new Point(754, 92);
            fNameTxtBox.Name = "fNameTxtBox";
            fNameTxtBox.Size = new Size(100, 25);
            fNameTxtBox.TabIndex = 31;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(33, 44, 66);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(671, 39);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 30;
            label4.Text = "User ID:";
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
            nameLabel.Location = new Point(687, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 17);
            nameLabel.TabIndex = 29;
            nameLabel.Text = "Email:";
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
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(754, 62);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(100, 25);
            nameTxtBox.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(33, 44, 66);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(369, 395);
            label1.Name = "label1";
            label1.Size = new Size(200, 17);
            label1.TabIndex = 25;
            label1.Text = "NOTE: VERIFY ID PROPERLY";
            label1.Click += label1_Click;
            // 
            // idTxtBox
            // 
            idTxtBox.Location = new Point(754, 32);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(100, 25);
            idTxtBox.TabIndex = 27;
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
        private Button addUserButton;
        private Button modifyRowButton;
        private Button deleteRowButton;
        private TextBox fNameTxtBox;
        private Label userLabel;
        private Label label4;
        private Label label2;
        private Label nameLabel;
        private DataGridView attendanceGrid;
        private TextBox nameTxtBox;
        private Label label1;
        private TextBox idTxtBox;
        private Button loadButton;
    }
}