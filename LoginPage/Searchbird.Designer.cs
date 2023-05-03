﻿namespace LoginPage
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
            searchLabel = new Label();
            addChickLabels = new Label();
            exitBtn = new Button();
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
            searchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBirds).BeginInit();
            SuspendLayout();
            // 
            // searchGroup
            // 
            searchGroup.Controls.Add(searchLabel);
            searchGroup.Controls.Add(addChickLabels);
            searchGroup.Controls.Add(exitBtn);
            searchGroup.Controls.Add(birdMainMenuBtn);
            searchGroup.Controls.Add(idTextBox);
            searchGroup.Controls.Add(datePicker);
            searchGroup.Controls.Add(SpecieBox);
            searchGroup.Controls.Add(searchBtn);
            searchGroup.Controls.Add(birdSearchBox);
            searchGroup.Controls.Add(dataGridBirds);
            searchGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            searchGroup.ForeColor = Color.FromArgb(44, 62, 80);
            searchGroup.Location = new Point(12, 12);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(1203, 436);
            searchGroup.TabIndex = 1;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search bird";
            searchGroup.Enter += searchGroup_Enter;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(45, 73);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(117, 19);
            searchLabel.TabIndex = 9;
            searchLabel.Text = "Choose to filter:";
            // 
            // addChickLabels
            // 
            addChickLabels.AutoSize = true;
            addChickLabels.ForeColor = SystemColors.Highlight;
            addChickLabels.Location = new Point(630, 21);
            addChickLabels.Name = "addChickLabels";
            addChickLabels.Size = new Size(256, 19);
            addChickLabels.TabIndex = 8;
            addChickLabels.Text = "Double click to add chick to the bird.";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(192, 57, 43);
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(60, 266);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(95, 25);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // birdMainMenuBtn
            // 
            birdMainMenuBtn.BackColor = Color.FromArgb(44, 62, 80);
            birdMainMenuBtn.Cursor = Cursors.Hand;
            birdMainMenuBtn.FlatAppearance.BorderSize = 0;
            birdMainMenuBtn.FlatStyle = FlatStyle.Flat;
            birdMainMenuBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            birdMainMenuBtn.ForeColor = Color.White;
            birdMainMenuBtn.Location = new Point(60, 221);
            birdMainMenuBtn.Name = "birdMainMenuBtn";
            birdMainMenuBtn.Size = new Size(95, 25);
            birdMainMenuBtn.TabIndex = 2;
            birdMainMenuBtn.Text = "Main menu";
            birdMainMenuBtn.UseVisualStyleBackColor = false;
            birdMainMenuBtn.Click += birdMainMenuBtn_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(55, 124);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 25);
            idTextBox.TabIndex = 4;
            idTextBox.Visible = false;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(6, 124);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 22);
            datePicker.TabIndex = 3;
            datePicker.Visible = false;
            datePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // SpecieBox
            // 
            SpecieBox.FormattingEnabled = true;
            SpecieBox.Location = new Point(45, 124);
            SpecieBox.Name = "SpecieBox";
            SpecieBox.Size = new Size(121, 25);
            SpecieBox.TabIndex = 2;
            SpecieBox.Visible = false;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(44, 62, 80);
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(60, 192);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(95, 25);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // birdSearchBox
            // 
            birdSearchBox.FormattingEnabled = true;
            birdSearchBox.Items.AddRange(new object[] { "Bird ID", "Specie", "Hatch date", "Gender" });
            birdSearchBox.Location = new Point(45, 95);
            birdSearchBox.Name = "birdSearchBox";
            birdSearchBox.Size = new Size(121, 25);
            birdSearchBox.TabIndex = 0;
            birdSearchBox.SelectedIndexChanged += searchBox_SelectedIndexChanged;
            //
            // dataGridBirds
            //
            dataGridBirds.AllowUserToAddRows = false;
            dataGridBirds.AllowUserToDeleteRows = false;
            dataGridBirds.AllowUserToResizeRows = false;
            dataGridBirds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBirds.BackgroundColor = SystemColors.ControlLightLight;
            dataGridBirds.BorderStyle = BorderStyle.None;
            dataGridBirds.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBirds.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBirds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBirds.Columns.AddRange(new DataGridViewColumn[] { birdIDColumn, birdSpeciceColumn, subSpecieColumn, genderColumn, motherColumn, fatherColumn, dateColumn, cageColumn, userColumn });
            dataGridBirds.EnableHeadersVisualStyles = false;
            dataGridBirds.GridColor = SystemColors.ControlLight;
            dataGridBirds.Location = new Point(251, 46);
            dataGridBirds.MultiSelect = false;
            dataGridBirds.Name = "dataGridBirds";
            dataGridBirds.ReadOnly = true;
            dataGridBirds.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBirds.RowHeadersVisible = false;
            dataGridBirds.RowTemplate.Height = 25;
            dataGridBirds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBirds.Size = new Size(944, 384);
            dataGridBirds.TabIndex = 5;
            dataGridBirds.TabStop = false;
            dataGridBirds.CellDoubleClick += dataGridBirds_CellDoubleClick;

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
            // Searchbird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 450);
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
        private Label addChickLabels;
        private Label searchLabel;
    }
}