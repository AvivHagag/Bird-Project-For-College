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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FinalAddbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cagenumber = new System.Windows.Forms.TextBox();
            this.fatherserialnumber = new System.Windows.Forms.TextBox();
            this.motherserialnumber = new System.Windows.Forms.TextBox();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.SubspeciescomboBox = new System.Windows.Forms.ComboBox();
            this.SpeciescomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Controls.Add(this.FinalAddbtn);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cagenumber);
            this.groupBox1.Controls.Add(this.fatherserialnumber);
            this.groupBox1.Controls.Add(this.motherserialnumber);
            this.groupBox1.Controls.Add(this.GendercomboBox);
            this.groupBox1.Controls.Add(this.SubspeciescomboBox);
            this.groupBox1.Controls.Add(this.SpeciescomboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(519, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Bird";
            // 
            // BackBtn
            // 
            this.BackBtn.ForeColor = System.Drawing.Color.Black;
            this.BackBtn.Location = new System.Drawing.Point(357, 188);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(102, 23);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Back to Login";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);

            // 
            // FinalAddbtn
            // 
            this.FinalAddbtn.Location = new System.Drawing.Point(334, 112);
            this.FinalAddbtn.Margin = new System.Windows.Forms.Padding(2);
            this.FinalAddbtn.Name = "FinalAddbtn";
            this.FinalAddbtn.Size = new System.Drawing.Size(151, 59);
            this.FinalAddbtn.TabIndex = 14;
            this.FinalAddbtn.Text = "Add";
            this.FinalAddbtn.UseVisualStyleBackColor = true;
            this.FinalAddbtn.Click += new System.EventHandler(this.FinalAddbtn_Click);

            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 23);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cagenumber
            // 
            this.cagenumber.Location = new System.Drawing.Point(334, 69);
            this.cagenumber.Margin = new System.Windows.Forms.Padding(2);
            this.cagenumber.Name = "cagenumber";
            this.cagenumber.Size = new System.Drawing.Size(91, 23);
            this.cagenumber.TabIndex = 12;
            // 
            // fatherserialnumber
            // 
            this.fatherserialnumber.Location = new System.Drawing.Point(155, 184);
            this.fatherserialnumber.Margin = new System.Windows.Forms.Padding(2);
            this.fatherserialnumber.Name = "fatherserialnumber";
            this.fatherserialnumber.Size = new System.Drawing.Size(88, 23);
            this.fatherserialnumber.TabIndex = 11;
            // 
            // motherserialnumber
            // 
            this.motherserialnumber.Location = new System.Drawing.Point(155, 148);
            this.motherserialnumber.Margin = new System.Windows.Forms.Padding(2);
            this.motherserialnumber.Name = "motherserialnumber";
            this.motherserialnumber.Size = new System.Drawing.Size(88, 23);
            this.motherserialnumber.TabIndex = 10;
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GendercomboBox.Location = new System.Drawing.Point(100, 109);
            this.GendercomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(129, 23);
            this.GendercomboBox.TabIndex = 9;
            // 
            // SubspeciescomboBox
            // 
            this.SubspeciescomboBox.FormattingEnabled = true;
            this.SubspeciescomboBox.Location = new System.Drawing.Point(100, 69);
            this.SubspeciescomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SubspeciescomboBox.Name = "SubspeciescomboBox";
            this.SubspeciescomboBox.Size = new System.Drawing.Size(129, 23);
            this.SubspeciescomboBox.TabIndex = 8;
            this.SubspeciescomboBox.SelectedIndexChanged += new System.EventHandler(this.SubspeciescomboBox_SelectedIndexChanged);
            // 
            // SpeciescomboBox
            // 
            this.SpeciescomboBox.FormattingEnabled = true;
            this.SpeciescomboBox.Items.AddRange(new object[] {
            "American Gouldian",
            "European Gouldian",
            "Australian Gouldian"});
            this.SpeciescomboBox.Location = new System.Drawing.Point(100, 31);
            this.SpeciescomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpeciescomboBox.Name = "SpeciescomboBox";
            this.SpeciescomboBox.Size = new System.Drawing.Size(129, 23);
            this.SpeciescomboBox.TabIndex = 7;
            this.SpeciescomboBox.SelectedIndexChanged += new System.EventHandler(this.SpeciescomboBox_SelectedIndex);

            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(246, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "hatch date:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(246, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "cage number ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "father serial number:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "mother serial number:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "subspecies:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "species:";
            // 
            // Addbird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Addbird";
            this.Text = "Addbird";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}