namespace LoginPage
{
    partial class Searchbird
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            searchGroup = new GroupBox();
            birdMainMenuBtn = new Button();
            idTextBox = new TextBox();
            datePicker = new DateTimePicker();
            SpecieBox = new ComboBox();
            searchBtn = new Button();
            birdSearchBox = new ComboBox();
            dataGridBirds = new DataGridView();
            birdIDColumn = new DataGridViewTextBoxColumn();
            birdSpeciceColumn = new DataGridViewTextBoxColumn();
            subSpecieColumn = new DataGridViewTextBoxColumn();
            genderColumn = new DataGridViewTextBoxColumn();
            motherColumn = new DataGridViewTextBoxColumn();
            fatherColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            cageColumn = new DataGridViewTextBoxColumn();
            userColumn = new DataGridViewTextBoxColumn();
            exitBtn = new Button();
            searchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBirds).BeginInit();
            SuspendLayout();
            // 
            // searchGroup
            // 
            searchGroup.Controls.Add(exitBtn);
            searchGroup.Controls.Add(birdMainMenuBtn);
            searchGroup.Controls.Add(idTextBox);
            searchGroup.Controls.Add(datePicker);
            searchGroup.Controls.Add(SpecieBox);
            searchGroup.Controls.Add(searchBtn);
            searchGroup.Controls.Add(birdSearchBox);
            searchGroup.Controls.Add(dataGridBirds);
            searchGroup.Location = new Point(12, 12);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(1156, 388);
            searchGroup.TabIndex = 1;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search bird";
            searchGroup.Enter += searchGroup_Enter;
            // 
            // birdMainMenuBtn
            // 
            birdMainMenuBtn.Location = new Point(60, 221);
            birdMainMenuBtn.Name = "birdMainMenuBtn";
            birdMainMenuBtn.Size = new Size(95, 23);
            birdMainMenuBtn.TabIndex = 2;
            birdMainMenuBtn.Text = "Main menu";
            birdMainMenuBtn.UseVisualStyleBackColor = true;
            birdMainMenuBtn.Click += birdMainMenuBtn_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(55, 124);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 4;
            idTextBox.Visible = false;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(6, 124);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 3;
            datePicker.Visible = false;
            datePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // SpecieBox
            // 
            SpecieBox.FormattingEnabled = true;
            SpecieBox.Location = new Point(45, 124);
            SpecieBox.Name = "SpecieBox";
            SpecieBox.Size = new Size(121, 23);
            SpecieBox.TabIndex = 2;
            SpecieBox.Visible = false;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(60, 192);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(95, 23);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // birdSearchBox
            // 
            birdSearchBox.FormattingEnabled = true;
            birdSearchBox.Items.AddRange(new object[] { "Bird ID", "Specie", "Hatch date", "Gender" });
            birdSearchBox.Location = new Point(45, 95);
            birdSearchBox.Name = "birdSearchBox";
            birdSearchBox.Size = new Size(121, 23);
            birdSearchBox.TabIndex = 0;
            birdSearchBox.SelectedIndexChanged += searchBox_SelectedIndexChanged;
            // 
            // dataGridBirds
            // 
            dataGridBirds.AllowUserToAddRows = false;
            dataGridBirds.AllowUserToResizeColumns = false;
            dataGridBirds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBirds.Columns.AddRange(new DataGridViewColumn[] { birdIDColumn, birdSpeciceColumn, subSpecieColumn, genderColumn, motherColumn, fatherColumn, dateColumn, cageColumn, userColumn });
            dataGridBirds.Location = new Point(214, 4);
            dataGridBirds.Name = "dataGridBirds";
            dataGridBirds.RowTemplate.Height = 25;
            dataGridBirds.Size = new Size(944, 384);
            dataGridBirds.TabIndex = 5;
            dataGridBirds.CellContentClick += dataGridView1_CellContentClick;
            // 
            // birdIDColumn
            // 
            birdIDColumn.HeaderText = "Bird ID";
            birdIDColumn.Name = "birdIDColumn";
            // 
            // birdSpeciceColumn
            // 
            birdSpeciceColumn.HeaderText = "Specie";
            birdSpeciceColumn.Name = "birdSpeciceColumn";
            // 
            // subSpecieColumn
            // 
            subSpecieColumn.HeaderText = "Sub Specie";
            subSpecieColumn.Name = "subSpecieColumn";
            // 
            // genderColumn
            // 
            genderColumn.HeaderText = "Gender";
            genderColumn.Name = "genderColumn";
            // 
            // motherColumn
            // 
            motherColumn.HeaderText = "Mother";
            motherColumn.Name = "motherColumn";
            // 
            // fatherColumn
            // 
            fatherColumn.HeaderText = "Father";
            fatherColumn.Name = "fatherColumn";
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.Name = "dateColumn";
            // 
            // cageColumn
            // 
            cageColumn.HeaderText = "Cage ID";
            cageColumn.Name = "cageColumn";
            // 
            // userColumn
            // 
            userColumn.HeaderText = "User ID";
            userColumn.Name = "userColumn";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(60, 266);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(95, 23);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Searchbird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 426);
            Controls.Add(searchGroup);
            Name = "Searchbird";
            Text = "Searchbird";
            Load += Searchbird_Load;
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBirds).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox searchGroup;
        private ComboBox birdSearchBox;
        private Button searchBtn;
        private ComboBox SpecieBox;
        private DateTimePicker datePicker;
        private TextBox idTextBox;
        private DataGridView dataGridBirds;
        private DataGridViewTextBoxColumn birdIDColumn;
        private DataGridViewTextBoxColumn birdSpeciceColumn;
        private DataGridViewTextBoxColumn subSpecieColumn;
        private DataGridViewTextBoxColumn genderColumn;
        private DataGridViewTextBoxColumn motherColumn;
        private DataGridViewTextBoxColumn fatherColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn cageColumn;
        private DataGridViewTextBoxColumn userColumn;
        private Button birdMainMenuBtn;
        private Button exitBtn;
    }
}