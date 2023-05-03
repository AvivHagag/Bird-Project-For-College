namespace LoginPage
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
            groupBox1.Location = new Point(8, 16);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(519, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Bird";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // birdExitBtn
            // 
            birdExitBtn.Location = new Point(334, 192);
            birdExitBtn.Name = "birdExitBtn";
            birdExitBtn.Size = new Size(138, 23);
            birdExitBtn.TabIndex = 16;
            birdExitBtn.Text = "Exit";
            birdExitBtn.UseVisualStyleBackColor = true;
            birdExitBtn.Click += birdExitBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(334, 160);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(138, 23);
            BackBtn.TabIndex = 15;
            BackBtn.Text = "Main menu";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // FinalAddbtn
            // 
            FinalAddbtn.Location = new Point(334, 109);
            FinalAddbtn.Margin = new Padding(2);
            FinalAddbtn.Name = "FinalAddbtn";
            FinalAddbtn.Size = new Size(138, 46);
            FinalAddbtn.TabIndex = 14;
            FinalAddbtn.Text = "Add";
            FinalAddbtn.UseVisualStyleBackColor = true;
            FinalAddbtn.Click += FinalAddbtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(334, 31);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cagenumber
            // 
            cagenumber.Location = new Point(334, 69);
            cagenumber.Margin = new Padding(2);
            cagenumber.Name = "cagenumber";
            cagenumber.Size = new Size(91, 23);
            cagenumber.TabIndex = 12;
            // 
            // fatherserialnumber
            // 
            fatherserialnumber.Location = new Point(155, 184);
            fatherserialnumber.Margin = new Padding(2);
            fatherserialnumber.Name = "fatherserialnumber";
            fatherserialnumber.Size = new Size(88, 23);
            fatherserialnumber.TabIndex = 11;
            // 
            // motherserialnumber
            // 
            motherserialnumber.Location = new Point(155, 148);
            motherserialnumber.Margin = new Padding(2);
            motherserialnumber.Name = "motherserialnumber";
            motherserialnumber.Size = new Size(88, 23);
            motherserialnumber.TabIndex = 10;
            // 
            // GendercomboBox
            // 
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "Male", "Female" });
            GendercomboBox.Location = new Point(100, 109);
            GendercomboBox.Margin = new Padding(2);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(129, 23);
            GendercomboBox.TabIndex = 9;
            // 
            // SubspeciescomboBox
            // 
            SubspeciescomboBox.FormattingEnabled = true;
            SubspeciescomboBox.Location = new Point(100, 69);
            SubspeciescomboBox.Margin = new Padding(2);
            SubspeciescomboBox.Name = "SubspeciescomboBox";
            SubspeciescomboBox.Size = new Size(129, 23);
            SubspeciescomboBox.TabIndex = 8;
            SubspeciescomboBox.SelectedIndexChanged += SubspeciescomboBox_SelectedIndexChanged;
            // 
            // SpeciescomboBox
            // 
            SpeciescomboBox.FormattingEnabled = true;
            SpeciescomboBox.Items.AddRange(new object[] { "American Gouldian", "European Gouldian", "Australian Gouldian" });
            SpeciescomboBox.Location = new Point(100, 31);
            SpeciescomboBox.Margin = new Padding(2);
            SpeciescomboBox.Name = "SpeciescomboBox";
            SpeciescomboBox.Size = new Size(129, 23);
            SpeciescomboBox.TabIndex = 7;
            SpeciescomboBox.SelectedIndexChanged += SpeciescomboBox_SelectedIndex;
            // 
            // label7
            // 
            label7.Location = new Point(246, 31);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 6;
            label7.Text = "hatch date:";
            // 
            // label6
            // 
            label6.Location = new Point(246, 69);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 5;
            label6.Text = "cage number ";
            // 
            // label5
            // 
            label5.Location = new Point(4, 192);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 4;
            label5.Text = "father serial number:";
            // 
            // label4
            // 
            label4.Location = new Point(4, 156);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 3;
            label4.Text = "mother serial number:";
            // 
            // label3
            // 
            label3.Location = new Point(7, 109);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 2;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.Location = new Point(7, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 1;
            label2.Text = "subspecies:";
            // 
            // label1
            // 
            label1.Location = new Point(7, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "species:";
            // 
            // Addbird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 270);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
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
    }
}