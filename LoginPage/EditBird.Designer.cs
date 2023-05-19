namespace LoginPage
{
    partial class EditBird
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
            birdEditNameLabel = new Label();
            oldBirdCageLabel = new Label();
            oldBirdCage = new Label();
            newCageNumberLabel = new Label();
            newCageNumberBox = new TextBox();
            loginExitBtn = new Button();
            changeBirdCageBtn = new Button();
            SuspendLayout();
            // 
            // birdEditNameLabel
            // 
            birdEditNameLabel.AutoSize = true;
            birdEditNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            birdEditNameLabel.Location = new Point(307, 78);
            birdEditNameLabel.Name = "birdEditNameLabel";
            birdEditNameLabel.Size = new Size(160, 30);
            birdEditNameLabel.TabIndex = 0;
            birdEditNameLabel.Text = "Edit bird's cage";
            // 
            // oldBirdCageLabel
            // 
            oldBirdCageLabel.AutoSize = true;
            oldBirdCageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Underline, GraphicsUnit.Point);
            oldBirdCageLabel.Location = new Point(162, 176);
            oldBirdCageLabel.Name = "oldBirdCageLabel";
            oldBirdCageLabel.Size = new Size(158, 25);
            oldBirdCageLabel.TabIndex = 1;
            oldBirdCageLabel.Text = "Old cage number";
            // 
            // oldBirdCage
            // 
            oldBirdCage.AutoSize = true;
            oldBirdCage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            oldBirdCage.Location = new Point(207, 219);
            oldBirdCage.Name = "oldBirdCage";
            oldBirdCage.Size = new Size(52, 21);
            oldBirdCage.TabIndex = 2;
            oldBirdCage.Text = "label1";
            // 
            // newCageNumberLabel
            // 
            newCageNumberLabel.AutoSize = true;
            newCageNumberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Underline, GraphicsUnit.Point);
            newCageNumberLabel.Location = new Point(507, 176);
            newCageNumberLabel.Name = "newCageNumberLabel";
            newCageNumberLabel.Size = new Size(166, 25);
            newCageNumberLabel.TabIndex = 3;
            newCageNumberLabel.Text = "New cage number";
            // 
            // newCageNumberBox
            // 
            newCageNumberBox.Location = new Point(535, 221);
            newCageNumberBox.Name = "newCageNumberBox";
            newCageNumberBox.Size = new Size(100, 23);
            newCageNumberBox.TabIndex = 4;
            newCageNumberBox.TextChanged += newCageNumberBox_TextChanged;
            // 
            // loginExitBtn
            // 
            loginExitBtn.BackColor = Color.FromArgb(192, 57, 43);
            loginExitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginExitBtn.ForeColor = Color.White;
            loginExitBtn.Location = new Point(48, 381);
            loginExitBtn.Name = "loginExitBtn";
            loginExitBtn.Size = new Size(103, 41);
            loginExitBtn.TabIndex = 10;
            loginExitBtn.Text = "Exit";
            loginExitBtn.UseVisualStyleBackColor = false;
            loginExitBtn.Click += loginExitBtn_Click;
            // 
            // changeBirdCageBtn
            // 
            changeBirdCageBtn.BackColor = Color.FromArgb(44, 62, 80);
            changeBirdCageBtn.Cursor = Cursors.Hand;
            changeBirdCageBtn.FlatAppearance.BorderSize = 0;
            changeBirdCageBtn.FlatStyle = FlatStyle.Flat;
            changeBirdCageBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            changeBirdCageBtn.ForeColor = Color.White;
            changeBirdCageBtn.Location = new Point(556, 385);
            changeBirdCageBtn.Name = "changeBirdCageBtn";
            changeBirdCageBtn.Size = new Size(103, 33);
            changeBirdCageBtn.TabIndex = 11;
            changeBirdCageBtn.Text = "Submit";
            changeBirdCageBtn.UseVisualStyleBackColor = false;
            changeBirdCageBtn.Click += addChickBtn_Click;
            // 
            // EditBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changeBirdCageBtn);
            Controls.Add(loginExitBtn);
            Controls.Add(newCageNumberBox);
            Controls.Add(newCageNumberLabel);
            Controls.Add(oldBirdCage);
            Controls.Add(oldBirdCageLabel);
            Controls.Add(birdEditNameLabel);
            Name = "EditBird";
            Text = "EditBird";
            Load += EditBird_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label birdEditNameLabel;
        private Label oldBirdCageLabel;
        private Label oldBirdCage;
        private Label newCageNumberLabel;
        private TextBox newCageNumberBox;
        private Button changeCageBtn;
        private Button loginExitBtn;
        private Button changeBirdCageBtn;
    }
}