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
            this.Mplabel = new System.Windows.Forms.Label();
            this.AddBbtn = new System.Windows.Forms.Button();
            this.Addcbtn = new System.Windows.Forms.Button();
            this.SearchBbtn = new System.Windows.Forms.Button();
            this.SearchCbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mplabel
            // 
            this.Mplabel.Font = new System.Drawing.Font("David", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mplabel.Location = new System.Drawing.Point(31, 23);
            this.Mplabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mplabel.Name = "Mplabel";
            this.Mplabel.Size = new System.Drawing.Size(96, 37);
            this.Mplabel.TabIndex = 0;
            this.Mplabel.Text = "Main Page";
            // 
            // AddBbtn
            // 
            this.AddBbtn.Location = new System.Drawing.Point(31, 62);
            this.AddBbtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBbtn.Name = "AddBbtn";
            this.AddBbtn.Size = new System.Drawing.Size(85, 30);
            this.AddBbtn.TabIndex = 1;
            this.AddBbtn.Text = "Add Bird";
            this.AddBbtn.UseVisualStyleBackColor = true;
            this.AddBbtn.Click += new System.EventHandler(this.AddBbtn_Click);
            // 
            // Addcbtn
            // 
            this.Addcbtn.Location = new System.Drawing.Point(147, 62);
            this.Addcbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Addcbtn.Name = "Addcbtn";
            this.Addcbtn.Size = new System.Drawing.Size(89, 30);
            this.Addcbtn.TabIndex = 2;
            this.Addcbtn.Text = "Add Cage";
            this.Addcbtn.UseVisualStyleBackColor = true;
            this.Addcbtn.Click += new System.EventHandler(this.Addcbtn_Click);

            // 
            // SearchBbtn
            // 
            this.SearchBbtn.Location = new System.Drawing.Point(262, 62);
            this.SearchBbtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBbtn.Name = "SearchBbtn";
            this.SearchBbtn.Size = new System.Drawing.Size(87, 30);
            this.SearchBbtn.TabIndex = 3;
            this.SearchBbtn.Text = "Search Bird";
            this.SearchBbtn.UseVisualStyleBackColor = true;
            this.SearchBbtn.Click += new System.EventHandler(this.SearchBbtn_Click);
            // 
            // SearchCbtn
            // 
            this.SearchCbtn.Location = new System.Drawing.Point(382, 62);
            this.SearchCbtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCbtn.Name = "SearchCbtn";
            this.SearchCbtn.Size = new System.Drawing.Size(89, 30);
            this.SearchCbtn.TabIndex = 4;
            this.SearchCbtn.Text = "Search Cage";
            this.SearchCbtn.UseVisualStyleBackColor = true;
            this.SearchCbtn.Click += new System.EventHandler(this.SearchCbtn_Click);

            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.SearchCbtn);
            this.Controls.Add(this.SearchBbtn);
            this.Controls.Add(this.Addcbtn);
            this.Controls.Add(this.AddBbtn);
            this.Controls.Add(this.Mplabel);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Mplabel;
        private Button AddBbtn;
        private Button Addcbtn;
        private Button SearchBbtn;
        private Button SearchCbtn;
    }
}