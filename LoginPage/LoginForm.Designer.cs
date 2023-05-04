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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameBox = new TextBox();
            userNameLable = new Label();
            passwordLable = new Label();
            passwordBox = new TextBox();
            loginBtn = new Button();
            invalidAuth = new Label();
            pictureBox1 = new PictureBox();
            regBtn = new Button();
            loginExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(217, 169);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(159, 25);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged_1;
            // 
            // userNameLable
            // 
            userNameLable.AutoSize = true;
            userNameLable.Location = new Point(135, 172);
            userNameLable.Margin = new Padding(2, 0, 2, 0);
            userNameLable.Name = "userNameLable";
            userNameLable.Size = new Size(76, 19);
            userNameLable.TabIndex = 1;
            userNameLable.Text = "Username";
            // 
            // passwordLable
            // 
            passwordLable.AutoSize = true;
            passwordLable.Location = new Point(135, 199);
            passwordLable.Margin = new Padding(2, 0, 2, 0);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(73, 19);
            passwordLable.TabIndex = 2;
            passwordLable.Text = "Password";
            passwordLable.Click += Password_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(217, 199);
            passwordBox.Margin = new Padding(2);
            passwordBox.MaxLength = 14;
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(159, 25);
            passwordBox.TabIndex = 3;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(44, 62, 80);
            loginBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(217, 252);
            loginBtn.Margin = new Padding(2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(103, 41);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // invalidAuth
            // 
            invalidAuth.AutoSize = true;
            invalidAuth.ForeColor = Color.Red;
            invalidAuth.Location = new Point(93, 228);
            invalidAuth.Margin = new Padding(2, 0, 2, 0);
            invalidAuth.Name = "invalidAuth";
            invalidAuth.Size = new Size(330, 19);
            invalidAuth.TabIndex = 5;
            invalidAuth.Text = "Invalid username or password. Please try again.";
            invalidAuth.Visible = false;
            invalidAuth.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-26, -117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(578, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // regBtn
            // 
            regBtn.BackColor = Color.FromArgb(44, 62, 80);
            regBtn.ForeColor = Color.White;
            regBtn.Location = new Point(217, 294);
            regBtn.Margin = new Padding(2);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(103, 41);
            regBtn.TabIndex = 7;
            regBtn.Text = "Register";
            regBtn.UseVisualStyleBackColor = false;
            regBtn.Click += regPage_Click;
            // 
            // loginExitBtn
            // 
            loginExitBtn.BackColor = Color.FromArgb(192, 57, 43);
            loginExitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginExitBtn.ForeColor = Color.White;
            loginExitBtn.Location = new Point(217, 335);
            loginExitBtn.Name = "loginExitBtn";
            loginExitBtn.Size = new Size(103, 41);
            loginExitBtn.TabIndex = 8;
            loginExitBtn.Text = "Exit";
            loginExitBtn.UseVisualStyleBackColor = false;
            loginExitBtn.Click += loginExitBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 379);
            Controls.Add(loginExitBtn);
            Controls.Add(regBtn);
            Controls.Add(invalidAuth);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(passwordLable);
            Controls.Add(userNameLable);
            Controls.Add(usernameBox);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
        private Button loginExitBtn;
    }
}