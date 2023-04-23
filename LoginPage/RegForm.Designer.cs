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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // RegNameVal
            // 
            RegNameVal.Location = new Point(208, 149);
            RegNameVal.Name = "RegNameVal";
            RegNameVal.Size = new Size(100, 23);
            RegNameVal.TabIndex = 1;
            RegNameVal.TextChanged += RegNameVal_TextChanged;
            // 
            // RegPassVal
            // 
            RegPassVal.Location = new Point(208, 183);
            RegPassVal.Name = "RegPassVal";
            RegPassVal.Size = new Size(100, 23);
            RegPassVal.TabIndex = 2;
            // 
            // RegIdVal
            // 
            RegIdVal.Location = new Point(208, 220);
            RegIdVal.Name = "RegIdVal";
            RegIdVal.Size = new Size(100, 23);
            RegIdVal.TabIndex = 3;
            // 
            // regNameLabel
            // 
            regNameLabel.Location = new Point(102, 149);
            regNameLabel.Name = "regNameLabel";
            regNameLabel.Size = new Size(100, 23);
            regNameLabel.TabIndex = 4;
            regNameLabel.Text = "Username:";
            regNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regPassLabel
            // 
            regPassLabel.Location = new Point(102, 183);
            regPassLabel.Name = "regPassLabel";
            regPassLabel.Size = new Size(100, 23);
            regPassLabel.TabIndex = 4;
            regPassLabel.Text = "Password:";
            regPassLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regIdLabel
            // 
            regIdLabel.Location = new Point(102, 219);
            regIdLabel.Name = "regIdLabel";
            regIdLabel.Size = new Size(100, 23);
            regIdLabel.TabIndex = 4;
            regIdLabel.Text = "User ID:";
            regIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alert1
            // 
            alert1.AutoSize = true;
            alert1.ForeColor = Color.Red;
            alert1.Location = new Point(41, 246);
            alert1.Name = "alert1";
            alert1.Size = new Size(328, 15);
            alert1.TabIndex = 6;
            alert1.Text = "User name need to be between 6-8 chars and at most 2 digits";
            alert1.Visible = false;
            alert1.Click += alert1_Click;
            // 
            // alert2
            // 
            alert2.ForeColor = Color.Red;
            alert2.Location = new Point(41, 246);
            alert2.Name = "alert2";
            alert2.Size = new Size(331, 32);
            alert2.TabIndex = 7;
            alert2.Text = "The password should contain 8-10 characters and at least one number, letter and special character";
            alert2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.signup1;
            pictureBox1.Location = new Point(52, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.signup31;
            pictureBox2.Location = new Point(102, 292);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BackBtn
            // 
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(153, 360);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(102, 23);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back to Login";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 450);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(alert2);
            Controls.Add(alert1);
            Controls.Add(regIdLabel);
            Controls.Add(regPassLabel);
            Controls.Add(regNameLabel);
            Controls.Add(RegIdVal);
            Controls.Add(RegPassVal);
            Controls.Add(RegNameVal);
            Name = "RegForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BackBtn;
    }
}