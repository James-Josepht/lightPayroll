using lighPayrollUI.Properties;

namespace lighPayroll
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            showPassBox = new CheckBox();
            registerButton = new Button();
            label2 = new Label();
            label1 = new Label();
            registerPassBox = new TextBox();
            registerAccountBox = new TextBox();
            backHomeButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backHomeButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 128);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = lighPayrollUI.Properties.Resources.smart_idea;
            pictureBox1.Location = new Point(370, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BackgroundImage = lighPayrollUI.Properties.Resources.background;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(showPassBox);
            panel2.Controls.Add(registerButton);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(registerPassBox);
            panel2.Controls.Add(registerAccountBox);
            panel2.Location = new Point(222, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 499);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(33, 44, 66);
            label3.Font = new Font("Ubuntu Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(158, 73);
            label3.Name = "label3";
            label3.Size = new Size(270, 41);
            label3.TabIndex = 6;
            label3.Text = "Join for FREE!";
            // 
            // showPassBox
            // 
            showPassBox.AutoSize = true;
            showPassBox.BackColor = Color.FromArgb(33, 44, 66);
            showPassBox.ForeColor = Color.Beige;
            showPassBox.Location = new Point(187, 358);
            showPassBox.Name = "showPassBox";
            showPassBox.Size = new Size(132, 24);
            showPassBox.TabIndex = 7;
            showPassBox.Text = "Show Password";
            showPassBox.UseVisualStyleBackColor = false;
            showPassBox.Click += showPassBoxClick;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(268, 409);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 4;
            registerButton.Text = "Enter";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButtonClick;
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
            // registerPassBox
            // 
            registerPassBox.Location = new Point(188, 309);
            registerPassBox.Name = "registerPassBox";
            registerPassBox.Size = new Size(271, 27);
            registerPassBox.TabIndex = 1;
            registerPassBox.TextChanged += registerPassTextChange;
            // 
            // registerAccountBox
            // 
            registerAccountBox.Location = new Point(188, 228);
            registerAccountBox.Name = "registerAccountBox";
            registerAccountBox.Size = new Size(271, 27);
            registerAccountBox.TabIndex = 0;
            registerAccountBox.TextChanged += registerAccountTextChange;
            // 
            // backHomeButton
            // 
            backHomeButton.BackgroundImage = (Image)resources.GetObject("backHomeButton.BackgroundImage");
            backHomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            backHomeButton.Location = new Point(25, 160);
            backHomeButton.Name = "backHomeButton";
            backHomeButton.Size = new Size(85, 69);
            backHomeButton.TabIndex = 4;
            backHomeButton.TabStop = false;
            backHomeButton.Click += backHomeButtonClick;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1071, 645);
            Controls.Add(backHomeButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backHomeButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox backHomeButton;
        private TextBox registerPassBox;
        private TextBox registerAccountBox;
        private Label label1;
        private Label label2;
        private Button registerButton;
        private CheckBox showPassBox;
        private Label label3;
    }
}