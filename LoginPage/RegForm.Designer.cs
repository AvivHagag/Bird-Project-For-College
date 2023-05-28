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
            pictureBox1 = new PictureBox();
            Exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
            // 
            // RegNameVal
            // 
            RegNameVal.BackColor = Color.LightBlue;
            RegNameVal.BorderStyle = BorderStyle.FixedSingle;
            RegNameVal.Location = new Point(275, 182);
            RegNameVal.Name = "RegNameVal";
            RegNameVal.Size = new Size(114, 25);
            RegNameVal.TabIndex = 1;
            RegNameVal.TextChanged += RegNameVal_TextChanged;
            // 
            // RegPassVal
            // 
            RegPassVal.BackColor = Color.LightBlue;
            RegPassVal.BorderStyle = BorderStyle.FixedSingle;
            RegPassVal.Location = new Point(275, 213);
            RegPassVal.Name = "RegPassVal";
            RegPassVal.Size = new Size(114, 25);
            RegPassVal.TabIndex = 2;
            RegPassVal.TextChanged += RegPassVal_TextChanged;
            // 
            // RegIdVal
            // 
            RegIdVal.BackColor = Color.LightBlue;
            RegIdVal.BorderStyle = BorderStyle.FixedSingle;
            RegIdVal.Location = new Point(275, 247);
            RegIdVal.Name = "RegIdVal";
            RegIdVal.Size = new Size(114, 25);
            RegIdVal.TabIndex = 3;
            // 
            // regNameLabel
            // 
            regNameLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            regNameLabel.Location = new Point(139, 181);
            regNameLabel.Name = "regNameLabel";
            regNameLabel.Size = new Size(114, 26);
            regNameLabel.TabIndex = 4;
            regNameLabel.Text = "Username:";
            regNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regPassLabel
            // 
            regPassLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            regPassLabel.Location = new Point(139, 213);
            regPassLabel.Name = "regPassLabel";
            regPassLabel.Size = new Size(114, 26);
            regPassLabel.TabIndex = 4;
            regPassLabel.Text = "Password:";
            regPassLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regIdLabel
            // 
            regIdLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            regIdLabel.Location = new Point(139, 246);
            regIdLabel.Name = "regIdLabel";
            regIdLabel.Size = new Size(114, 26);
            regIdLabel.TabIndex = 4;
            regIdLabel.Text = "User ID:";
            regIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            regIdLabel.Click += regIdLabel_Click;
            // 
            // alert1
            // 
            alert1.AutoSize = true;
            alert1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            alert1.ForeColor = Color.Red;
            alert1.Location = new Point(13, 275);
            alert1.Name = "alert1";
            alert1.Size = new Size(517, 28);
            alert1.TabIndex = 6;
            alert1.Text = "User name need to be between 6-8 chars and at most 2 digits";
            alert1.Visible = false;
            alert1.Click += alert1_Click;
            // 
            // alert2
            // 
            alert2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            alert2.ForeColor = Color.Red;
            alert2.Location = new Point(119, 275);
            alert2.Name = "alert2";
            alert2.Size = new Size(378, 36);
            alert2.TabIndex = 7;
            alert2.Text = "The password should contain 8-10 characters and at least one number, letter and special character";
            alert2.Visible = false;
            alert2.Click += alert2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.signup;
            pictureBox2.Location = new Point(151, 303);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.LightBlue;
            BackBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(403, 367);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(131, 35);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back to Login";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.register;
            pictureBox1.Location = new Point(-6, -116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(546, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 12;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(542, 414);
            Controls.Add(Exit);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox Exit;
    }
}