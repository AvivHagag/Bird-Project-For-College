namespace LoginPage
{
    partial class ShowBirdsOrEditCage
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
            showOrEditLabel = new Label();
            showBirdsBtn = new Button();
            editCageBtn = new Button();
            SuspendLayout();
            // 
            // showOrEditLabel
            // 
            showOrEditLabel.AutoSize = true;
            showOrEditLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            showOrEditLabel.Location = new Point(231, 105);
            showOrEditLabel.Name = "showOrEditLabel";
            showOrEditLabel.Size = new Size(327, 30);
            showOrEditLabel.TabIndex = 1;
            showOrEditLabel.Text = "Show birds in cage or edit cage?";
            // 
            // showBirdsBtn
            // 
            showBirdsBtn.BackColor = Color.FromArgb(44, 62, 80);
            showBirdsBtn.FlatAppearance.BorderSize = 0;
            showBirdsBtn.FlatStyle = FlatStyle.Flat;
            showBirdsBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            showBirdsBtn.ForeColor = Color.White;
            showBirdsBtn.Location = new Point(118, 271);
            showBirdsBtn.Name = "showBirdsBtn";
            showBirdsBtn.Size = new Size(121, 30);
            showBirdsBtn.TabIndex = 2;
            showBirdsBtn.Text = "Birds in cage";
            showBirdsBtn.UseVisualStyleBackColor = false;
            showBirdsBtn.Click += showBirdsBtn_Click;
            // 
            // editCageBtn
            // 
            editCageBtn.BackColor = Color.FromArgb(44, 62, 80);
            editCageBtn.FlatAppearance.BorderSize = 0;
            editCageBtn.FlatStyle = FlatStyle.Flat;
            editCageBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editCageBtn.ForeColor = Color.White;
            editCageBtn.Location = new Point(497, 271);
            editCageBtn.Name = "editCageBtn";
            editCageBtn.Size = new Size(121, 30);
            editCageBtn.TabIndex = 3;
            editCageBtn.Text = "Edit Cage";
            editCageBtn.UseVisualStyleBackColor = false;
            editCageBtn.Click += editCageBtn_Click;
            // 
            // ShowBirdsOrEditCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editCageBtn);
            Controls.Add(showBirdsBtn);
            Controls.Add(showOrEditLabel);
            Name = "ShowBirdsOrEditCage";
            Text = "ShowBirdsOrEditCage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showOrEditLabel;
        private Button showBirdsBtn;
        private Button editCageBtn;
    }
}