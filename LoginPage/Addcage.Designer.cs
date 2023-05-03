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
            cageMainMenuBtn = new Button();
            CageAddBtn = new Button();
            heightBox = new TextBox();
            widthBox = new TextBox();
            lengthBox = new TextBox();
            materialBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exitCageBtn = new Button();
            Addcagegroubbox.SuspendLayout();
            SuspendLayout();
            // 
            // Addcagegroubbox
            // 
            Addcagegroubbox.Controls.Add(exitCageBtn);
            Addcagegroubbox.Controls.Add(cageMainMenuBtn);
            Addcagegroubbox.Controls.Add(CageAddBtn);
            Addcagegroubbox.Controls.Add(heightBox);
            Addcagegroubbox.Controls.Add(widthBox);
            Addcagegroubbox.Controls.Add(lengthBox);
            Addcagegroubbox.Controls.Add(materialBox);
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
            // cageMainMenuBtn
            // 
            cageMainMenuBtn.Location = new Point(282, 110);
            cageMainMenuBtn.Name = "cageMainMenuBtn";
            cageMainMenuBtn.Size = new Size(151, 28);
            cageMainMenuBtn.TabIndex = 9;
            cageMainMenuBtn.Text = "Main menu";
            cageMainMenuBtn.UseVisualStyleBackColor = true;
            cageMainMenuBtn.Click += cageMainMenuBtn_Click;
            // 
            // CageAddBtn
            // 
            CageAddBtn.Location = new Point(282, 70);
            CageAddBtn.Margin = new Padding(2);
            CageAddBtn.Name = "CageAddBtn";
            CageAddBtn.Size = new Size(151, 35);
            CageAddBtn.TabIndex = 8;
            CageAddBtn.Text = "Add";
            CageAddBtn.UseVisualStyleBackColor = true;
            CageAddBtn.Click += CageAddBtn_Click;
            // 
            // heightBox
            // 
            heightBox.Location = new Point(82, 139);
            heightBox.Margin = new Padding(2);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(92, 23);
            heightBox.TabIndex = 7;
            // 
            // widthBox
            // 
            widthBox.Location = new Point(82, 90);
            widthBox.Margin = new Padding(2);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(92, 23);
            widthBox.TabIndex = 6;
            // 
            // lengthBox
            // 
            lengthBox.Location = new Point(82, 39);
            lengthBox.Margin = new Padding(2);
            lengthBox.Name = "lengthBox";
            lengthBox.Size = new Size(92, 23);
            lengthBox.TabIndex = 5;
            // 
            // materialBox
            // 
            materialBox.FormattingEnabled = true;
            materialBox.Items.AddRange(new object[] { "wood", "plastic", "iron" });
            materialBox.Location = new Point(293, 35);
            materialBox.Margin = new Padding(2);
            materialBox.Name = "materialBox";
            materialBox.Size = new Size(117, 23);
            materialBox.TabIndex = 4;
            materialBox.SelectedIndexChanged += material_SelectedIndexChanged;
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
            // exitCageBtn
            // 
            exitCageBtn.Location = new Point(282, 144);
            exitCageBtn.Name = "exitCageBtn";
            exitCageBtn.Size = new Size(151, 23);
            exitCageBtn.TabIndex = 10;
            exitCageBtn.Text = "Exit";
            exitCageBtn.UseVisualStyleBackColor = true;
            exitCageBtn.Click += exitCageBtn_Click;
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
        private TextBox heightBox;
        private TextBox widthBox;
        private TextBox lengthBox;
        private ComboBox materialBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CageAddBtn;
        private Button cageMainMenuBtn;
        private Button exitCageBtn;
    }
}