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
            Mplabel = new Label();
            AddBbtn = new Button();
            Addcbtn = new Button();
            SearchBbtn = new Button();
            SearchCbtn = new Button();
            SuspendLayout();
            // 
            // Mplabel
            // 
            Mplabel.Font = new Font("David", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Mplabel.Location = new Point(31, 23);
            Mplabel.Margin = new Padding(2, 0, 2, 0);
            Mplabel.Name = "Mplabel";
            Mplabel.Size = new Size(96, 37);
            Mplabel.TabIndex = 0;
            Mplabel.Text = "Main Page";
            // 
            // AddBbtn
            // 
            AddBbtn.Location = new Point(31, 62);
            AddBbtn.Margin = new Padding(2, 2, 2, 2);
            AddBbtn.Name = "AddBbtn";
            AddBbtn.Size = new Size(85, 30);
            AddBbtn.TabIndex = 1;
            AddBbtn.Text = "Add Bird";
            AddBbtn.UseVisualStyleBackColor = true;
            AddBbtn.Click += AddBbtn_Click;
            // 
            // Addcbtn
            // 
            Addcbtn.Location = new Point(147, 62);
            Addcbtn.Margin = new Padding(2, 2, 2, 2);
            Addcbtn.Name = "Addcbtn";
            Addcbtn.Size = new Size(89, 30);
            Addcbtn.TabIndex = 2;
            Addcbtn.Text = "Add Cage";
            Addcbtn.UseVisualStyleBackColor = true;
            Addcbtn.Click += Addcbtn_Click;
            // 
            // SearchBbtn
            // 
            SearchBbtn.Location = new Point(262, 62);
            SearchBbtn.Margin = new Padding(2, 2, 2, 2);
            SearchBbtn.Name = "SearchBbtn";
            SearchBbtn.Size = new Size(87, 30);
            SearchBbtn.TabIndex = 3;
            SearchBbtn.Text = "Search Bird";
            SearchBbtn.UseVisualStyleBackColor = true;
            // 
            // SearchCbtn
            // 
            SearchCbtn.Location = new Point(382, 62);
            SearchCbtn.Margin = new Padding(2, 2, 2, 2);
            SearchCbtn.Name = "SearchCbtn";
            SearchCbtn.Size = new Size(89, 30);
            SearchCbtn.TabIndex = 4;
            SearchCbtn.Text = "Search Cage";
            SearchCbtn.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(512, 450);
            Controls.Add(SearchCbtn);
            Controls.Add(SearchBbtn);
            Controls.Add(Addcbtn);
            Controls.Add(AddBbtn);
            Controls.Add(Mplabel);
            Name = "MainPage";
            Text = "Main Page";
            Load += MainPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Mplabel;
        private Button AddBbtn;
        private Button Addcbtn;
        private Button SearchBbtn;
        private Button SearchCbtn;
    }
}