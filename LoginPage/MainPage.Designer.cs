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
            AddBbtn.Location = new Point(31, 297);
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
            Addcbtn.Location = new Point(147, 297);
            Addcbtn.Margin = new Padding(2);
            Addcbtn.Name = "Addcbtn";
            Addcbtn.Size = new Size(89, 30);
            Addcbtn.TabIndex = 2;
            Addcbtn.Text = "Add Cage";
            Addcbtn.UseVisualStyleBackColor = true;
            Addcbtn.Click += Addcbtn_Click;
            // 
            // SearchBbtn
            // 
            SearchBbtn.Location = new Point(262, 297);
            SearchBbtn.Margin = new Padding(2);
            SearchBbtn.Name = "SearchBbtn";
            SearchBbtn.Size = new Size(87, 30);
            SearchBbtn.TabIndex = 3;
            SearchBbtn.Text = "Search Bird";
            SearchBbtn.UseVisualStyleBackColor = true;
            SearchBbtn.Click += SearchBbtn_Click;
            // 
            // SearchCbtn
            // 
            SearchCbtn.Location = new Point(382, 297);
            SearchCbtn.Margin = new Padding(2);
            SearchCbtn.Name = "SearchCbtn";
            SearchCbtn.Size = new Size(89, 30);
            SearchCbtn.TabIndex = 4;
            SearchCbtn.Text = "Search Cage";
            SearchCbtn.UseVisualStyleBackColor = true;
            SearchCbtn.Click += SearchCbtn_Click;
            // 
            // mainExit
            // 
            mainExit.Location = new Point(31, 399);
            mainExit.Name = "mainExit";
            mainExit.Size = new Size(85, 23);
            mainExit.TabIndex = 5;
            mainExit.Text = "Exit";
            mainExit.UseVisualStyleBackColor = true;
            mainExit.Click += mainExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 19);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 276);
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
            Controls.Add(pictureBox1);
            Controls.Add(mainExit);
            Controls.Add(SearchCbtn);
            Controls.Add(SearchBbtn);
            Controls.Add(Addcbtn);
            Controls.Add(AddBbtn);
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