using lighPayrollUI.Properties;

namespace lighPayroll
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            delORmod = new ContextMenuStrip(components);
            panel4 = new Panel();
            headPanel = new Panel();
            homeButton = new PictureBox();
            leftBodyPanel = new Panel();
            leftPanel = new Panel();
            chatUserAppearancePanel = new Panel();
            Dashboard = new Label();
            panel1 = new Panel();
            rightPanel = new Panel();
            rightInsidePanel = new Panel();
            chatMessageAppearancePanel = new Panel();
            chatMessagePanel = new Panel();
            chatBox = new TextBox();
            chatSenderHeadPanel = new Panel();
            senderName = new Label();
            senderHeadPic = new Button();
            headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeButton).BeginInit();
            leftBodyPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel1.SuspendLayout();
            rightPanel.SuspendLayout();
            rightInsidePanel.SuspendLayout();
            chatMessagePanel.SuspendLayout();
            chatSenderHeadPanel.SuspendLayout();
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
            headPanel.Controls.Add(homeButton);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(937, 101);
            headPanel.TabIndex = 6;
            // 
            // homeButton
            // 
            homeButton.Cursor = Cursors.Hand;
            homeButton.Image = Resources.smart_idea;
            homeButton.Location = new Point(10, -7);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(203, 123);
            homeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            homeButton.TabIndex = 5;
            homeButton.TabStop = false;
            homeButton.Click += homeButton_Click;
            // 
            // leftBodyPanel
            // 
            leftBodyPanel.BackColor = SystemColors.ActiveCaption;
            leftBodyPanel.Controls.Add(leftPanel);
            leftBodyPanel.Dock = DockStyle.Left;
            leftBodyPanel.Location = new Point(0, 101);
            leftBodyPanel.Name = "leftBodyPanel";
            leftBodyPanel.Size = new Size(200, 447);
            leftBodyPanel.TabIndex = 2;
            leftBodyPanel.Paint += bodyPanel_Paint;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(25, 35, 55);
            leftPanel.Controls.Add(chatUserAppearancePanel);
            leftPanel.Controls.Add(Dashboard);
            leftPanel.Dock = DockStyle.Bottom;
            leftPanel.Location = new Point(0, 21);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(200, 426);
            leftPanel.TabIndex = 0;
            // 
            // chatUserAppearancePanel
            // 
            chatUserAppearancePanel.AutoScroll = true;
            chatUserAppearancePanel.BackColor = Color.FromArgb(30, 40, 57);
            chatUserAppearancePanel.Cursor = Cursors.Hand;
            chatUserAppearancePanel.Location = new Point(7, 76);
            chatUserAppearancePanel.Name = "chatUserAppearancePanel";
            chatUserAppearancePanel.Size = new Size(184, 338);
            chatUserAppearancePanel.TabIndex = 1;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Ubuntu Mono", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.Beige;
            Dashboard.Location = new Point(14, 21);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(72, 26);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Chats";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(rightPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 447);
            panel1.TabIndex = 8;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(33, 44, 66);
            rightPanel.Controls.Add(rightInsidePanel);
            rightPanel.Dock = DockStyle.Bottom;
            rightPanel.Location = new Point(0, 21);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(737, 426);
            rightPanel.TabIndex = 0;
            // 
            // rightInsidePanel
            // 
            rightInsidePanel.BackColor = Color.FromArgb(25, 35, 55);
            rightInsidePanel.Controls.Add(chatMessageAppearancePanel);
            rightInsidePanel.Controls.Add(chatMessagePanel);
            rightInsidePanel.Controls.Add(chatSenderHeadPanel);
            rightInsidePanel.Location = new Point(16, 39);
            rightInsidePanel.Name = "rightInsidePanel";
            rightInsidePanel.Size = new Size(708, 376);
            rightInsidePanel.TabIndex = 1;
            // 
            // chatMessageAppearancePanel
            // 
            chatMessageAppearancePanel.AutoScroll = true;
            chatMessageAppearancePanel.Location = new Point(3, 64);
            chatMessageAppearancePanel.Name = "chatMessageAppearancePanel";
            chatMessageAppearancePanel.Size = new Size(702, 234);
            chatMessageAppearancePanel.TabIndex = 1;
            // 
            // chatMessagePanel
            // 
            chatMessagePanel.BackColor = Color.FromArgb(33, 44, 66);
            chatMessagePanel.Controls.Add(chatBox);
            chatMessagePanel.Location = new Point(20, 304);
            chatMessagePanel.Name = "chatMessagePanel";
            chatMessagePanel.Size = new Size(633, 51);
            chatMessagePanel.TabIndex = 0;
            // 
            // chatBox
            // 
            chatBox.BackColor = Color.FromArgb(33, 44, 66);
            chatBox.BorderStyle = BorderStyle.None;
            chatBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chatBox.ForeColor = Color.Beige;
            chatBox.Location = new Point(14, 12);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(604, 26);
            chatBox.TabIndex = 0;
            chatBox.KeyDown += chatBox_KeyDown;
            // 
            // chatSenderHeadPanel
            // 
            chatSenderHeadPanel.BackColor = Color.FromArgb(30, 40, 57);
            chatSenderHeadPanel.Controls.Add(senderName);
            chatSenderHeadPanel.Controls.Add(senderHeadPic);
            chatSenderHeadPanel.Dock = DockStyle.Top;
            chatSenderHeadPanel.Location = new Point(0, 0);
            chatSenderHeadPanel.Name = "chatSenderHeadPanel";
            chatSenderHeadPanel.Size = new Size(708, 58);
            chatSenderHeadPanel.TabIndex = 1;
            chatSenderHeadPanel.Paint += chatSenderHeadPanel_Paint;
            // 
            // senderName
            // 
            senderName.AutoSize = true;
            senderName.BackColor = Color.FromArgb(30, 40, 57);
            senderName.Font = new Font("Ubuntu Mono Medium", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            senderName.ForeColor = Color.Beige;
            senderName.Location = new Point(78, 19);
            senderName.Name = "senderName";
            senderName.Size = new Size(54, 20);
            senderName.TabIndex = 2;
            senderName.Text = "Chats";
            senderName.Visible = false;
            // 
            // senderHeadPic
            // 
            senderHeadPic.BackgroundImage = (Image)resources.GetObject("senderHeadPic.BackgroundImage");
            senderHeadPic.BackgroundImageLayout = ImageLayout.Stretch;
            senderHeadPic.FlatAppearance.BorderColor = Color.FromArgb(27, 37, 57);
            senderHeadPic.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 37, 57);
            senderHeadPic.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 37, 57);
            senderHeadPic.FlatStyle = FlatStyle.Flat;
            senderHeadPic.Location = new Point(20, 13);
            senderHeadPic.Name = "senderHeadPic";
            senderHeadPic.Size = new Size(52, 33);
            senderHeadPic.TabIndex = 0;
            senderHeadPic.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 548);
            Controls.Add(panel1);
            Controls.Add(leftBodyPanel);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            MaximizeBox = false;
            Name = "Chat";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ChatDashboard_Load;
            headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homeButton).EndInit();
            leftBodyPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightInsidePanel.ResumeLayout(false);
            chatMessagePanel.ResumeLayout(false);
            chatMessagePanel.PerformLayout();
            chatSenderHeadPanel.ResumeLayout(false);
            chatSenderHeadPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Panel headPanel;
        private PictureBox homeButton;
        private DataGridView attendanceGrid;
        private ContextMenuStrip delORmod;
        private Panel leftBodyPanel;
        private Panel panel1;
        private Panel leftPanel;
        private Panel rightPanel;
        private Button addUserButton;
        private Button modifyRowButton;
        private Button deleteRowButton;
        private Button loadButton;
        private Label nameLabel;
        private TextBox nameTxtBox;
        private TextBox idTxtBox;
        private Label lastNameLabel;
        private TextBox fNameTxtBox;
        private Label Dashboard;
        private Panel chatUserAppearancePanel;
        private Panel rightInsidePanel;
        private Panel chatMessagePanel;
        private TextBox chatBox;
        private Panel chatMessageAppearancePanel;
        private Label senderName;
        private Panel chatSenderHeadPanel;
        private Button senderHeadPic;
    }
}