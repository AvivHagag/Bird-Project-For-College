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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cageidLabel = new Label();
            genderLabel = new Label();
            subLabel = new Label();
            SpacieLabel = new Label();
            IdLabel = new Label();
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
            chickGroup.Controls.Add(label5);
            chickGroup.Controls.Add(label4);
            chickGroup.Controls.Add(label3);
            chickGroup.Controls.Add(label2);
            chickGroup.Controls.Add(label1);
            chickGroup.Controls.Add(cageidLabel);
            chickGroup.Controls.Add(genderLabel);
            chickGroup.Controls.Add(subLabel);
            chickGroup.Controls.Add(SpacieLabel);
            chickGroup.Controls.Add(IdLabel);
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
            chickGroup.Size = new Size(624, 285);
            chickGroup.TabIndex = 0;
            chickGroup.TabStop = false;
            chickGroup.Text = "Add Chick";
            chickGroup.Enter += chickGroup_Enter;
            // 
            // label5
            // 
            label5.Location = new Point(13, 137);
            label5.Name = "label5";
            label5.Size = new Size(106, 26);
            label5.TabIndex = 21;
            label5.Text = "Cage ID:";
            // 
            // label4
            // 
            label4.Location = new Point(13, 110);
            label4.Name = "label4";
            label4.Size = new Size(106, 26);
            label4.TabIndex = 20;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.Location = new Point(13, 84);
            label3.Name = "label3";
            label3.Size = new Size(106, 26);
            label3.TabIndex = 19;
            label3.Text = "Subspacie:";
            // 
            // label2
            // 
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 18;
            label2.Text = "Spacie:";
            // 
            // label1
            // 
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 26);
            label1.TabIndex = 17;
            label1.Text = "Bird ID:";
            // 
            // cageidLabel
            // 
            cageidLabel.Location = new Point(125, 137);
            cageidLabel.Name = "cageidLabel";
            cageidLabel.Size = new Size(157, 26);
            cageidLabel.TabIndex = 16;
            cageidLabel.Text = "label5";
            // 
            // genderLabel
            // 
            genderLabel.Location = new Point(125, 110);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(157, 26);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "label4";
            // 
            // subLabel
            // 
            subLabel.Location = new Point(125, 84);
            subLabel.Name = "subLabel";
            subLabel.Size = new Size(157, 26);
            subLabel.TabIndex = 14;
            subLabel.Text = "label3";
            subLabel.Click += subLabel_Click;
            // 
            // SpacieLabel
            // 
            SpacieLabel.Location = new Point(125, 58);
            SpacieLabel.Name = "SpacieLabel";
            SpacieLabel.Size = new Size(157, 26);
            SpacieLabel.TabIndex = 13;
            SpacieLabel.Text = "label2";
            SpacieLabel.Click += SpacieLabel_Click;
            // 
            // IdLabel
            // 
            IdLabel.Location = new Point(125, 32);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(157, 26);
            IdLabel.TabIndex = 12;
            IdLabel.Text = "label1";
            // 
            // chickGenderCombo
            // 
            chickGenderCombo.FormattingEnabled = true;
            chickGenderCombo.Items.AddRange(new object[] { "Male", "Female" });
            chickGenderCombo.Location = new Point(411, 73);
            chickGenderCombo.Name = "chickGenderCombo";
            chickGenderCombo.Size = new Size(200, 29);
            chickGenderCombo.TabIndex = 11;
            // 
            // dateChickBox
            // 
            dateChickBox.Format = DateTimePickerFormat.Short;
            dateChickBox.Location = new Point(411, 26);
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
            exitChickBtn.Location = new Point(365, 204);
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
            addChickBtn.Location = new Point(365, 165);
            addChickBtn.Name = "addChickBtn";
            addChickBtn.Size = new Size(103, 33);
            addChickBtn.TabIndex = 1;
            addChickBtn.Text = "Add";
            addChickBtn.UseVisualStyleBackColor = false;
            addChickBtn.Click += addChickBtn_Click;
            // 
            // motherChickBox
            // 
            motherChickBox.Location = new Point(411, 118);
            motherChickBox.Name = "motherChickBox";
            motherChickBox.Size = new Size(200, 29);
            motherChickBox.TabIndex = 7;
            motherChickBox.TextChanged += textBox1_TextChanged;
            // 
            // fatherChickBox
            // 
            fatherChickBox.Location = new Point(411, 118);
            fatherChickBox.Name = "fatherChickBox";
            fatherChickBox.Size = new Size(200, 29);
            fatherChickBox.TabIndex = 6;
            fatherChickBox.Visible = false;
            // 
            // FatherIdLabel
            // 
            FatherIdLabel.AutoSize = true;
            FatherIdLabel.Location = new Point(288, 121);
            FatherIdLabel.Name = "FatherIdLabel";
            FatherIdLabel.Size = new Size(83, 21);
            FatherIdLabel.TabIndex = 3;
            FatherIdLabel.Text = "Father ID:";
            FatherIdLabel.Visible = false;
            // 
            // motherIdLabel
            // 
            motherIdLabel.AutoSize = true;
            motherIdLabel.Location = new Point(288, 121);
            motherIdLabel.Name = "motherIdLabel";
            motherIdLabel.Size = new Size(91, 21);
            motherIdLabel.TabIndex = 2;
            motherIdLabel.Text = "Mother ID:";
            motherIdLabel.Visible = false;
            // 
            // chickGenderLabel
            // 
            chickGenderLabel.AutoSize = true;
            chickGenderLabel.Location = new Point(288, 76);
            chickGenderLabel.Name = "chickGenderLabel";
            chickGenderLabel.Size = new Size(70, 21);
            chickGenderLabel.TabIndex = 1;
            chickGenderLabel.Text = "Gender:";
            // 
            // dateChickLabel
            // 
            dateChickLabel.AutoSize = true;
            dateChickLabel.Location = new Point(288, 32);
            dateChickLabel.Name = "dateChickLabel";
            dateChickLabel.Size = new Size(117, 21);
            dateChickLabel.TabIndex = 0;
            dateChickLabel.Text = "Date of hatch:";
            dateChickLabel.Click += dateChickLabel_Click;
            // 
            // Addchick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 307);
            Controls.Add(chickGroup);
            Name = "Addchick";
            Text = "Addchick";
            Load += Addchick_Load;
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
        private Label IdLabel;
        private Label cageidLabel;
        private Label genderLabel;
        private Label subLabel;
        private Label SpacieLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}