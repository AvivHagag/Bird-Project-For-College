namespace LoginPage
{
    partial class Addchick
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
            chickGroup = new GroupBox();
            chickGenderCombo = new ComboBox();
            dateChickBox = new DateTimePicker();
            exitChickBtn = new Button();
            addChickBtn = new Button();
            motherChickBox = new TextBox();
            fatherChickBox = new TextBox();
            FatherIdLabel = new Label();
            motherIdLabel = new Label();
            chickGenderLabel = new Label();
            dateChickLabel = new Label();
            chickGroup.SuspendLayout();
            SuspendLayout();
            // 
            // chickGroup
            // 
            chickGroup.BackColor = Color.FromArgb(236, 240, 241);
            chickGroup.Controls.Add(chickGenderCombo);
            chickGroup.Controls.Add(dateChickBox);
            chickGroup.Controls.Add(exitChickBtn);
            chickGroup.Controls.Add(addChickBtn);
            chickGroup.Controls.Add(motherChickBox);
            chickGroup.Controls.Add(fatherChickBox);
            chickGroup.Controls.Add(FatherIdLabel);
            chickGroup.Controls.Add(motherIdLabel);
            chickGroup.Controls.Add(chickGenderLabel);
            chickGroup.Controls.Add(dateChickLabel);
            chickGroup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chickGroup.ForeColor = Color.FromArgb(44, 62, 80);
            chickGroup.Location = new Point(12, 12);
            chickGroup.Name = "chickGroup";
            chickGroup.Padding = new Padding(10);
            chickGroup.Size = new Size(769, 421);
            chickGroup.TabIndex = 0;
            chickGroup.TabStop = false;
            chickGroup.Text = "Add Chick";
            chickGroup.Enter += chickGroup_Enter;
            // 
            // chickGenderCombo
            // 
            chickGenderCombo.FormattingEnabled = true;
            chickGenderCombo.Items.AddRange(new object[] { "Male", "Female" });
            chickGenderCombo.Location = new Point(363, 171);
            chickGenderCombo.Name = "chickGenderCombo";
            chickGenderCombo.Size = new Size(200, 29);
            chickGenderCombo.TabIndex = 11;
            // 
            // dateChickBox
            // 
            dateChickBox.Format = DateTimePickerFormat.Short;
            dateChickBox.Location = new Point(363, 142);
            dateChickBox.Name = "dateChickBox";
            dateChickBox.Size = new Size(200, 29);
            dateChickBox.TabIndex = 10;
            // 
            // exitChickBtn
            // 
            exitChickBtn.AutoEllipsis = true;
            exitChickBtn.BackColor = Color.FromArgb(192, 57, 43);
            exitChickBtn.Cursor = Cursors.Hand;
            exitChickBtn.FlatAppearance.BorderSize = 0;
            exitChickBtn.FlatStyle = FlatStyle.Flat;
            exitChickBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            exitChickBtn.ForeColor = Color.White;
            exitChickBtn.Location = new Point(325, 319);
            exitChickBtn.Name = "exitChickBtn";
            exitChickBtn.Size = new Size(103, 25);
            exitChickBtn.TabIndex = 8;
            exitChickBtn.Text = "Exit";
            exitChickBtn.UseVisualStyleBackColor = false;
            exitChickBtn.Click += exitChickBtn_Click;
            // 
            // addChickBtn
            // 
            addChickBtn.BackColor = Color.FromArgb(44, 62, 80);
            addChickBtn.Cursor = Cursors.Hand;
            addChickBtn.FlatAppearance.BorderSize = 0;
            addChickBtn.FlatStyle = FlatStyle.Flat;
            addChickBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addChickBtn.ForeColor = Color.White;
            addChickBtn.Location = new Point(325, 290);
            addChickBtn.Name = "addChickBtn";
            addChickBtn.Size = new Size(103, 23);
            addChickBtn.TabIndex = 1;
            addChickBtn.Text = "Add";
            addChickBtn.UseVisualStyleBackColor = false;
            addChickBtn.Click += addChickBtn_Click;
            // 
            // motherChickBox
            // 
            motherChickBox.Location = new Point(363, 203);
            motherChickBox.Name = "motherChickBox";
            motherChickBox.Size = new Size(200, 29);
            motherChickBox.TabIndex = 7;
            motherChickBox.TextChanged += textBox1_TextChanged;
            // 
            // fatherChickBox
            // 
            fatherChickBox.Location = new Point(363, 200);
            fatherChickBox.Name = "fatherChickBox";
            fatherChickBox.Size = new Size(200, 29);
            fatherChickBox.TabIndex = 6;
            fatherChickBox.Visible = false;
            // 
            // FatherIdLabel
            // 
            FatherIdLabel.AutoSize = true;
            FatherIdLabel.Location = new Point(237, 203);
            FatherIdLabel.Name = "FatherIdLabel";
            FatherIdLabel.Size = new Size(83, 21);
            FatherIdLabel.TabIndex = 3;
            FatherIdLabel.Text = "Father ID:";
            FatherIdLabel.Visible = false;
            // 
            // motherIdLabel
            // 
            motherIdLabel.AutoSize = true;
            motherIdLabel.Location = new Point(237, 203);
            motherIdLabel.Name = "motherIdLabel";
            motherIdLabel.Size = new Size(91, 21);
            motherIdLabel.TabIndex = 2;
            motherIdLabel.Text = "Mother ID:";
            motherIdLabel.Visible = false;
            // 
            // chickGenderLabel
            // 
            chickGenderLabel.AutoSize = true;
            chickGenderLabel.Location = new Point(237, 171);
            chickGenderLabel.Name = "chickGenderLabel";
            chickGenderLabel.Size = new Size(70, 21);
            chickGenderLabel.TabIndex = 1;
            chickGenderLabel.Text = "Gender:";
            // 
            // dateChickLabel
            // 
            dateChickLabel.AutoSize = true;
            dateChickLabel.Location = new Point(237, 142);
            dateChickLabel.Name = "dateChickLabel";
            dateChickLabel.Size = new Size(117, 21);
            dateChickLabel.TabIndex = 0;
            dateChickLabel.Text = "Date of hatch:";
            // 
            // Addchick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chickGroup);
            Name = "Addchick";
            Text = "Addchick";
            chickGroup.ResumeLayout(false);
            chickGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox chickGroup;
        private Label chickGenderLabel;
        private Label dateChickLabel;
        private Button exitChickBtn;
        private Button addChickBtn;
        private DateTimePicker dateChickBox;
        public TextBox motherChickBox;
        public TextBox fatherChickBox;
        private ComboBox chickGenderCombo;
        public Label FatherIdLabel;
        public Label motherIdLabel;
    }
}