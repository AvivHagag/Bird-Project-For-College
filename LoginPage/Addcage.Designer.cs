namespace LoginPage
{
    partial class Addcage
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
            Addcagegroubbox = new GroupBox();
            CageAddbtn = new Button();
            height = new TextBox();
            width = new TextBox();
            length = new TextBox();
            material = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Addcagegroubbox.SuspendLayout();
            SuspendLayout();
            // 
            // Addcagegroubbox
            // 
            Addcagegroubbox.Controls.Add(CageAddbtn);
            Addcagegroubbox.Controls.Add(height);
            Addcagegroubbox.Controls.Add(width);
            Addcagegroubbox.Controls.Add(length);
            Addcagegroubbox.Controls.Add(material);
            Addcagegroubbox.Controls.Add(label4);
            Addcagegroubbox.Controls.Add(label3);
            Addcagegroubbox.Controls.Add(label2);
            Addcagegroubbox.Controls.Add(label1);
            Addcagegroubbox.Location = new Point(8, 27);
            Addcagegroubbox.Margin = new Padding(2);
            Addcagegroubbox.Name = "Addcagegroubbox";
            Addcagegroubbox.Padding = new Padding(2);
            Addcagegroubbox.Size = new Size(482, 200);
            Addcagegroubbox.TabIndex = 0;
            Addcagegroubbox.TabStop = false;
            Addcagegroubbox.Text = "Add Cage";
            Addcagegroubbox.UseCompatibleTextRendering = true;
            // 
            // CageAddbtn
            // 
            CageAddbtn.Location = new Point(284, 131);
            CageAddbtn.Margin = new Padding(2);
            CageAddbtn.Name = "CageAddbtn";
            CageAddbtn.Size = new Size(151, 35);
            CageAddbtn.TabIndex = 8;
            CageAddbtn.Text = "Add";
            CageAddbtn.UseVisualStyleBackColor = true;
            CageAddbtn.Click += CageAddbtn_Click;
            // 
            // height
            // 
            height.Location = new Point(82, 139);
            height.Margin = new Padding(2);
            height.Name = "height";
            height.Size = new Size(92, 23);
            height.TabIndex = 7;
            // 
            // width
            // 
            width.Location = new Point(82, 90);
            width.Margin = new Padding(2);
            width.Name = "width";
            width.Size = new Size(92, 23);
            width.TabIndex = 6;
            // 
            // length
            // 
            length.Location = new Point(82, 39);
            length.Margin = new Padding(2);
            length.Name = "length";
            length.Size = new Size(88, 23);
            length.TabIndex = 5;
            length.TextChanged += length_TextChanged;
            // 
            // material
            // 
            material.FormattingEnabled = true;
            material.Items.AddRange(new object[] { "wood", "plastic", "iron" });
            material.Location = new Point(293, 35);
            material.Margin = new Padding(2);
            material.Name = "material";
            material.Size = new Size(117, 23);
            material.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 37);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Material";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 142);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Width";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Length:";
            // 
            // Addcage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(Addcagegroubbox);
            Margin = new Padding(2);
            Name = "Addcage";
            Text = "Addcage";
            Addcagegroubbox.ResumeLayout(false);
            Addcagegroubbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Addcagegroubbox;
        private TextBox height;
        private TextBox width;
        private TextBox length;
        private ComboBox material;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CageAddbtn;
    }
}