using lighPayrollUI.Properties;

namespace lighPayroll
{
    partial class AdminDashboard
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
            delORmod = new ContextMenuStrip(components);
            panel4 = new Panel();
            headPanel = new Panel();
            pictureBox2 = new PictureBox();
            bodyPanel = new Panel();
            panel3 = new Panel();
            payrollB = new Button();
            attendanceB = new Button();
            usersB = new Button();
            taskB = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            Dashboard = new Label();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            bodyPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(pictureBox2);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(937, 101);
            headPanel.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Resources.smart_idea;
            pictureBox2.Location = new Point(10, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = SystemColors.ActiveCaption;
            bodyPanel.Controls.Add(panel3);
            bodyPanel.Dock = DockStyle.Left;
            bodyPanel.Location = new Point(0, 101);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(200, 447);
            bodyPanel.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 35, 55);
            panel3.Controls.Add(Dashboard);
            panel3.Controls.Add(payrollB);
            panel3.Controls.Add(attendanceB);
            panel3.Controls.Add(usersB);
            panel3.Controls.Add(taskB);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 426);
            panel3.TabIndex = 0;
            // 
            // payrollB
            // 
            payrollB.FlatAppearance.BorderColor = Color.Beige;
            payrollB.FlatStyle = FlatStyle.Flat;
            payrollB.Location = new Point(14, 298);
            payrollB.Name = "payrollB";
            payrollB.Size = new Size(172, 57);
            payrollB.TabIndex = 3;
            payrollB.Text = "button3";
            payrollB.UseVisualStyleBackColor = true;
            // 
            // attendanceB
            // 
            attendanceB.BackColor = Color.FromArgb(25, 35, 55);
            attendanceB.FlatAppearance.BorderColor = Color.Beige;
            attendanceB.FlatStyle = FlatStyle.Flat;
            attendanceB.Location = new Point(14, 225);
            attendanceB.Name = "attendanceB";
            attendanceB.Size = new Size(172, 57);
            attendanceB.TabIndex = 2;
            attendanceB.Text = "button4";
            attendanceB.UseVisualStyleBackColor = false;
            // 
            // usersB
            // 
            usersB.BackColor = Color.FromArgb(25, 35, 55);
            usersB.BackgroundImage = Resources.users1;
            usersB.BackgroundImageLayout = ImageLayout.Zoom;
            usersB.FlatAppearance.BorderColor = Color.Beige;
            usersB.FlatAppearance.MouseDownBackColor = Color.Black;
            usersB.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            usersB.FlatStyle = FlatStyle.Flat;
            usersB.ForeColor = SystemColors.Control;
            usersB.Location = new Point(14, 152);
            usersB.Name = "usersB";
            usersB.Size = new Size(172, 57);
            usersB.TabIndex = 1;
            usersB.UseVisualStyleBackColor = false;
            // 
            // taskB
            // 
            taskB.BackColor = Color.Transparent;
            taskB.BackgroundImage = Resources.users;
            taskB.BackgroundImageLayout = ImageLayout.Zoom;
            taskB.FlatAppearance.BorderColor = Color.Beige;
            taskB.FlatStyle = FlatStyle.Flat;
            taskB.Location = new Point(14, 80);
            taskB.Name = "taskB";
            taskB.Size = new Size(172, 57);
            taskB.TabIndex = 0;
            taskB.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 447);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 44, 66);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 426);
            panel2.TabIndex = 0;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Ubuntu Mono", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.Beige;
            Dashboard.Location = new Point(14, 21);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(120, 26);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 548);
            Controls.Add(panel1);
            Controls.Add(bodyPanel);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            bodyPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel4;
        private Panel headPanel;
        private PictureBox pictureBox2;
        private DataGridView attendanceGrid;
        private ContextMenuStrip delORmod;
        private Panel bodyPanel;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button payrollB;
        private Button attendanceB;
        private Button usersB;
        private Button taskB;
        private Button addUserButton;
        private Button modifyRowButton;
        private Button deleteRowButton;
        private Label label1;
        private Button loadButton;
        private Label label4;
        private Label nameLabel;
        private TextBox nameTxtBox;
        private TextBox idTxtBox;
        private Label lastNameLabel;
        private TextBox fNameTxtBox;
        private Label Dashboard;
    }
}