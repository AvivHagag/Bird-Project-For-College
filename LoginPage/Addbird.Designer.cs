﻿namespace LoginPage
{
    partial class Addbird
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
            groupBox1 = new GroupBox();
            BodyColorcmb = new ComboBox();
            ChestColorcmb = new ComboBox();
            HeadColorcmb = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            birdExitBtn = new Button();
            BackBtn = new Button();
            FinalAddbtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            cagenumber = new TextBox();
            fatherserialnumber = new TextBox();
            motherserialnumber = new TextBox();
            GendercomboBox = new ComboBox();
            SubspeciescomboBox = new ComboBox();
            SpeciescomboBox = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(236, 240, 241);
            groupBox1.Controls.Add(BodyColorcmb);
            groupBox1.Controls.Add(ChestColorcmb);
            groupBox1.Controls.Add(HeadColorcmb);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(birdExitBtn);
            groupBox1.Controls.Add(BackBtn);
            groupBox1.Controls.Add(FinalAddbtn);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cagenumber);
            groupBox1.Controls.Add(fatherserialnumber);
            groupBox1.Controls.Add(motherserialnumber);
            groupBox1.Controls.Add(GendercomboBox);
            groupBox1.Controls.Add(SubspeciescomboBox);
            groupBox1.Controls.Add(SpeciescomboBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(14, 17, 14, 17);
            groupBox1.Size = new Size(784, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Bird";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BodyColorcmb
            // 
            BodyColorcmb.FormattingEnabled = true;
            BodyColorcmb.Location = new Point(509, 236);
            BodyColorcmb.Name = "BodyColorcmb";
            BodyColorcmb.Size = new Size(122, 36);
            BodyColorcmb.TabIndex = 22;
            // 
            // ChestColorcmb
            // 
            ChestColorcmb.FormattingEnabled = true;
            ChestColorcmb.Items.AddRange(new object[] { "Purple", "Lilac", "White" });
            ChestColorcmb.Location = new Point(509, 184);
            ChestColorcmb.Name = "ChestColorcmb";
            ChestColorcmb.Size = new Size(122, 36);
            ChestColorcmb.TabIndex = 21;
            // 
            // HeadColorcmb
            // 
            HeadColorcmb.FormattingEnabled = true;
            HeadColorcmb.Items.AddRange(new object[] { "Red", "Black", "Yellow" });
            HeadColorcmb.Location = new Point(509, 134);
            HeadColorcmb.Name = "HeadColorcmb";
            HeadColorcmb.Size = new Size(122, 36);
            HeadColorcmb.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(375, 236);
            label10.Name = "label10";
            label10.Size = new Size(116, 28);
            label10.TabIndex = 19;
            label10.Text = "Body Color";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 185);
            label9.Name = "label9";
            label9.Size = new Size(120, 28);
            label9.TabIndex = 18;
            label9.Text = "Chest Color";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 134);
            label8.Name = "label8";
            label8.Size = new Size(117, 28);
            label8.TabIndex = 17;
            label8.Text = "Head Color";
            // 
            // birdExitBtn
            // 
            birdExitBtn.BackColor = Color.FromArgb(192, 57, 43);
            birdExitBtn.FlatAppearance.BorderSize = 0;
            birdExitBtn.FlatStyle = FlatStyle.Flat;
            birdExitBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            birdExitBtn.ForeColor = Color.White;
            birdExitBtn.Location = new Point(639, 365);
            birdExitBtn.Margin = new Padding(4, 5, 4, 5);
            birdExitBtn.Name = "birdExitBtn";
            birdExitBtn.Size = new Size(100, 36);
            birdExitBtn.TabIndex = 16;
            birdExitBtn.Text = "Exit";
            birdExitBtn.UseVisualStyleBackColor = false;
            birdExitBtn.Click += birdExitBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(44, 62, 80);
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.White;
            BackBtn.Location = new Point(640, 315);
            BackBtn.Margin = new Padding(4, 5, 4, 5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(127, 40);
            BackBtn.TabIndex = 15;
            BackBtn.Text = "Main menu";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // FinalAddbtn
            // 
            FinalAddbtn.BackColor = Color.FromArgb(44, 62, 80);
            FinalAddbtn.Cursor = Cursors.Hand;
            FinalAddbtn.FlatAppearance.BorderSize = 0;
            FinalAddbtn.FlatStyle = FlatStyle.Flat;
            FinalAddbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            FinalAddbtn.ForeColor = Color.White;
            FinalAddbtn.Location = new Point(639, 274);
            FinalAddbtn.Name = "FinalAddbtn";
            FinalAddbtn.Size = new Size(128, 33);
            FinalAddbtn.TabIndex = 14;
            FinalAddbtn.Text = "Add";
            FinalAddbtn.UseVisualStyleBackColor = false;
            FinalAddbtn.Click += FinalAddbtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(481, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 29);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cagenumber
            // 
            cagenumber.Location = new Point(509, 89);
            cagenumber.Name = "cagenumber";
            cagenumber.Size = new Size(128, 34);
            cagenumber.TabIndex = 12;
            // 
            // fatherserialnumber
            // 
            fatherserialnumber.Location = new Point(236, 315);
            fatherserialnumber.Name = "fatherserialnumber";
            fatherserialnumber.Size = new Size(124, 34);
            fatherserialnumber.TabIndex = 11;
            // 
            // motherserialnumber
            // 
            motherserialnumber.Location = new Point(236, 260);
            motherserialnumber.Name = "motherserialnumber";
            motherserialnumber.Size = new Size(124, 34);
            motherserialnumber.TabIndex = 10;
            // 
            // GendercomboBox
            // 
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "Male", "Female" });
            GendercomboBox.Location = new Point(143, 182);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(183, 36);
            GendercomboBox.TabIndex = 9;
            GendercomboBox.SelectedIndexChanged += GendercomboBox_SelectedIndexChanged;
            // 
            // SubspeciescomboBox
            // 
            SubspeciescomboBox.FormattingEnabled = true;
            SubspeciescomboBox.Location = new Point(143, 115);
            SubspeciescomboBox.Name = "SubspeciescomboBox";
            SubspeciescomboBox.Size = new Size(183, 36);
            SubspeciescomboBox.TabIndex = 8;
            SubspeciescomboBox.SelectedIndexChanged += SubspeciescomboBox_SelectedIndexChanged;
            // 
            // SpeciescomboBox
            // 
            SpeciescomboBox.FormattingEnabled = true;
            SpeciescomboBox.Items.AddRange(new object[] { "American Gouldian", "European Gouldian", "Australian Gouldian" });
            SpeciescomboBox.Location = new Point(143, 52);
            SpeciescomboBox.Name = "SpeciescomboBox";
            SpeciescomboBox.Size = new Size(183, 36);
            SpeciescomboBox.TabIndex = 7;
            SpeciescomboBox.SelectedIndexChanged += SpeciescomboBox_SelectedIndex;
            // 
            // label7
            // 
            label7.Location = new Point(350, 44);
            label7.Name = "label7";
            label7.Size = new Size(141, 48);
            label7.TabIndex = 6;
            label7.Text = "Hatch date:";
            // 
            // label6
            // 
            label6.Location = new Point(350, 92);
            label6.Name = "label6";
            label6.Size = new Size(153, 42);
            label6.TabIndex = 5;
            label6.Text = "Cage number :";
            // 
            // label5
            // 
            label5.Location = new Point(10, 320);
            label5.Name = "label5";
            label5.Size = new Size(234, 62);
            label5.TabIndex = 4;
            label5.Text = "Father serial number:";
            // 
            // label4
            // 
            label4.Location = new Point(10, 260);
            label4.Name = "label4";
            label4.Size = new Size(230, 48);
            label4.TabIndex = 3;
            label4.Text = "Mother serial number:";
            // 
            // label3
            // 
            label3.Location = new Point(10, 182);
            label3.Name = "label3";
            label3.Size = new Size(89, 38);
            label3.TabIndex = 2;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.Location = new Point(10, 115);
            label2.Name = "label2";
            label2.Size = new Size(127, 38);
            label2.TabIndex = 1;
            label2.Text = "Subspecies:";
            // 
            // label1
            // 
            label1.Location = new Point(10, 52);
            label1.Name = "label1";
            label1.Size = new Size(89, 38);
            label1.TabIndex = 0;
            label1.Text = "Species:";
            // 
            // Addbird
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Addbird";
            Text = "Addbird";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox cagenumber;
        private TextBox fatherserialnumber;
        private TextBox motherserialnumber;
        private ComboBox GendercomboBox;
        private ComboBox SubspeciescomboBox;
        private ComboBox SpeciescomboBox;
        private Button FinalAddbtn;
        private Button BackBtn;
        private Button birdExitBtn;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox BodyColorcmb;
        private ComboBox ChestColorcmb;
        private ComboBox HeadColorcmb;
    }
}