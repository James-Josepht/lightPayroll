using lightPayrollServices;

namespace lighPayroll
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            backHomeButton = new PictureBox();
            panel2 = new Panel();
            showPassBox = new CheckBox();
            label3 = new Label();
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
            panel1.Size = new Size(1071, 128);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = lighPayrollUI.Properties.Resources.smart_idea;
            pictureBox1.Location = new Point(370, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // backHomeButton
            // 
            backHomeButton.BackgroundImage = (Image)resources.GetObject("backHomeButton.BackgroundImage");
            backHomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            backHomeButton.Location = new Point(25, 160);
            backHomeButton.Name = "backHomeButton";
            backHomeButton.Size = new Size(85, 69);
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(passLogBox);
            panel2.Controls.Add(userLogBox);
            panel2.Location = new Point(222, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 499);
            panel2.TabIndex = 6;
            // 
            // showPassBox
            // 
            showPassBox.AutoSize = true;
            showPassBox.BackColor = Color.FromArgb(33, 44, 66);
            showPassBox.ForeColor = Color.Beige;
            showPassBox.Location = new Point(187, 358);
            showPassBox.Name = "showPassBox";
            showPassBox.Size = new Size(132, 24);
            showPassBox.TabIndex = 6;
            showPassBox.Text = "Show Password";
            showPassBox.UseVisualStyleBackColor = false;
            showPassBox.CheckedChanged += showPassBox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 44, 66);
            label3.Font = new Font("Ubuntu Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(158, 73);
            label3.Name = "label3";
            label3.Size = new Size(252, 41);
            label3.TabIndex = 5;
            label3.Text = "Welcome Back!";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(268, 409);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
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
            label2.Location = new Point(188, 275);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(33, 44, 66);
            label1.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(188, 193);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 2;
            label1.Text = "Username or Email:";
            // 
            // passLogBox
            // 
            passLogBox.Location = new Point(188, 309);
            passLogBox.Name = "passLogBox";
            passLogBox.Size = new Size(271, 27);
            passLogBox.TabIndex = 1;
            passLogBox.UseSystemPasswordChar = true;
            // 
            // userLogBox
            // 
            userLogBox.Location = new Point(188, 228);
            userLogBox.Name = "userLogBox";
            userLogBox.Size = new Size(271, 27);
            userLogBox.TabIndex = 0;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1071, 645);
            Controls.Add(panel2);
            Controls.Add(backHomeButton);
            Controls.Add(panel1);
            Name = "LogIn";
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
        private Label label3;
        private CheckBox showPassBox;
        private PictureBox pictureBox3;
    }
}