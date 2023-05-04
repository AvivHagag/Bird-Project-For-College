namespace LoginPage
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            RegNameVal = new TextBox();
            RegPassVal = new TextBox();
            RegIdVal = new TextBox();
            regNameLabel = new Label();
            regPassLabel = new Label();
            regIdLabel = new Label();
            alert1 = new Label();
            alert2 = new Label();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            regExitBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RegNameVal
            // 
            RegNameVal.Location = new Point(238, 169);
            RegNameVal.Name = "RegNameVal";
            RegNameVal.Size = new Size(114, 25);
            RegNameVal.TabIndex = 1;
            RegNameVal.TextChanged += RegNameVal_TextChanged;
            // 
            // RegPassVal
            // 
            RegPassVal.Location = new Point(238, 207);
            RegPassVal.Name = "RegPassVal";
            RegPassVal.Size = new Size(114, 25);
            RegPassVal.TabIndex = 2;
            // 
            // RegIdVal
            // 
            RegIdVal.Location = new Point(238, 249);
            RegIdVal.Name = "RegIdVal";
            RegIdVal.Size = new Size(114, 25);
            RegIdVal.TabIndex = 3;
            // 
            // regNameLabel
            // 
            regNameLabel.Location = new Point(117, 169);
            regNameLabel.Name = "regNameLabel";
            regNameLabel.Size = new Size(114, 26);
            regNameLabel.TabIndex = 4;
            regNameLabel.Text = "Username:";
            regNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regPassLabel
            // 
            regPassLabel.Location = new Point(117, 207);
            regPassLabel.Name = "regPassLabel";
            regPassLabel.Size = new Size(114, 26);
            regPassLabel.TabIndex = 4;
            regPassLabel.Text = "Password:";
            regPassLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regIdLabel
            // 
            regIdLabel.Location = new Point(117, 248);
            regIdLabel.Name = "regIdLabel";
            regIdLabel.Size = new Size(114, 26);
            regIdLabel.TabIndex = 4;
            regIdLabel.Text = "User ID:";
            regIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alert1
            // 
            alert1.AutoSize = true;
            alert1.ForeColor = Color.Red;
            alert1.Location = new Point(29, 279);
            alert1.Name = "alert1";
            alert1.Size = new Size(418, 19);
            alert1.TabIndex = 6;
            alert1.Text = "User name need to be between 6-8 chars and at most 2 digits";
            alert1.Visible = false;
            alert1.Click += alert1_Click;
            // 
            // alert2
            // 
            alert2.ForeColor = Color.Red;
            alert2.Location = new Point(47, 279);
            alert2.Name = "alert2";
            alert2.Size = new Size(378, 36);
            alert2.TabIndex = 7;
            alert2.Text = "The password should contain 8-10 characters and at least one number, letter and special character";
            alert2.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.signup31;
            pictureBox2.Location = new Point(117, 331);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(44, 62, 80);
            BackBtn.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(175, 408);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(117, 35);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back to Login";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // regExitBtn
            // 
            regExitBtn.BackColor = Color.FromArgb(192, 57, 43);
            regExitBtn.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            regExitBtn.ForeColor = Color.White;
            regExitBtn.Location = new Point(175, 449);
            regExitBtn.Name = "regExitBtn";
            regExitBtn.Size = new Size(117, 35);
            regExitBtn.TabIndex = 11;
            regExitBtn.Text = "Exit";
            regExitBtn.UseVisualStyleBackColor = false;
            regExitBtn.Click += regExitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(459, 510);
            Controls.Add(regExitBtn);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox2);
            Controls.Add(alert2);
            Controls.Add(alert1);
            Controls.Add(regIdLabel);
            Controls.Add(regPassLabel);
            Controls.Add(regNameLabel);
            Controls.Add(RegIdVal);
            Controls.Add(RegPassVal);
            Controls.Add(RegNameVal);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "RegForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox RegNameVal;
        private TextBox RegPassVal;
        private TextBox RegIdVal;
        internal Label regNameLabel;
        internal Label regPassLabel;
        internal Label regIdLabel;
        private Label alert1;
        private Label alert2;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private Button regExitBtn;
        private PictureBox pictureBox1;
    }
}