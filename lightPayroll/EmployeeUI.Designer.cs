namespace lighPayrollUI
{
    partial class EmployeeUI
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
            label4 = new Label();
            encourageVerses = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            greetingPanel = new Panel();
            pictureBox1 = new PictureBox();
            sGreetingsLabel = new Label();
            greetingLabel = new Label();
            bodyPanel = new Panel();
            eFeaturesPanel = new Panel();
            sFeaturesLabel = new Label();
            bFeaturesLabel = new Label();
            featuresPic = new PictureBox();
            toDoPanel = new Panel();
            taskListsWordLabel = new Label();
            toDoLabel = new Label();
            toDoPic = new PictureBox();
            panel4 = new Panel();
            headPanel = new Panel();
            exitLabel = new Label();
            panel6 = new Panel();
            exitButton = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            greetingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bodyPanel.SuspendLayout();
            eFeaturesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)featuresPic).BeginInit();
            toDoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toDoPic).BeginInit();
            headPanel.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ubuntu Mono", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(39, 397);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 22;
            label4.Text = "Bible Verse:";
            // 
            // encourageVerses
            // 
            encourageVerses.AutoSize = true;
            encourageVerses.Font = new Font("Ubuntu Mono", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encourageVerses.ForeColor = Color.Beige;
            encourageVerses.Location = new Point(162, 399);
            encourageVerses.Name = "encourageVerses";
            encourageVerses.Size = new Size(96, 18);
            encourageVerses.TabIndex = 8;
            encourageVerses.Text = "Bible Verse";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(greetingPanel);
            panel1.Controls.Add(bodyPanel);
            panel1.Location = new Point(3, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 445);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(73, 604);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 80);
            panel2.TabIndex = 4;
            // 
            // greetingPanel
            // 
            greetingPanel.BackColor = Color.FromArgb(33, 44, 66);
            greetingPanel.Controls.Add(pictureBox1);
            greetingPanel.Controls.Add(sGreetingsLabel);
            greetingPanel.Controls.Add(greetingLabel);
            greetingPanel.Location = new Point(73, 36);
            greetingPanel.Name = "greetingPanel";
            greetingPanel.Size = new Size(783, 98);
            greetingPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.good_evening_get_greeting;
            pictureBox1.Location = new Point(17, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // sGreetingsLabel
            // 
            sGreetingsLabel.AutoSize = true;
            sGreetingsLabel.BackColor = Color.FromArgb(33, 44, 66);
            sGreetingsLabel.Font = new Font("Ubuntu Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sGreetingsLabel.ForeColor = Color.Beige;
            sGreetingsLabel.Location = new Point(111, 58);
            sGreetingsLabel.Name = "sGreetingsLabel";
            sGreetingsLabel.Size = new Size(428, 23);
            sGreetingsLabel.TabIndex = 7;
            sGreetingsLabel.Text = "Welcome back! Ready to maintain stuff?";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.BackColor = Color.FromArgb(33, 44, 66);
            greetingLabel.Font = new Font("Ubuntu Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetingLabel.ForeColor = Color.Beige;
            greetingLabel.Location = new Point(108, 19);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(105, 34);
            greetingLabel.TabIndex = 6;
            greetingLabel.Text = "Hello!";
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = Color.FromArgb(33, 44, 66);
            bodyPanel.Controls.Add(eFeaturesPanel);
            bodyPanel.Controls.Add(label4);
            bodyPanel.Controls.Add(encourageVerses);
            bodyPanel.Controls.Add(toDoPanel);
            bodyPanel.Location = new Point(73, 156);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new Size(783, 445);
            bodyPanel.TabIndex = 2;
            // 
            // eFeaturesPanel
            // 
            eFeaturesPanel.BorderStyle = BorderStyle.FixedSingle;
            eFeaturesPanel.Controls.Add(sFeaturesLabel);
            eFeaturesPanel.Controls.Add(bFeaturesLabel);
            eFeaturesPanel.Controls.Add(featuresPic);
            eFeaturesPanel.Cursor = Cursors.Hand;
            eFeaturesPanel.Location = new Point(39, 122);
            eFeaturesPanel.Name = "eFeaturesPanel";
            eFeaturesPanel.Size = new Size(704, 56);
            eFeaturesPanel.TabIndex = 23;
            eFeaturesPanel.Click += eFeaturesPanel_Click;
            // 
            // sFeaturesLabel
            // 
            sFeaturesLabel.AutoSize = true;
            sFeaturesLabel.BackColor = Color.FromArgb(33, 44, 66);
            sFeaturesLabel.Cursor = Cursors.Hand;
            sFeaturesLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sFeaturesLabel.ForeColor = Color.Beige;
            sFeaturesLabel.Location = new Point(139, 31);
            sFeaturesLabel.Name = "sFeaturesLabel";
            sFeaturesLabel.Size = new Size(200, 17);
            sFeaturesLabel.TabIndex = 22;
            sFeaturesLabel.Text = "Explore what you can do!";
            sFeaturesLabel.Click += eFeaturesPanel_Click;
            // 
            // bFeaturesLabel
            // 
            bFeaturesLabel.AutoSize = true;
            bFeaturesLabel.BackColor = Color.FromArgb(33, 44, 66);
            bFeaturesLabel.Cursor = Cursors.Hand;
            bFeaturesLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bFeaturesLabel.ForeColor = Color.Beige;
            bFeaturesLabel.Location = new Point(136, 7);
            bFeaturesLabel.Name = "bFeaturesLabel";
            bFeaturesLabel.Size = new Size(108, 27);
            bFeaturesLabel.TabIndex = 22;
            bFeaturesLabel.Text = "Features";
            bFeaturesLabel.Click += eFeaturesPanel_Click;
            // 
            // featuresPic
            // 
            featuresPic.Cursor = Cursors.Hand;
            featuresPic.Image = Properties.Resources.features;
            featuresPic.Location = new Point(23, 0);
            featuresPic.Name = "featuresPic";
            featuresPic.Size = new Size(67, 50);
            featuresPic.SizeMode = PictureBoxSizeMode.StretchImage;
            featuresPic.TabIndex = 18;
            featuresPic.TabStop = false;
            featuresPic.Click += eFeaturesPanel_Click;
            // 
            // toDoPanel
            // 
            toDoPanel.BorderStyle = BorderStyle.FixedSingle;
            toDoPanel.Controls.Add(taskListsWordLabel);
            toDoPanel.Controls.Add(toDoLabel);
            toDoPanel.Controls.Add(toDoPic);
            toDoPanel.Cursor = Cursors.Hand;
            toDoPanel.Location = new Point(39, 35);
            toDoPanel.Name = "toDoPanel";
            toDoPanel.Size = new Size(704, 56);
            toDoPanel.TabIndex = 21;
            toDoPanel.Click += toDoPanel_Click;
            // 
            // taskListsWordLabel
            // 
            taskListsWordLabel.AutoSize = true;
            taskListsWordLabel.BackColor = Color.FromArgb(33, 44, 66);
            taskListsWordLabel.Cursor = Cursors.Hand;
            taskListsWordLabel.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskListsWordLabel.ForeColor = Color.Beige;
            taskListsWordLabel.Location = new Point(139, 31);
            taskListsWordLabel.Name = "taskListsWordLabel";
            taskListsWordLabel.Size = new Size(104, 17);
            taskListsWordLabel.TabIndex = 22;
            taskListsWordLabel.Text = "Let's start!";
            // 
            // toDoLabel
            // 
            toDoLabel.AutoSize = true;
            toDoLabel.BackColor = Color.FromArgb(33, 44, 66);
            toDoLabel.Cursor = Cursors.Hand;
            toDoLabel.Font = new Font("Ubuntu Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toDoLabel.ForeColor = Color.Beige;
            toDoLabel.Location = new Point(136, 7);
            toDoLabel.Name = "toDoLabel";
            toDoLabel.Size = new Size(120, 27);
            toDoLabel.TabIndex = 22;
            toDoLabel.Text = "Task List";
            toDoLabel.Click += toDoPanel_Click;
            // 
            // toDoPic
            // 
            toDoPic.Cursor = Cursors.Hand;
            toDoPic.Image = Properties.Resources.to_do_list;
            toDoPic.Location = new Point(23, 0);
            toDoPic.Name = "toDoPic";
            toDoPic.Size = new Size(67, 50);
            toDoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            toDoPic.TabIndex = 18;
            toDoPic.TabStop = false;
            toDoPic.Click += toDoPanel_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(73, 620);
            panel4.Name = "panel4";
            panel4.Size = new Size(783, 33);
            panel4.TabIndex = 7;
            // 
            // headPanel
            // 
            headPanel.BackColor = Color.Beige;
            headPanel.Controls.Add(exitLabel);
            headPanel.Controls.Add(panel6);
            headPanel.Controls.Add(pictureBox2);
            headPanel.Dock = DockStyle.Top;
            headPanel.Location = new Point(0, 0);
            headPanel.Name = "headPanel";
            headPanel.Size = new Size(937, 101);
            headPanel.TabIndex = 6;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Ubuntu Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.FromArgb(33, 44, 66);
            exitLabel.Location = new Point(852, 60);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(63, 16);
            exitLabel.TabIndex = 9;
            exitLabel.Text = "Sign Out";
            // 
            // panel6
            // 
            panel6.Controls.Add(exitButton);
            panel6.Location = new Point(840, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(85, 67);
            panel6.TabIndex = 10;
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = Properties.Resources.exit;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderColor = Color.White;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(26, 14);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(40, 23);
            exitButton.TabIndex = 6;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.smart_idea;
            pictureBox2.Location = new Point(10, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // EmployeeUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(937, 548);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(headPanel);
            Name = "EmployeeUI";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EmployeeUI_Load;
            panel1.ResumeLayout(false);
            greetingPanel.ResumeLayout(false);
            greetingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bodyPanel.ResumeLayout(false);
            bodyPanel.PerformLayout();
            eFeaturesPanel.ResumeLayout(false);
            eFeaturesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)featuresPic).EndInit();
            toDoPanel.ResumeLayout(false);
            toDoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toDoPic).EndInit();
            headPanel.ResumeLayout(false);
            headPanel.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label encourageVerses;
        private Panel panel1;
        private Panel panel2;
        private Panel greetingPanel;
        private PictureBox pictureBox1;
        private Label sGreetingsLabel;
        private Label greetingLabel;
        private Panel bodyPanel;
        private Panel toDoPanel;
        private Label taskListsWordLabel;
        private Label toDoLabel;
        private PictureBox toDoPic;
        private Panel panel4;
        private Panel headPanel;
        private PictureBox pictureBox2;
        private Panel eFeaturesPanel;
        private Label sFeaturesLabel;
        private Label bFeaturesLabel;
        private PictureBox featuresPic;
        private Label exitLabel;
        private Panel panel6;
        private Button exitButton;
    }
}