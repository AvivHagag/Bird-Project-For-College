namespace LoginPage
{
    partial class BirdsCage
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
            this.HeadColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChestColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosenCageLable = new System.Windows.Forms.Label();
            this.loginExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBirds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBirds
            // 
            this.dataGridBirds.AllowUserToAddRows = false;
            this.dataGridBirds.AllowUserToDeleteRows = false;
            this.dataGridBirds.AllowUserToResizeRows = false;
            this.dataGridBirds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBirds.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridBirds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBirds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridBirds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridBirds.ColumnHeadersHeight = 42;
            this.dataGridBirds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.birdIDColumn,
            this.birdSpeciceColumn,
            this.subSpecieColumn,
            this.genderColumn,
            this.motherColumn,
            this.fatherColumn,
            this.dateColumn,
            this.cageColumn,
            this.userColumn,
            this.HeadColor,
            this.ChestColor,
            this.BodyColor});
            this.dataGridBirds.EnableHeadersVisualStyles = false;
            this.dataGridBirds.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridBirds.Location = new System.Drawing.Point(20, 45);
            this.dataGridBirds.MultiSelect = false;
            this.dataGridBirds.Name = "dataGridBirds";
            this.dataGridBirds.ReadOnly = true;
            this.dataGridBirds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridBirds.RowHeadersVisible = false;
            this.dataGridBirds.RowHeadersWidth = 62;
            this.dataGridBirds.RowTemplate.Height = 25;
            this.dataGridBirds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBirds.Size = new System.Drawing.Size(1040, 384);
            this.dataGridBirds.TabIndex = 5;
            this.dataGridBirds.TabStop = false;
            // 
            // birdIDColumn
            // 
            this.birdIDColumn.FillWeight = 80F;
            this.birdIDColumn.HeaderText = "Bird ID";
            this.birdIDColumn.MinimumWidth = 8;
            this.birdIDColumn.Name = "birdIDColumn";
            this.birdIDColumn.ReadOnly = true;
            // 
            // birdSpeciceColumn
            // 
            this.birdSpeciceColumn.HeaderText = "Specie";
            this.birdSpeciceColumn.MinimumWidth = 8;
            this.birdSpeciceColumn.Name = "birdSpeciceColumn";
            this.birdSpeciceColumn.ReadOnly = true;
            // 
            // subSpecieColumn
            // 
            this.subSpecieColumn.HeaderText = "Sub Specie";
            this.subSpecieColumn.MinimumWidth = 8;
            this.subSpecieColumn.Name = "subSpecieColumn";
            this.subSpecieColumn.ReadOnly = true;
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.MinimumWidth = 8;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            // 
            // motherColumn
            // 
            this.motherColumn.HeaderText = "Mother";
            this.motherColumn.MinimumWidth = 8;
            this.motherColumn.Name = "motherColumn";
            this.motherColumn.ReadOnly = true;
            // 
            // fatherColumn
            // 
            this.fatherColumn.HeaderText = "Father";
            this.fatherColumn.MinimumWidth = 8;
            this.fatherColumn.Name = "fatherColumn";
            this.fatherColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.MinimumWidth = 8;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // cageColumn
            // 
            this.cageColumn.HeaderText = "Cage ID";
            this.cageColumn.MinimumWidth = 8;
            this.cageColumn.Name = "cageColumn";
            this.cageColumn.ReadOnly = true;
            // 
            // userColumn
            // 
            this.userColumn.HeaderText = "User ID";
            this.userColumn.MinimumWidth = 8;
            this.userColumn.Name = "userColumn";
            this.userColumn.ReadOnly = true;
            // 
            // HeadColor
            // 
            this.HeadColor.HeaderText = "Head Color";
            this.HeadColor.MinimumWidth = 8;
            this.HeadColor.Name = "HeadColor";
            this.HeadColor.ReadOnly = true;
            // 
            // ChestColor
            // 
            this.ChestColor.HeaderText = "Chest Color";
            this.ChestColor.MinimumWidth = 8;
            this.ChestColor.Name = "ChestColor";
            this.ChestColor.ReadOnly = true;
            // 
            // BodyColor
            // 
            this.BodyColor.HeaderText = "Body Color";
            this.BodyColor.MinimumWidth = 8;
            this.BodyColor.Name = "BodyColor";
            this.BodyColor.ReadOnly = true;
            // 
            // chosenCageLable
            // 
            this.chosenCageLable.AutoSize = true;
            this.chosenCageLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chosenCageLable.Location = new System.Drawing.Point(437, 9);
            this.chosenCageLable.Name = "chosenCageLable";
            this.chosenCageLable.Size = new System.Drawing.Size(165, 21);
            this.chosenCageLable.TabIndex = 7;
            this.chosenCageLable.Text = "Birds in chosen cage";
            // 
            // loginExitBtn
            // 
            this.loginExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.loginExitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginExitBtn.ForeColor = System.Drawing.Color.White;
            this.loginExitBtn.Location = new System.Drawing.Point(471, 444);
            this.loginExitBtn.Name = "loginExitBtn";
            this.loginExitBtn.Size = new System.Drawing.Size(103, 41);
            this.loginExitBtn.TabIndex = 9;
            this.loginExitBtn.Text = "Exit";
            this.loginExitBtn.UseVisualStyleBackColor = false;
            this.loginExitBtn.Click += new System.EventHandler(this.loginExitBtn_Click);
            // 
            // BirdsCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 497);
            this.Controls.Add(this.loginExitBtn);
            this.Controls.Add(this.chosenCageLable);
            this.Controls.Add(this.dataGridBirds);
            this.Name = "BirdsCage";
            this.Text = "BirdsCage";
            this.Load += new System.EventHandler(this.BirdsCage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBirds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DataGridViewTextBoxColumn HeadColor;
        private DataGridViewTextBoxColumn ChestColor;
        private DataGridViewTextBoxColumn BodyColor;
        private Label chosenCageLable;
        private Button loginExitBtn;
    }
}