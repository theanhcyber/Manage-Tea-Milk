namespace QuanLyQuanTraSua.View
{
    partial class faddtable
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
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            nbudpeopletable = new NumericUpDown();
            label4 = new Label();
            panel24 = new Panel();
            cmbstatutable = new ComboBox();
            label14 = new Label();
            panel20 = new Panel();
            label10 = new Label();
            txtnametable = new TextBox();
            btnaddtable = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbudpeopletable).BeginInit();
            panel24.SuspendLayout();
            panel20.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(27, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(388, 191);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(nbudpeopletable);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(9, 383);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 56);
            panel4.TabIndex = 14;
            // 
            // nbudpeopletable
            // 
            nbudpeopletable.Location = new Point(168, 14);
            nbudpeopletable.Name = "nbudpeopletable";
            nbudpeopletable.Size = new Size(272, 27);
            nbudpeopletable.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 16);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 6;
            label4.Text = "Number people Table";
            // 
            // panel24
            // 
            panel24.Controls.Add(cmbstatutable);
            panel24.Controls.Add(label14);
            panel24.Location = new Point(9, 295);
            panel24.Name = "panel24";
            panel24.Size = new Size(443, 56);
            panel24.TabIndex = 13;
            // 
            // cmbstatutable
            // 
            cmbstatutable.FormattingEnabled = true;
            cmbstatutable.Items.AddRange(new object[] { "Empty", "Ordered" });
            cmbstatutable.Location = new Point(163, 17);
            cmbstatutable.Name = "cmbstatutable";
            cmbstatutable.Size = new Size(277, 28);
            cmbstatutable.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 17);
            label14.Name = "label14";
            label14.Size = new Size(88, 20);
            label14.TabIndex = 6;
            label14.Text = "Status Table";
            // 
            // panel20
            // 
            panel20.Controls.Add(label10);
            panel20.Controls.Add(txtnametable);
            panel20.Location = new Point(9, 233);
            panel20.Name = "panel20";
            panel20.Size = new Size(443, 56);
            panel20.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 17);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 6;
            label10.Text = "Name Table";
            // 
            // txtnametable
            // 
            txtnametable.Location = new Point(162, 17);
            txtnametable.Name = "txtnametable";
            txtnametable.Size = new Size(277, 27);
            txtnametable.TabIndex = 5;
            // 
            // btnaddtable
            // 
            btnaddtable.Location = new Point(150, 464);
            btnaddtable.Name = "btnaddtable";
            btnaddtable.Size = new Size(111, 40);
            btnaddtable.TabIndex = 16;
            btnaddtable.Text = "Add Table";
            btnaddtable.UseVisualStyleBackColor = true;
            // 
            // faddtable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 533);
            Controls.Add(btnaddtable);
            Controls.Add(panel4);
            Controls.Add(panel24);
            Controls.Add(panel20);
            Controls.Add(pictureBox2);
            Name = "faddtable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "faddtable";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbudpeopletable).EndInit();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel4;
        private NumericUpDown nbudpeopletable;
        private Label label4;
        private Panel panel24;
        public ComboBox cmbstatutable;
        private Label label14;
        private Panel panel20;
        private Label label10;
        private TextBox txtnametable;
        private Button btnaddtable;
    }
}