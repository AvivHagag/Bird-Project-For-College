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
            RegLabel = new Label();
            RegNameVal = new TextBox();
            RegPassVal = new TextBox();
            RegIdVal = new TextBox();
            regNameLabel = new Label();
            regPassLabel = new Label();
            regIdLabel = new Label();
            button1 = new Button();
            alert1 = new Label();
            alert2 = new Label();
            SuspendLayout();
            // 
            // RegLabel
            // 
            RegLabel.Font = new Font("David", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            RegLabel.Location = new Point(102, 33);
            RegLabel.Name = "RegLabel";
            RegLabel.Size = new Size(206, 42);
            RegLabel.TabIndex = 0;
            RegLabel.Text = "Register";
            RegLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegNameVal
            // 
            RegNameVal.Location = new Point(208, 90);
            RegNameVal.Name = "RegNameVal";
            RegNameVal.Size = new Size(100, 23);
            RegNameVal.TabIndex = 1;
            // 
            // RegPassVal
            // 
            RegPassVal.Location = new Point(208, 132);
            RegPassVal.Name = "RegPassVal";
            RegPassVal.Size = new Size(100, 23);
            RegPassVal.TabIndex = 2;
            // 
            // RegIdVal
            // 
            RegIdVal.Location = new Point(208, 177);
            RegIdVal.Name = "RegIdVal";
            RegIdVal.Size = new Size(100, 23);
            RegIdVal.TabIndex = 3;
            // 
            // regNameLabel
            // 
            regNameLabel.Location = new Point(102, 90);
            regNameLabel.Name = "regNameLabel";
            regNameLabel.Size = new Size(100, 23);
            regNameLabel.TabIndex = 4;
            regNameLabel.Text = "Username:";
            regNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regPassLabel
            // 
            regPassLabel.Location = new Point(102, 131);
            regPassLabel.Name = "regPassLabel";
            regPassLabel.Size = new Size(100, 23);
            regPassLabel.TabIndex = 4;
            regPassLabel.Text = "Password:";
            regPassLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regIdLabel
            // 
            regIdLabel.Location = new Point(102, 177);
            regIdLabel.Name = "regIdLabel";
            regIdLabel.Size = new Size(100, 23);
            regIdLabel.TabIndex = 4;
            regIdLabel.Text = "User ID:";
            regIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("David", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(102, 239);
            button1.Name = "button1";
            button1.Size = new Size(206, 56);
            button1.TabIndex = 5;
            button1.Text = "Register →";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // alert1
            // 
            alert1.AutoSize = true;
            alert1.ForeColor = Color.Red;
            alert1.Location = new Point(41, 212);
            alert1.Name = "alert1";
            alert1.Size = new Size(328, 15);
            alert1.TabIndex = 6;
            alert1.Text = "User name need to be between 6-8 chars and at most 2 digits";
            alert1.Visible = false;
            // 
            // alert2
            // 
            alert2.ForeColor = Color.Red;
            alert2.Location = new Point(41, 204);
            alert2.Name = "alert2";
            alert2.Size = new Size(331, 32);
            alert2.TabIndex = 7;
            alert2.Text = "The password should contain 8-10 characters and at least one number, letter and special character";
            alert2.Visible = false;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 450);
            Controls.Add(alert2);
            Controls.Add(alert1);
            Controls.Add(button1);
            Controls.Add(regIdLabel);
            Controls.Add(regPassLabel);
            Controls.Add(regNameLabel);
            Controls.Add(RegIdVal);
            Controls.Add(RegPassVal);
            Controls.Add(RegNameVal);
            Controls.Add(RegLabel);
            Name = "RegForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegLabel;
        private TextBox RegNameVal;
        private TextBox RegPassVal;
        private TextBox RegIdVal;
        internal Label regNameLabel;
        internal Label regPassLabel;
        internal Label regIdLabel;
        private Button button1;
        private Label alert1;
        private Label alert2;
    }
}