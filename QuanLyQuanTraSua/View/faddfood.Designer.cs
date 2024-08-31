namespace QuanLyQuanTraSua.View
{
    partial class faddfood
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnaddfood = new Button();
            panel4 = new Panel();
            nbudpricefood = new NumericUpDown();
            label4 = new Label();
            panel3 = new Panel();
            cmbcategoryfood = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            txtnamefood = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbudpricefood).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnaddfood);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 334);
            panel1.TabIndex = 1;
            // 
            // btnaddfood
            // 
            btnaddfood.Location = new Point(238, 251);
            btnaddfood.Name = "btnaddfood";
            btnaddfood.Size = new Size(170, 45);
            btnaddfood.TabIndex = 4;
            btnaddfood.Text = "Add Food";
            btnaddfood.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(nbudpricefood);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(479, 51);
            panel4.TabIndex = 3;
            // 
            // nbudpricefood
            // 
            nbudpricefood.Location = new Point(150, 14);
            nbudpricefood.Maximum = new decimal(new int[] { -469762048, -590869294, 5421010, 0 });
            nbudpricefood.Name = "nbudpricefood";
            nbudpricefood.Size = new Size(315, 27);
            nbudpricefood.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 16);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 0;
            label4.Text = "Price Food";
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbcategoryfood);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(479, 51);
            panel3.TabIndex = 2;
            // 
            // cmbcategoryfood
            // 
            cmbcategoryfood.FormattingEnabled = true;
            cmbcategoryfood.Location = new Point(150, 13);
            cmbcategoryfood.Name = "cmbcategoryfood";
            cmbcategoryfood.Size = new Size(316, 28);
            cmbcategoryfood.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 16);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Category Food";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtnamefood);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 51);
            panel2.TabIndex = 0;
            // 
            // txtnamefood
            // 
            txtnamefood.Location = new Point(150, 13);
            txtnamefood.Name = "txtnamefood";
            txtnamefood.Size = new Size(316, 27);
            txtnamefood.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 16);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Name Food";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 41);
            label1.TabIndex = 2;
            label1.Text = "Form Add Food";
            // 
            // faddfood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 643);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "faddfood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "faddfood";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbudpricefood).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnaddfood;
        private Panel panel4;
        private NumericUpDown nbudpricefood;
        private Label label4;
        private Panel panel3;
        private ComboBox cmbcategoryfood;
        private Label label3;
        private Panel panel2;
        private TextBox txtnamefood;
        private Label label2;
        private Label label1;
    }
}