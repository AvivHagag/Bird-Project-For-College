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
            this.dataGridCages.AllowUserToResizeColumns = false;
            this.dataGridCages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cageIDColumn,
            this.lengthColumn,
            this.widthColumn,
            this.heightColumn,
            this.materialColumn});
            this.dataGridCages.Location = new System.Drawing.Point(214, 4);
            this.dataGridCages.Name = "dataGridCages";
            this.dataGridCages.RowTemplate.Height = 25;
            this.dataGridCages.Size = new System.Drawing.Size(543, 391);
            this.dataGridCages.TabIndex = 5;
            // 
            // cageIDColumn
            // 
            this.cageIDColumn.HeaderText = "Cage ID";
            this.cageIDColumn.Name = "cageIDColumn";
            // 
            // lengthColumn
            // 
            this.lengthColumn.HeaderText = "Length";
            this.lengthColumn.Name = "lengthColumn";
            // 
            // widthColumn
            // 
            this.widthColumn.HeaderText = "Width";
            this.widthColumn.Name = "widthColumn";
            // 
            // heightColumn
            // 
            this.heightColumn.HeaderText = "Height";
            this.heightColumn.Name = "heightColumn";
            // 
            // materialColumn
            // 
            this.materialColumn.HeaderText = "Material";
            this.materialColumn.Name = "materialColumn";
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.idTextBox);
            this.searchGroup.Controls.Add(this.materialListBox);
            this.searchGroup.Controls.Add(this.searchBtn);
            this.searchGroup.Controls.Add(this.cageSearchBox);
            this.searchGroup.Controls.Add(this.dataGridCages);
            this.searchGroup.Location = new System.Drawing.Point(12, 18);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(754, 388);
            this.searchGroup.TabIndex = 2;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search Cage";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(56, 124);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
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
            this.materialListBox.Size = new System.Drawing.Size(121, 23);
            this.materialListBox.TabIndex = 2;
            this.materialListBox.Visible = false;
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
            // cageSearchBox
            // 
            this.cageSearchBox.FormattingEnabled = true;
            this.cageSearchBox.Items.AddRange(new object[] {
            "Cage ID",
            "Material"});
            this.cageSearchBox.Location = new System.Drawing.Point(45, 95);
            this.cageSearchBox.Name = "cageSearchBox";
            this.cageSearchBox.Size = new System.Drawing.Size(121, 23);
            this.cageSearchBox.TabIndex = 0;
            this.cageSearchBox.SelectedIndexChanged += new System.EventHandler(this.cageSearchBox_SelectedIndexChanged);
            // 
            // SearchCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 425);
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
    }
}