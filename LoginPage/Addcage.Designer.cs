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
            this.Addcagegroubbox = new System.Windows.Forms.GroupBox();
            this.CageAddBtn = new System.Windows.Forms.Button();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Addcagegroubbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Addcagegroubbox
            // 
            this.Addcagegroubbox.Controls.Add(this.CageAddBtn);
            this.Addcagegroubbox.Controls.Add(this.heightBox);
            this.Addcagegroubbox.Controls.Add(this.widthBox);
            this.Addcagegroubbox.Controls.Add(this.lengthBox);
            this.Addcagegroubbox.Controls.Add(this.materialBox);
            this.Addcagegroubbox.Controls.Add(this.label4);
            this.Addcagegroubbox.Controls.Add(this.label3);
            this.Addcagegroubbox.Controls.Add(this.label2);
            this.Addcagegroubbox.Controls.Add(this.label1);
            this.Addcagegroubbox.Location = new System.Drawing.Point(8, 27);
            this.Addcagegroubbox.Margin = new System.Windows.Forms.Padding(2);
            this.Addcagegroubbox.Name = "Addcagegroubbox";
            this.Addcagegroubbox.Padding = new System.Windows.Forms.Padding(2);
            this.Addcagegroubbox.Size = new System.Drawing.Size(482, 200);
            this.Addcagegroubbox.TabIndex = 0;
            this.Addcagegroubbox.TabStop = false;
            this.Addcagegroubbox.Text = "Add Cage";
            this.Addcagegroubbox.UseCompatibleTextRendering = true;
            // 
            // CageAddBtn
            // 
            this.CageAddBtn.Location = new System.Drawing.Point(284, 131);
            this.CageAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CageAddBtn.Name = "CageAddBtn";
            this.CageAddBtn.Size = new System.Drawing.Size(151, 35);
            this.CageAddBtn.TabIndex = 8;
            this.CageAddBtn.Text = "Add";
            this.CageAddBtn.UseVisualStyleBackColor = true;
            this.CageAddBtn.Click += new System.EventHandler(this.CageAddBtn_Click);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(82, 139);
            this.heightBox.Margin = new System.Windows.Forms.Padding(2);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(92, 23);
            this.heightBox.TabIndex = 7;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(82, 90);
            this.widthBox.Margin = new System.Windows.Forms.Padding(2);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(92, 23);
            this.widthBox.TabIndex = 6;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(82, 39);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(2);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(92, 23);
            this.lengthBox.TabIndex = 5;
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "wood",
            "plastic",
            "iron"});
            this.materialBox.Location = new System.Drawing.Point(293, 35);
            this.materialBox.Margin = new System.Windows.Forms.Padding(2);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(117, 23);
            this.materialBox.TabIndex = 4;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.material_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length:";
            // 
            // Addcage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.Addcagegroubbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Addcage";
            this.Text = "Addcage";
            this.Addcagegroubbox.ResumeLayout(false);
            this.Addcagegroubbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Addcagegroubbox;
        private TextBox heightBox;
        private TextBox widthBox;
        private TextBox lengthBox;
        private ComboBox materialBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CageAddBtn;
    }
}