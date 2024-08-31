namespace QuanLyQuanTraSua.View
{
    partial class fforgetpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fforgetpassword));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtemail = new TextBox();
            btnchangepass = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 277);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(180, 274);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(304, 27);
            txtemail.TabIndex = 2;
            // 
            // btnchangepass
            // 
            btnchangepass.Location = new Point(348, 337);
            btnchangepass.Name = "btnchangepass";
            btnchangepass.Size = new Size(136, 29);
            btnchangepass.TabIndex = 3;
            btnchangepass.Text = "Change Password";
            btnchangepass.UseVisualStyleBackColor = true;
            btnchangepass.Click += btnchangepass_Click;
            // 
            // fforgetpassword
            // 
            AcceptButton = btnchangepass;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnchangepass);
            Controls.Add(txtemail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "fforgetpassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fforgetpassword";
            Load += fforgetpassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtemail;
        private Button btnchangepass;
    }
}