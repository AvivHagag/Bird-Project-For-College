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
            UserId = new DataGridViewTextBoxColumn();
            searchGroup = new GroupBox();
            pictureBox1 = new PictureBox();
            searchLabel = new Label();
            cageSearchExitBtn = new Button();
            cageSearchMenuBtn = new Button();
            idTextBox = new TextBox();
            materialListBox = new ComboBox();
            searchBtn = new Button();
            cageSearchBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCages).BeginInit();
            searchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridCages
            // 
            dataGridCages.AllowUserToAddRows = false;
            dataGridCages.AllowUserToDeleteRows = false;
            dataGridCages.AllowUserToResizeRows = false;
            dataGridCages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCages.BackgroundColor = Color.White;
            dataGridCages.BorderStyle = BorderStyle.Fixed3D;
            dataGridCages.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridCages.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridCages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCages.Columns.AddRange(new DataGridViewColumn[] { cageIDColumn, lengthColumn, widthColumn, heightColumn, materialColumn, UserId });
            dataGridCages.EnableHeadersVisualStyles = false;
            dataGridCages.GridColor = Color.FromArgb(200, 200, 200);
            dataGridCages.Location = new Point(224, 26);
            dataGridCages.MultiSelect = false;
            dataGridCages.Name = "dataGridCages";
            dataGridCages.ReadOnly = true;
            dataGridCages.RowHeadersVisible = false;
            dataGridCages.RowTemplate.Height = 30;
            dataGridCages.ScrollBars = ScrollBars.Vertical;
            dataGridCages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCages.Size = new Size(543, 391);
            dataGridCages.TabIndex = 5;
            dataGridCages.TabStop = false;
            dataGridCages.CellContentClick += dataGridCages_CellContentClick;
            dataGridCages.CellMouseDoubleClick += dataGridCages_CellMouseDoubleClick;
            // 
            // cageIDColumn
            // 
            cageIDColumn.HeaderText = "Cage ID";
            cageIDColumn.Name = "cageIDColumn";
            cageIDColumn.ReadOnly = true;
            // 
            // lengthColumn
            // 
            lengthColumn.HeaderText = "Length";
            lengthColumn.Name = "lengthColumn";
            lengthColumn.ReadOnly = true;
            // 
            // widthColumn
            // 
            widthColumn.HeaderText = "Width";
            widthColumn.Name = "widthColumn";
            widthColumn.ReadOnly = true;
            // 
            // heightColumn
            // 
            heightColumn.HeaderText = "Height";
            heightColumn.Name = "heightColumn";
            heightColumn.ReadOnly = true;
            // 
            // materialColumn
            // 
            materialColumn.HeaderText = "Material";
            materialColumn.Name = "materialColumn";
            materialColumn.ReadOnly = true;
            // 
            // UserId
            // 
            UserId.HeaderText = "User ID";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // searchGroup
            // 
            searchGroup.BackgroundImageLayout = ImageLayout.Zoom;
            searchGroup.Controls.Add(pictureBox1);
            searchGroup.Controls.Add(searchLabel);
            searchGroup.Controls.Add(cageSearchExitBtn);
            searchGroup.Controls.Add(cageSearchMenuBtn);
            searchGroup.Controls.Add(idTextBox);
            searchGroup.Controls.Add(materialListBox);
            searchGroup.Controls.Add(searchBtn);
            searchGroup.Controls.Add(cageSearchBox);
            searchGroup.Controls.Add(dataGridCages);
            searchGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            searchGroup.ForeColor = Color.FromArgb(44, 62, 80);
            searchGroup.Location = new Point(12, 18);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(767, 417);
            searchGroup.TabIndex = 2;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search Cage";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(27, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(45, 132);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(117, 19);
            searchLabel.TabIndex = 3;
            searchLabel.Text = "Choose to filter:";
            // 
            // cageSearchExitBtn
            // 
            cageSearchExitBtn.BackColor = Color.FromArgb(192, 57, 43);
            cageSearchExitBtn.Cursor = Cursors.Hand;
            cageSearchExitBtn.FlatAppearance.BorderSize = 0;
            cageSearchExitBtn.FlatStyle = FlatStyle.Flat;
            cageSearchExitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cageSearchExitBtn.ForeColor = Color.White;
            cageSearchExitBtn.Location = new Point(45, 299);
            cageSearchExitBtn.Name = "cageSearchExitBtn";
            cageSearchExitBtn.Size = new Size(121, 25);
            cageSearchExitBtn.TabIndex = 6;
            cageSearchExitBtn.Text = "Exit";
            cageSearchExitBtn.UseVisualStyleBackColor = false;
            cageSearchExitBtn.Click += cageSearchExitBtn_Click;
            // 
            // cageSearchMenuBtn
            // 
            cageSearchMenuBtn.BackColor = Color.FromArgb(44, 62, 80);
            cageSearchMenuBtn.FlatAppearance.BorderSize = 0;
            cageSearchMenuBtn.FlatStyle = FlatStyle.Flat;
            cageSearchMenuBtn.ForeColor = Color.White;
            cageSearchMenuBtn.Location = new Point(45, 263);
            cageSearchMenuBtn.Name = "cageSearchMenuBtn";
            cageSearchMenuBtn.Size = new Size(121, 30);
            cageSearchMenuBtn.TabIndex = 3;
            cageSearchMenuBtn.Text = "Main menu";
            cageSearchMenuBtn.UseVisualStyleBackColor = false;
            cageSearchMenuBtn.Click += cageSearchMenuBtn_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(45, 185);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(121, 25);
            idTextBox.TabIndex = 4;
            idTextBox.Visible = false;
            // 
            // materialListBox
            // 
            materialListBox.FormattingEnabled = true;
            materialListBox.Items.AddRange(new object[] { "wood", "plastic", "iron" });
            materialListBox.Location = new Point(45, 185);
            materialListBox.Name = "materialListBox";
            materialListBox.Size = new Size(121, 25);
            materialListBox.TabIndex = 2;
            materialListBox.Visible = false;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(44, 62, 80);
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(45, 227);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(121, 30);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // cageSearchBox
            // 
            cageSearchBox.FormattingEnabled = true;
            cageSearchBox.Items.AddRange(new object[] { "Cage ID", "Material" });
            cageSearchBox.Location = new Point(45, 154);
            cageSearchBox.Name = "cageSearchBox";
            cageSearchBox.Size = new Size(121, 25);
            cageSearchBox.TabIndex = 0;
            cageSearchBox.SelectedIndexChanged += cageSearchBox_SelectedIndexChanged;
            // 
            // SearchCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(791, 447);
            Controls.Add(searchGroup);
            Name = "SearchCage";
            Text = "SearchCage";
            ((System.ComponentModel.ISupportInitialize)dataGridCages).EndInit();
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCages;
        private GroupBox searchGroup;
        private TextBox idTextBox;
        private ComboBox materialListBox;
        private Button searchBtn;
        private ComboBox cageSearchBox;
        private Button cageSearchMenuBtn;
        private Button cageSearchExitBtn;
        private Label searchLabel;
        private DataGridViewTextBoxColumn cageIDColumn;
        private DataGridViewTextBoxColumn lengthColumn;
        private DataGridViewTextBoxColumn widthColumn;
        private DataGridViewTextBoxColumn heightColumn;
        private DataGridViewTextBoxColumn materialColumn;
        private DataGridViewTextBoxColumn UserId;
        private PictureBox pictureBox1;
    }
}