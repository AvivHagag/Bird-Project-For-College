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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SpecieBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.birdSearchBox = new System.Windows.Forms.ComboBox();
            this.dataGridBirds = new System.Windows.Forms.DataGridView();
            this.birdIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birdSpeciceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subSpecieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBirds)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.idTextBox);
            this.searchGroup.Controls.Add(this.datePicker);
            this.searchGroup.Controls.Add(this.SpecieBox);
            this.searchGroup.Controls.Add(this.searchBtn);
            this.searchGroup.Controls.Add(this.birdSearchBox);
            this.searchGroup.Controls.Add(this.dataGridBirds);
            this.searchGroup.Location = new System.Drawing.Point(12, 12);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(1156, 388);
            this.searchGroup.TabIndex = 1;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search bird";
            this.searchGroup.Enter += new System.EventHandler(this.searchGroup_Enter);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(55, 124);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.Visible = false;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(6, 124);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 23);
            this.datePicker.TabIndex = 3;
            this.datePicker.Visible = false;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SpecieBox
            // 
            this.SpecieBox.FormattingEnabled = true;
            this.SpecieBox.Location = new System.Drawing.Point(45, 124);
            this.SpecieBox.Name = "SpecieBox";
            this.SpecieBox.Size = new System.Drawing.Size(121, 23);
            this.SpecieBox.TabIndex = 2;
            this.SpecieBox.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(71, 192);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // birdSearchBox
            // 
            this.birdSearchBox.FormattingEnabled = true;
            this.birdSearchBox.Items.AddRange(new object[] {
            "Bird ID",
            "Specie",
            "Hatch date",
            "Gender"});
            this.birdSearchBox.Location = new System.Drawing.Point(45, 95);
            this.birdSearchBox.Name = "birdSearchBox";
            this.birdSearchBox.Size = new System.Drawing.Size(121, 23);
            this.birdSearchBox.TabIndex = 0;
            this.birdSearchBox.SelectedIndexChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            // 
            // dataGridBirds
            // 
            this.dataGridBirds.AllowUserToAddRows = false;
            this.dataGridBirds.AllowUserToResizeColumns = false;
            this.dataGridBirds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBirds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.birdIDColumn,
            this.birdSpeciceColumn,
            this.subSpecieColumn,
            this.genderColumn,
            this.motherColumn,
            this.fatherColumn,
            this.dateColumn,
            this.cageColumn,
            this.userColumn});
            this.dataGridBirds.Location = new System.Drawing.Point(214, 4);
            this.dataGridBirds.Name = "dataGridBirds";
            this.dataGridBirds.RowTemplate.Height = 25;
            this.dataGridBirds.Size = new System.Drawing.Size(944, 384);
            this.dataGridBirds.TabIndex = 5;
            this.dataGridBirds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // birdIDColumn
            // 
            this.birdIDColumn.HeaderText = "Bird ID";
            this.birdIDColumn.Name = "birdIDColumn";
            // 
            // birdSpeciceColumn
            // 
            this.birdSpeciceColumn.HeaderText = "Specie";
            this.birdSpeciceColumn.Name = "birdSpeciceColumn";
            // 
            // subSpecieColumn
            // 
            this.subSpecieColumn.HeaderText = "Sub Specie";
            this.subSpecieColumn.Name = "subSpecieColumn";
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.Name = "genderColumn";
            // 
            // motherColumn
            // 
            this.motherColumn.HeaderText = "Mother";
            this.motherColumn.Name = "motherColumn";
            // 
            // fatherColumn
            // 
            this.fatherColumn.HeaderText = "Father";
            this.fatherColumn.Name = "fatherColumn";
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            // 
            // cageColumn
            // 
            this.cageColumn.HeaderText = "Cage ID";
            this.cageColumn.Name = "cageColumn";
            // 
            // userColumn
            // 
            this.userColumn.HeaderText = "User ID";
            this.userColumn.Name = "userColumn";
            // 
            // Searchbird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 426);
            this.Controls.Add(this.searchGroup);
            this.Name = "Searchbird";
            this.Text = "Searchbird";
            this.Load += new System.EventHandler(this.Searchbird_Load);
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBirds)).EndInit();
            this.ResumeLayout(false);

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
    }
}