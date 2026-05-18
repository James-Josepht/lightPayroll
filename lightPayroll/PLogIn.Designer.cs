using lightPayrollServices;

namespace lighPayroll
{
    partial class PLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLogIn));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            backHomeButton = new PictureBox();
            panel2 = new Panel();
            showPassBox = new CheckBox();
            logckInLabel = new Label();
            loginButton = new Button();
            label2 = new Label();
            label1 = new Label();
            passLogBox = new TextBox();
            userLogBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backHomeButton).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 109);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = lighPayrollUI.Properties.Resources.smart_idea;
            pictureBox1.Location = new Point(324, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backHomeButton
            // 
            backHomeButton.BackgroundImage = (Image)resources.GetObject("backHomeButton.BackgroundImage");
            backHomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            backHomeButton.Cursor = Cursors.Hand;
            backHomeButton.Location = new Point(22, 136);
            backHomeButton.Name = "backHomeButton";
            backHomeButton.Size = new Size(74, 59);
            backHomeButton.TabIndex = 5;
            backHomeButton.TabStop = false;
            backHomeButton.Click += backHomeButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BackgroundImage = lighPayrollUI.Properties.Resources.background;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(showPassBox);
            panel2.Controls.Add(logckInLabel);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(passLogBox);
            panel2.Controls.Add(userLogBox);
            panel2.Location = new Point(194, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 424);
            panel2.TabIndex = 6;
            // 
            // showPassBox
            // 
            showPassBox.AutoSize = true;
            showPassBox.BackColor = Color.FromArgb(33, 44, 66);
            showPassBox.ForeColor = Color.Beige;
            showPassBox.Location = new Point(164, 304);
            showPassBox.Name = "showPassBox";
            showPassBox.Size = new Size(118, 21);
            showPassBox.TabIndex = 6;
            showPassBox.Text = "Show Password";
            showPassBox.UseVisualStyleBackColor = false;
            showPassBox.CheckedChanged += showPassBox_CheckedChanged;
            // 
            // logckInLabel
            // 
            logckInLabel.AutoSize = true;
            logckInLabel.BackColor = Color.FromArgb(33, 44, 66);
            logckInLabel.Font = new Font("Ubuntu Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logckInLabel.ForeColor = Color.Beige;
            logckInLabel.Location = new Point(138, 62);
            logckInLabel.Name = "logckInLabel";
            logckInLabel.Size = new Size(255, 68);
            logckInLabel.TabIndex = 5;
            logckInLabel.Text = "Let's LOG-CK IN!\r\n\r\n";
            logckInLabel.Click += label3_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(234, 348);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(82, 25);
            loginButton.TabIndex = 4;
            loginButton.Text = "Enter";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButtonClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(33, 44, 66);
            label2.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(164, 234);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(33, 44, 66);
            label1.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(164, 164);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 2;
            label1.Text = "Username or Email:";
            // 
            // passLogBox
            // 
            passLogBox.Location = new Point(164, 263);
            passLogBox.Name = "passLogBox";
            passLogBox.Size = new Size(238, 25);
            passLogBox.TabIndex = 1;
            passLogBox.UseSystemPasswordChar = true;
            // 
            // userLogBox
            // 
            userLogBox.Location = new Point(164, 194);
            userLogBox.Name = "userLogBox";
            userLogBox.Size = new Size(238, 25);
            userLogBox.TabIndex = 0;
            // 
            // PLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(937, 548);
            Controls.Add(panel2);
            Controls.Add(backHomeButton);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "PLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LogIn_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backHomeButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox backHomeButton;
        private Panel panel2;
        private Button loginButton;
        private Label label2;
        private Label label1;
        private TextBox passLogBox;
        private TextBox userLogBox;
        private Label logckInLabel;
        private CheckBox showPassBox;
        private PictureBox pictureBox3;
    }
}