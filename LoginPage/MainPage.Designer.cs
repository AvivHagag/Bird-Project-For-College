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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            AddBbtn = new Button();
            Addcbtn = new Button();
            SearchBbtn = new Button();
            SearchCbtn = new Button();
            mainExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddBbtn
            // 
            AddBbtn.BackColor = Color.FromArgb(44, 62, 80);
            AddBbtn.Cursor = Cursors.Hand;
            AddBbtn.FlatAppearance.BorderSize = 0;
            AddBbtn.FlatStyle = FlatStyle.Flat;
            AddBbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AddBbtn.ForeColor = Color.White;
            AddBbtn.Location = new Point(9, 312);
            AddBbtn.Margin = new Padding(2);
            AddBbtn.Name = "AddBbtn";
            AddBbtn.Size = new Size(107, 25);
            AddBbtn.TabIndex = 1;
            AddBbtn.Text = "Add Bird";
            AddBbtn.UseVisualStyleBackColor = false;
            AddBbtn.Click += AddBbtn_Click;
            // 
            // Addcbtn
            // 
            Addcbtn.BackColor = Color.FromArgb(44, 62, 80);
            Addcbtn.Cursor = Cursors.Hand;
            Addcbtn.FlatAppearance.BorderSize = 0;
            Addcbtn.FlatStyle = FlatStyle.Flat;
            Addcbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Addcbtn.ForeColor = Color.White;
            Addcbtn.Location = new Point(138, 312);
            Addcbtn.Margin = new Padding(2);
            Addcbtn.Name = "Addcbtn";
            Addcbtn.Size = new Size(107, 25);
            Addcbtn.TabIndex = 2;
            Addcbtn.Text = "Add Cage";
            Addcbtn.UseVisualStyleBackColor = false;
            Addcbtn.Click += Addcbtn_Click;
            // 
            // SearchBbtn
            // 
            SearchBbtn.BackColor = Color.FromArgb(44, 62, 80);
            SearchBbtn.Cursor = Cursors.Hand;
            SearchBbtn.FlatAppearance.BorderSize = 0;
            SearchBbtn.FlatStyle = FlatStyle.Flat;
            SearchBbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBbtn.ForeColor = Color.White;
            SearchBbtn.Location = new Point(267, 312);
            SearchBbtn.Margin = new Padding(2);
            SearchBbtn.Name = "SearchBbtn";
            SearchBbtn.Size = new Size(107, 25);
            SearchBbtn.TabIndex = 3;
            SearchBbtn.Text = "Search Bird";
            SearchBbtn.UseVisualStyleBackColor = false;
            SearchBbtn.Click += SearchBbtn_Click;
            // 
            // SearchCbtn
            // 
            SearchCbtn.BackColor = Color.FromArgb(44, 62, 80);
            SearchCbtn.Cursor = Cursors.Hand;
            SearchCbtn.FlatAppearance.BorderSize = 0;
            SearchCbtn.FlatStyle = FlatStyle.Flat;
            SearchCbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SearchCbtn.ForeColor = Color.White;
            SearchCbtn.Location = new Point(397, 312);
            SearchCbtn.Margin = new Padding(2);
            SearchCbtn.Name = "SearchCbtn";
            SearchCbtn.Size = new Size(107, 25);
            SearchCbtn.TabIndex = 4;
            SearchCbtn.Text = "Search Cage";
            SearchCbtn.UseVisualStyleBackColor = false;
            SearchCbtn.Click += SearchCbtn_Click;
            // 
            // mainExit
            // 
            mainExit.BackColor = Color.FromArgb(192, 57, 43);
            mainExit.Cursor = Cursors.Hand;
            mainExit.FlatAppearance.BorderSize = 0;
            mainExit.FlatStyle = FlatStyle.Flat;
            mainExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            mainExit.ForeColor = Color.White;
            mainExit.Location = new Point(9, 398);
            mainExit.Name = "mainExit";
            mainExit.Size = new Size(107, 25);
            mainExit.TabIndex = 5;
            mainExit.Text = "Exit";
            mainExit.UseVisualStyleBackColor = false;
            mainExit.Click += mainExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-25, -23);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 432);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(512, 450);
            Controls.Add(mainExit);
            Controls.Add(SearchCbtn);
            Controls.Add(SearchBbtn);
            Controls.Add(Addcbtn);
            Controls.Add(AddBbtn);
            Controls.Add(pictureBox1);
            Name = "MainPage";
            Text = "Main Page";
            Load += MainPage_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button AddBbtn;
        private Button Addcbtn;
        private Button SearchBbtn;
        private Button SearchCbtn;
        private Button mainExit;
        private PictureBox pictureBox1;
    }
}