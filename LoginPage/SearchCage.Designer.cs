namespace LoginPage
{
    partial class SearchCage
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
            this.dataGridCages = new System.Windows.Forms.DataGridView();
            this.cageIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.cageSearchExitBtn = new System.Windows.Forms.Button();
            this.cageSearchMenuBtn = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.materialListBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cageSearchBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCages)).BeginInit();
            this.searchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCages
            // 
            this.dataGridCages.AllowUserToAddRows = false;
            this.dataGridCages.AllowUserToDeleteRows = false;
            this.dataGridCages.AllowUserToResizeRows = false;
            this.dataGridCages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCages.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cageIDColumn,
            this.lengthColumn,
            this.widthColumn,
            this.heightColumn,
            this.materialColumn});
            this.dataGridCages.EnableHeadersVisualStyles = false;
            this.dataGridCages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridCages.Location = new System.Drawing.Point(224, 26);
            this.dataGridCages.MultiSelect = false;
            this.dataGridCages.Name = "dataGridCages";
            this.dataGridCages.ReadOnly = true;
            this.dataGridCages.RowHeadersVisible = false;
            this.dataGridCages.RowTemplate.Height = 30;
            this.dataGridCages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCages.Size = new System.Drawing.Size(543, 391);
            this.dataGridCages.TabIndex = 5;
            this.dataGridCages.TabStop = false;
            this.dataGridCages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCages_CellContentClick);
            this.dataGridCages.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCages_CellMouseDoubleClick);
            // 
            // cageIDColumn
            // 
            this.cageIDColumn.HeaderText = "Cage ID";
            this.cageIDColumn.Name = "cageIDColumn";
            this.cageIDColumn.ReadOnly = true;
            // 
            // lengthColumn
            // 
            this.lengthColumn.HeaderText = "Length";
            this.lengthColumn.Name = "lengthColumn";
            this.lengthColumn.ReadOnly = true;
            // 
            // widthColumn
            // 
            this.widthColumn.HeaderText = "Width";
            this.widthColumn.Name = "widthColumn";
            this.widthColumn.ReadOnly = true;
            // 
            // heightColumn
            // 
            this.heightColumn.HeaderText = "Height";
            this.heightColumn.Name = "heightColumn";
            this.heightColumn.ReadOnly = true;
            // 
            // materialColumn
            // 
            this.materialColumn.HeaderText = "Material";
            this.materialColumn.Name = "materialColumn";
            this.materialColumn.ReadOnly = true;
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.searchLabel);
            this.searchGroup.Controls.Add(this.cageSearchExitBtn);
            this.searchGroup.Controls.Add(this.cageSearchMenuBtn);
            this.searchGroup.Controls.Add(this.idTextBox);
            this.searchGroup.Controls.Add(this.materialListBox);
            this.searchGroup.Controls.Add(this.searchBtn);
            this.searchGroup.Controls.Add(this.cageSearchBox);
            this.searchGroup.Controls.Add(this.dataGridCages);
            this.searchGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.searchGroup.Location = new System.Drawing.Point(12, 18);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(767, 417);
            this.searchGroup.TabIndex = 2;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search Cage";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(49, 73);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(117, 19);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Choose to filter:";
            // 
            // cageSearchExitBtn
            // 
            this.cageSearchExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.cageSearchExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cageSearchExitBtn.FlatAppearance.BorderSize = 0;
            this.cageSearchExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cageSearchExitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cageSearchExitBtn.ForeColor = System.Drawing.Color.White;
            this.cageSearchExitBtn.Location = new System.Drawing.Point(45, 257);
            this.cageSearchExitBtn.Name = "cageSearchExitBtn";
            this.cageSearchExitBtn.Size = new System.Drawing.Size(121, 25);
            this.cageSearchExitBtn.TabIndex = 6;
            this.cageSearchExitBtn.Text = "Exit";
            this.cageSearchExitBtn.UseVisualStyleBackColor = false;
            this.cageSearchExitBtn.Click += new System.EventHandler(this.cageSearchExitBtn_Click);
            // 
            // cageSearchMenuBtn
            // 
            this.cageSearchMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cageSearchMenuBtn.FlatAppearance.BorderSize = 0;
            this.cageSearchMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cageSearchMenuBtn.ForeColor = System.Drawing.Color.White;
            this.cageSearchMenuBtn.Location = new System.Drawing.Point(45, 221);
            this.cageSearchMenuBtn.Name = "cageSearchMenuBtn";
            this.cageSearchMenuBtn.Size = new System.Drawing.Size(121, 30);
            this.cageSearchMenuBtn.TabIndex = 3;
            this.cageSearchMenuBtn.Text = "Main menu";
            this.cageSearchMenuBtn.UseVisualStyleBackColor = false;
            this.cageSearchMenuBtn.Click += new System.EventHandler(this.cageSearchMenuBtn_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(45, 124);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 25);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.Visible = false;
            // 
            // materialListBox
            // 
            this.materialListBox.FormattingEnabled = true;
            this.materialListBox.Items.AddRange(new object[] {
            "wood",
            "plastic",
            "iron"});
            this.materialListBox.Location = new System.Drawing.Point(45, 124);
            this.materialListBox.Name = "materialListBox";
            this.materialListBox.Size = new System.Drawing.Size(121, 25);
            this.materialListBox.TabIndex = 2;
            this.materialListBox.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(45, 185);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(121, 30);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cageSearchBox
            // 
            this.cageSearchBox.FormattingEnabled = true;
            this.cageSearchBox.Items.AddRange(new object[] {
            "Cage ID",
            "Material"});
            this.cageSearchBox.Location = new System.Drawing.Point(45, 95);
            this.cageSearchBox.Name = "cageSearchBox";
            this.cageSearchBox.Size = new System.Drawing.Size(121, 25);
            this.cageSearchBox.TabIndex = 0;
            this.cageSearchBox.SelectedIndexChanged += new System.EventHandler(this.cageSearchBox_SelectedIndexChanged);
            // 
            // SearchCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 447);
            this.Controls.Add(this.searchGroup);
            this.Name = "SearchCage";
            this.Text = "SearchCage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCages)).EndInit();
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridCages;
        private DataGridViewTextBoxColumn cageIDColumn;
        private DataGridViewTextBoxColumn lengthColumn;
        private DataGridViewTextBoxColumn widthColumn;
        private DataGridViewTextBoxColumn heightColumn;
        private DataGridViewTextBoxColumn materialColumn;
        private GroupBox searchGroup;
        private TextBox idTextBox;
        private ComboBox materialListBox;
        private Button searchBtn;
        private ComboBox cageSearchBox;
        private Button cageSearchMenuBtn;
        private Button cageSearchExitBtn;
        private Label searchLabel;
    }
}