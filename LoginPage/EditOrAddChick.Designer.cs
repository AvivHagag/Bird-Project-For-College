namespace LoginPage
{
    partial class EditOrAddChick
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
            editOrAddChickLabel = new Label();
            editBirdChoiceBtn = new Button();
            addChickChoiceBtn = new Button();
            SuspendLayout();
            // 
            // editOrAddChickLabel
            // 
            editOrAddChickLabel.AutoSize = true;
            editOrAddChickLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            editOrAddChickLabel.Location = new Point(279, 121);
            editOrAddChickLabel.Name = "editOrAddChickLabel";
            editOrAddChickLabel.Size = new Size(228, 30);
            editOrAddChickLabel.TabIndex = 0;
            editOrAddChickLabel.Text = "Edit bird or add chick?";
            // 
            // editBirdChoiceBtn
            // 
            editBirdChoiceBtn.Location = new Point(188, 244);
            editBirdChoiceBtn.Name = "editBirdChoiceBtn";
            editBirdChoiceBtn.Size = new Size(75, 23);
            editBirdChoiceBtn.TabIndex = 1;
            editBirdChoiceBtn.Text = "Edit Bird";
            editBirdChoiceBtn.UseVisualStyleBackColor = true;
            editBirdChoiceBtn.Click += editBirdChoiceBtn_Click;
            // 
            // addChickChoiceBtn
            // 
            addChickChoiceBtn.Location = new Point(501, 244);
            addChickChoiceBtn.Name = "addChickChoiceBtn";
            addChickChoiceBtn.Size = new Size(75, 23);
            addChickChoiceBtn.TabIndex = 2;
            addChickChoiceBtn.Text = "Add Chick";
            addChickChoiceBtn.UseVisualStyleBackColor = true;
            addChickChoiceBtn.Click += addChickChoiceBtn_Click;
            // 
            // EditOrAddChick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addChickChoiceBtn);
            Controls.Add(editBirdChoiceBtn);
            Controls.Add(editOrAddChickLabel);
            Name = "EditOrAddChick";
            Text = "EditOrAddChick";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label editOrAddChickLabel;
        private Button editBirdChoiceBtn;
        private Button addChickChoiceBtn;
    }
}