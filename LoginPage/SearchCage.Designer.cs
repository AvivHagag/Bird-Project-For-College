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
            dataGridCages = new DataGridView();
            cageIDColumn = new DataGridViewTextBoxColumn();
            lengthColumn = new DataGridViewTextBoxColumn();
            widthColumn = new DataGridViewTextBoxColumn();
            heightColumn = new DataGridViewTextBoxColumn();
            materialColumn = new DataGridViewTextBoxColumn();
            searchGroup = new GroupBox();
            cageSearchExitBtn = new Button();
            cageSearchMenuBtn = new Button();
            idTextBox = new TextBox();
            materialListBox = new ComboBox();
            searchBtn = new Button();
            cageSearchBox = new ComboBox();
            searchLabel = new Label();
            addChickLabels = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridCages).BeginInit();
            searchGroup.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCages
            // 
            dataGridCages.AllowUserToAddRows = false;
            dataGridCages.AllowUserToResizeColumns = false;
            dataGridCages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCages.Columns.AddRange(new DataGridViewColumn[] { cageIDColumn, lengthColumn, widthColumn, heightColumn, materialColumn });
            dataGridCages.Location = new Point(224, 26);
            dataGridCages.Name = "dataGridCages";
            dataGridCages.RowTemplate.Height = 25;
            dataGridCages.Size = new Size(543, 391);
            dataGridCages.TabIndex = 5;
            // 
            // cageIDColumn
            // 
            cageIDColumn.HeaderText = "Cage ID";
            cageIDColumn.Name = "cageIDColumn";
            // 
            // lengthColumn
            // 
            lengthColumn.HeaderText = "Length";
            lengthColumn.Name = "lengthColumn";
            // 
            // widthColumn
            // 
            widthColumn.HeaderText = "Width";
            widthColumn.Name = "widthColumn";
            // 
            // heightColumn
            // 
            heightColumn.HeaderText = "Height";
            heightColumn.Name = "heightColumn";
            // 
            // materialColumn
            // 
            materialColumn.HeaderText = "Material";
            materialColumn.Name = "materialColumn";
            // 
            // searchGroup
            // 
            searchGroup.Controls.Add(addChickLabels);
            searchGroup.Controls.Add(searchLabel);
            searchGroup.Controls.Add(cageSearchExitBtn);
            searchGroup.Controls.Add(cageSearchMenuBtn);
            searchGroup.Controls.Add(idTextBox);
            searchGroup.Controls.Add(materialListBox);
            searchGroup.Controls.Add(searchBtn);
            searchGroup.Controls.Add(cageSearchBox);
            searchGroup.Controls.Add(dataGridCages);
            searchGroup.Location = new Point(12, 18);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(767, 417);
            searchGroup.TabIndex = 2;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search Cage";
            // 
            // cageSearchExitBtn
            // 
            cageSearchExitBtn.Location = new Point(67, 250);
            cageSearchExitBtn.Name = "cageSearchExitBtn";
            cageSearchExitBtn.Size = new Size(75, 23);
            cageSearchExitBtn.TabIndex = 6;
            cageSearchExitBtn.Text = "Exit";
            cageSearchExitBtn.UseVisualStyleBackColor = true;
            cageSearchExitBtn.Click += cageSearchExitBtn_Click;
            // 
            // cageSearchMenuBtn
            // 
            cageSearchMenuBtn.Location = new Point(56, 221);
            cageSearchMenuBtn.Name = "cageSearchMenuBtn";
            cageSearchMenuBtn.Size = new Size(95, 23);
            cageSearchMenuBtn.TabIndex = 3;
            cageSearchMenuBtn.Text = "Main menu";
            cageSearchMenuBtn.UseVisualStyleBackColor = true;
            cageSearchMenuBtn.Click += cageSearchMenuBtn_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(56, 124);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 4;
            idTextBox.Visible = false;
            // 
            // materialListBox
            // 
            materialListBox.FormattingEnabled = true;
            materialListBox.Items.AddRange(new object[] { "wood", "plastic", "iron" });
            materialListBox.Location = new Point(45, 124);
            materialListBox.Name = "materialListBox";
            materialListBox.Size = new Size(121, 23);
            materialListBox.TabIndex = 2;
            materialListBox.Visible = false;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(56, 192);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(95, 23);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // cageSearchBox
            // 
            cageSearchBox.FormattingEnabled = true;
            cageSearchBox.Items.AddRange(new object[] { "Cage ID", "Material" });
            cageSearchBox.Location = new Point(45, 95);
            cageSearchBox.Name = "cageSearchBox";
            cageSearchBox.Size = new Size(121, 23);
            cageSearchBox.TabIndex = 0;
            cageSearchBox.SelectedIndexChanged += cageSearchBox_SelectedIndexChanged;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(45, 77);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(91, 15);
            searchLabel.TabIndex = 3;
            searchLabel.Text = "Choose to filter:";
            // 
            // addChickLabels
            // 
            addChickLabels.AutoSize = true;
            addChickLabels.ForeColor = SystemColors.Highlight;
            addChickLabels.Location = new Point(382, 8);
            addChickLabels.Name = "addChickLabels";
            addChickLabels.Size = new Size(201, 15);
            addChickLabels.TabIndex = 7;
            addChickLabels.Text = "Double click to add chick to the bird.";
            // 
            // SearchCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 447);
            Controls.Add(searchGroup);
            Name = "SearchCage";
            Text = "SearchCage";
            ((System.ComponentModel.ISupportInitialize)dataGridCages).EndInit();
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            ResumeLayout(false);
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
        private Label addChickLabels;
        private Label searchLabel;
    }
}