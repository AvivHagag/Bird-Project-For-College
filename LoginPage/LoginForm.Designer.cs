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
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(239, 107);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(198, 31);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // userNameLable
            // 
            userNameLable.AutoSize = true;
            userNameLable.Location = new Point(141, 108);
            userNameLable.Name = "userNameLable";
            userNameLable.Size = new Size(91, 25);
            userNameLable.TabIndex = 1;
            userNameLable.Text = "Username";
            // 
            // passwordLable
            // 
            passwordLable.AutoSize = true;
            passwordLable.Location = new Point(141, 168);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(87, 25);
            passwordLable.TabIndex = 2;
            passwordLable.Text = "Password";
            passwordLable.Click += Password_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(239, 167);
            passwordBox.MaxLength = 14;
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(198, 31);
            passwordBox.TabIndex = 3;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(239, 243);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(111, 33);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // invalidAuth
            // 
            invalidAuth.AutoSize = true;
            invalidAuth.Location = new Point(113, 290);
            invalidAuth.Name = "invalidAuth";
            invalidAuth.Size = new Size(386, 25);
            invalidAuth.TabIndex = 5;
            invalidAuth.Text = "Invalid username or password. Please try again.";
            invalidAuth.Visible = false;
            invalidAuth.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(invalidAuth);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(passwordLable);
            Controls.Add(userNameLable);
            Controls.Add(usernameBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}