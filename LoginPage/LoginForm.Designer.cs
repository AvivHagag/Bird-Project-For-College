namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameBox = new TextBox();
            userNameLable = new Label();
            passwordLable = new Label();
            passwordBox = new TextBox();
            loginBtn = new Button();
            invalidAuth = new Label();
            pictureBox1 = new PictureBox();
            regBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(203, 129);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(140, 23);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged_1;
            // 
            // userNameLable
            // 
            userNameLable.AutoSize = true;
            userNameLable.Location = new Point(132, 137);
            userNameLable.Margin = new Padding(2, 0, 2, 0);
            userNameLable.Name = "userNameLable";
            userNameLable.Size = new Size(60, 15);
            userNameLable.TabIndex = 1;
            userNameLable.Text = "Username";
            // 
            // passwordLable
            // 
            passwordLable.AutoSize = true;
            passwordLable.Location = new Point(132, 164);
            passwordLable.Margin = new Padding(2, 0, 2, 0);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(57, 15);
            passwordLable.TabIndex = 2;
            passwordLable.Text = "Password";
            passwordLable.Click += Password_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(203, 156);
            passwordBox.Margin = new Padding(2);
            passwordBox.MaxLength = 14;
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(140, 23);
            passwordBox.TabIndex = 3;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Teal;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(181, 200);
            loginBtn.Margin = new Padding(2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(90, 39);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // invalidAuth
            // 
            invalidAuth.AutoSize = true;
            invalidAuth.ForeColor = Color.Red;
            invalidAuth.Location = new Point(104, 183);
            invalidAuth.Margin = new Padding(2, 0, 2, 0);
            invalidAuth.Name = "invalidAuth";
            invalidAuth.Size = new Size(255, 15);
            invalidAuth.TabIndex = 5;
            invalidAuth.Text = "Invalid username or password. Please try again.";
            invalidAuth.Visible = false;
            invalidAuth.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LoginPage.Properties.Resources.LoginLogo1;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // regBtn
            // 
            regBtn.BackColor = Color.MidnightBlue;
            regBtn.ForeColor = Color.White;
            regBtn.Location = new Point(181, 243);
            regBtn.Margin = new Padding(2);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(90, 39);
            regBtn.TabIndex = 7;
            regBtn.Text = "Register";
            regBtn.UseVisualStyleBackColor = false;
            regBtn.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 334);
            Controls.Add(regBtn);
            Controls.Add(pictureBox1);
            Controls.Add(invalidAuth);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(passwordLable);
            Controls.Add(userNameLable);
            Controls.Add(usernameBox);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private Label userNameLable;
        private Label passwordLable;
        private TextBox passwordBox;
        private Button loginBtn;
        private Label invalidAuth;
        private PictureBox pictureBox1;
        private Button regBtn;
    }
}