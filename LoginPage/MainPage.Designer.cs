namespace LoginPage
{
    partial class MainPage
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
            Mplabel = new Label();
            AddBbtn = new Button();
            Addcbtn = new Button();
            SearchBbtn = new Button();
            SearchCbtn = new Button();
            Addbirdgroupbox = new GroupBox();
            FinalAddbtn = new Button();
            GendercomboBox = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SpeciescomboBox = new ComboBox();
            label7 = new Label();
            SubspeciescomboBox = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Addbirdgroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // Mplabel
            // 
            Mplabel.Font = new Font("David", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Mplabel.Location = new Point(44, 39);
            Mplabel.Name = "Mplabel";
            Mplabel.Size = new Size(137, 62);
            Mplabel.TabIndex = 0;
            Mplabel.Text = "Main Page";
            // 
            // AddBbtn
            // 
            AddBbtn.Location = new Point(44, 104);
            AddBbtn.Name = "AddBbtn";
            AddBbtn.Size = new Size(112, 32);
            AddBbtn.TabIndex = 1;
            AddBbtn.Text = "Add Bird";
            AddBbtn.UseVisualStyleBackColor = true;
            AddBbtn.Click += AddBbtn_Click;
            // 
            // Addcbtn
            // 
            Addcbtn.Location = new Point(190, 104);
            Addcbtn.Name = "Addcbtn";
            Addcbtn.Size = new Size(112, 34);
            Addcbtn.TabIndex = 2;
            Addcbtn.Text = "Add Cage";
            Addcbtn.UseVisualStyleBackColor = true;
            Addcbtn.Click += button2_Click;
            // 
            // SearchBbtn
            // 
            SearchBbtn.Location = new Point(348, 104);
            SearchBbtn.Name = "SearchBbtn";
            SearchBbtn.Size = new Size(112, 34);
            SearchBbtn.TabIndex = 3;
            SearchBbtn.Text = "Search Bird";
            SearchBbtn.UseVisualStyleBackColor = true;
            // 
            // SearchCbtn
            // 
            SearchCbtn.Location = new Point(493, 103);
            SearchCbtn.Name = "SearchCbtn";
            SearchCbtn.Size = new Size(147, 34);
            SearchCbtn.TabIndex = 4;
            SearchCbtn.Text = "Search Cage";
            SearchCbtn.UseVisualStyleBackColor = true;
            // 
            // Addbirdgroupbox
            // 
            Addbirdgroupbox.Controls.Add(FinalAddbtn);
            Addbirdgroupbox.Controls.Add(GendercomboBox);
            Addbirdgroupbox.Controls.Add(textBox4);
            Addbirdgroupbox.Controls.Add(textBox3);
            Addbirdgroupbox.Controls.Add(textBox1);
            Addbirdgroupbox.Controls.Add(textBox2);
            Addbirdgroupbox.Controls.Add(SpeciescomboBox);
            Addbirdgroupbox.Controls.Add(label7);
            Addbirdgroupbox.Controls.Add(SubspeciescomboBox);
            Addbirdgroupbox.Controls.Add(label6);
            Addbirdgroupbox.Controls.Add(label1);
            Addbirdgroupbox.Controls.Add(label5);
            Addbirdgroupbox.Controls.Add(label4);
            Addbirdgroupbox.Controls.Add(label3);
            Addbirdgroupbox.Controls.Add(label2);
            Addbirdgroupbox.Location = new Point(12, 160);
            Addbirdgroupbox.Name = "Addbirdgroupbox";
            Addbirdgroupbox.Size = new Size(628, 293);
            Addbirdgroupbox.TabIndex = 5;
            Addbirdgroupbox.TabStop = false;
            Addbirdgroupbox.Text = "Add bird";
            Addbirdgroupbox.Visible = false;
            // 
            // FinalAddbtn
            // 
            FinalAddbtn.BackColor = Color.CornflowerBlue;
            FinalAddbtn.Location = new Point(491, 253);
            FinalAddbtn.Name = "FinalAddbtn";
            FinalAddbtn.Size = new Size(112, 34);
            FinalAddbtn.TabIndex = 16;
            FinalAddbtn.Text = "Add";
            FinalAddbtn.UseVisualStyleBackColor = false;
            // 
            // GendercomboBox
            // 
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "Male", "Female" });
            GendercomboBox.Location = new Point(133, 142);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(123, 33);
            GendercomboBox.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(475, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(35, 31);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(444, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 31);
            textBox3.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 31);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 31);
            textBox2.TabIndex = 11;
            // 
            // SpeciescomboBox
            // 
            SpeciescomboBox.FormattingEnabled = true;
            SpeciescomboBox.Items.AddRange(new object[] { "American Gouldian", "European Gouldian", "Australian Gouldian" });
            SpeciescomboBox.Location = new Point(133, 27);
            SpeciescomboBox.Name = "SpeciescomboBox";
            SpeciescomboBox.Size = new Size(171, 33);
            SpeciescomboBox.TabIndex = 9;
            SpeciescomboBox.SelectedIndexChanged += SpeciescomboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 27);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 8;
            label7.Text = "species:";
            // 
            // SubspeciescomboBox
            // 
            SubspeciescomboBox.FormattingEnabled = true;
            SubspeciescomboBox.Location = new Point(133, 81);
            SubspeciescomboBox.Name = "SubspeciescomboBox";
            SubspeciescomboBox.Size = new Size(148, 33);
            SubspeciescomboBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 202);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 6;
            label6.Text = "father serial number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 200);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 5;
            label1.Text = "mother serial number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 35);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 4;
            label5.Text = "hatch date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 103);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 3;
            label4.Text = "cage number ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 142);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 2;
            label3.Text = "gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 84);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "subspecies:";
            label2.Click += label2_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 750);
            Controls.Add(Addbirdgroupbox);
            Controls.Add(SearchCbtn);
            Controls.Add(SearchBbtn);
            Controls.Add(Addcbtn);
            Controls.Add(AddBbtn);
            Controls.Add(Mplabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainPage";
            Text = "got";
            Load += MainPage_Load;
            Addbirdgroupbox.ResumeLayout(false);
            Addbirdgroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Mplabel;
        private Button AddBbtn;
        private Button Addcbtn;
        private Button SearchBbtn;
        private Button SearchCbtn;
        private GroupBox Addbirdgroupbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox SpeciescomboBox;
        private Label label7;
        private ComboBox SubspeciescomboBox;
        private Label label6;
        private Label label1;
        private ComboBox GendercomboBox;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button FinalAddbtn;
    }
}