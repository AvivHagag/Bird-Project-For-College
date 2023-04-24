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
            dateTimePicker1 = new DateTimePicker();
            FinalAddbtn = new Button();
            GendercomboBox = new ComboBox();
            fatherserialnumber = new TextBox();
            cagenumber = new TextBox();
            motherserialnumber = new TextBox();
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
            Mplabel.Location = new Point(31, 23);
            Mplabel.Margin = new Padding(2, 0, 2, 0);
            Mplabel.Name = "Mplabel";
            Mplabel.Size = new Size(96, 37);
            Mplabel.TabIndex = 0;
            Mplabel.Text = "Main Page";
            // 
            // AddBbtn
            // 
            AddBbtn.Location = new Point(31, 62);
            AddBbtn.Margin = new Padding(2);
            AddBbtn.Name = "AddBbtn";
            AddBbtn.Size = new Size(85, 30);
            AddBbtn.TabIndex = 1;
            AddBbtn.Text = "Add Bird";
            AddBbtn.UseVisualStyleBackColor = true;
            AddBbtn.Click += AddBbtn_Click;
            // 
            // Addcbtn
            // 
            Addcbtn.Location = new Point(133, 62);
            Addcbtn.Margin = new Padding(2);
            Addcbtn.Name = "Addcbtn";
            Addcbtn.Size = new Size(89, 30);
            Addcbtn.TabIndex = 2;
            Addcbtn.Text = "Add Cage";
            Addcbtn.UseVisualStyleBackColor = true;
            // 
            // SearchBbtn
            // 
            SearchBbtn.Location = new Point(244, 62);
            SearchBbtn.Margin = new Padding(2);
            SearchBbtn.Name = "SearchBbtn";
            SearchBbtn.Size = new Size(87, 30);
            SearchBbtn.TabIndex = 3;
            SearchBbtn.Text = "Search Bird";
            SearchBbtn.UseVisualStyleBackColor = true;
            // 
            // SearchCbtn
            // 
            SearchCbtn.Location = new Point(345, 62);
            SearchCbtn.Margin = new Padding(2);
            SearchCbtn.Name = "SearchCbtn";
            SearchCbtn.Size = new Size(89, 30);
            SearchCbtn.TabIndex = 4;
            SearchCbtn.Text = "Search Cage";
            SearchCbtn.UseVisualStyleBackColor = true;
            // 
            // Addbirdgroupbox
            // 
            Addbirdgroupbox.Controls.Add(dateTimePicker1);
            Addbirdgroupbox.Controls.Add(FinalAddbtn);
            Addbirdgroupbox.Controls.Add(GendercomboBox);
            Addbirdgroupbox.Controls.Add(fatherserialnumber);
            Addbirdgroupbox.Controls.Add(cagenumber);
            Addbirdgroupbox.Controls.Add(motherserialnumber);
            Addbirdgroupbox.Controls.Add(SpeciescomboBox);
            Addbirdgroupbox.Controls.Add(label7);
            Addbirdgroupbox.Controls.Add(SubspeciescomboBox);
            Addbirdgroupbox.Controls.Add(label6);
            Addbirdgroupbox.Controls.Add(label1);
            Addbirdgroupbox.Controls.Add(label5);
            Addbirdgroupbox.Controls.Add(label4);
            Addbirdgroupbox.Controls.Add(label3);
            Addbirdgroupbox.Controls.Add(label2);
            Addbirdgroupbox.Location = new Point(8, 96);
            Addbirdgroupbox.Margin = new Padding(2);
            Addbirdgroupbox.Name = "Addbirdgroupbox";
            Addbirdgroupbox.Padding = new Padding(2);
            Addbirdgroupbox.Size = new Size(489, 224);
            Addbirdgroupbox.TabIndex = 5;
            Addbirdgroupbox.TabStop = false;
            Addbirdgroupbox.Text = "Add bird";
            Addbirdgroupbox.Visible = false;
            Addbirdgroupbox.Enter += Addbirdgroupbox_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(304, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 23);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // FinalAddbtn
            // 
            FinalAddbtn.BackColor = Color.CornflowerBlue;
            FinalAddbtn.Location = new Point(304, 101);
            FinalAddbtn.Margin = new Padding(2);
            FinalAddbtn.Name = "FinalAddbtn";
            FinalAddbtn.Size = new Size(180, 41);
            FinalAddbtn.TabIndex = 16;
            FinalAddbtn.Text = "Add";
            FinalAddbtn.UseVisualStyleBackColor = false;
            FinalAddbtn.Click += FinalAddbtn_Click;
            // 
            // GendercomboBox
            // 
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "Male", "Female" });
            GendercomboBox.Location = new Point(93, 85);
            GendercomboBox.Margin = new Padding(2);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(105, 23);
            GendercomboBox.TabIndex = 15;
            // 
            // fatherserialnumber
            // 
            fatherserialnumber.Location = new Point(137, 155);
            fatherserialnumber.Margin = new Padding(2);
            fatherserialnumber.Name = "fatherserialnumber";
            fatherserialnumber.Size = new Size(51, 23);
            fatherserialnumber.TabIndex = 14;
            // 
            // cagenumber
            // 
            cagenumber.Location = new Point(137, 189);
            cagenumber.Margin = new Padding(2);
            cagenumber.Name = "cagenumber";
            cagenumber.Size = new Size(51, 23);
            cagenumber.TabIndex = 13;
            // 
            // motherserialnumber
            // 
            motherserialnumber.Location = new Point(137, 119);
            motherserialnumber.Margin = new Padding(2);
            motherserialnumber.Name = "motherserialnumber";
            motherserialnumber.Size = new Size(51, 23);
            motherserialnumber.TabIndex = 11;
            motherserialnumber.TextChanged += motherserialnumber_TextChanged;
            // 
            // SpeciescomboBox
            // 
            SpeciescomboBox.FormattingEnabled = true;
            SpeciescomboBox.Items.AddRange(new object[] { "American Gouldian", "European Gouldian", "Australian Gouldian" });
            SpeciescomboBox.Location = new Point(93, 16);
            SpeciescomboBox.Margin = new Padding(2);
            SpeciescomboBox.Name = "SpeciescomboBox";
            SpeciescomboBox.Size = new Size(121, 23);
            SpeciescomboBox.TabIndex = 9;
            SpeciescomboBox.SelectedIndexChanged += SpeciescomboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 16);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 8;
            label7.Text = "species:";
            // 
            // SubspeciescomboBox
            // 
            SubspeciescomboBox.FormattingEnabled = true;
            SubspeciescomboBox.Location = new Point(93, 49);
            SubspeciescomboBox.Margin = new Padding(2);
            SubspeciescomboBox.Name = "SubspeciescomboBox";
            SubspeciescomboBox.Size = new Size(105, 23);
            SubspeciescomboBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 155);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 6;
            label6.Text = "father serial number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 119);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 5;
            label1.Text = "mother serial number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 16);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "hatch date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 189);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "cage number ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "subspecies:";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(508, 450);
            Controls.Add(Addbirdgroupbox);
            Controls.Add(SearchCbtn);
            Controls.Add(SearchBbtn);
            Controls.Add(Addcbtn);
            Controls.Add(AddBbtn);
            Controls.Add(Mplabel);
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
        private TextBox fatherserialnumber;
        private TextBox cagenumber;
        private TextBox motherserialnumber;
        private Button FinalAddbtn;
        private DateTimePicker dateTimePicker1;
    }
}