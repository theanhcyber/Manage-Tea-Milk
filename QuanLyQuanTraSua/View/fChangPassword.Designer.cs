namespace QuanLyQuanTraSua.View
{
    partial class fChangPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChangPassword));
            btnchangepass = new Button();
            txtnewpass = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtconfirmpass = new TextBox();
            label2 = new Label();
            btnshowhidden = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnchangepass
            // 
            btnchangepass.Location = new Point(279, 398);
            btnchangepass.Name = "btnchangepass";
            btnchangepass.Size = new Size(152, 29);
            btnchangepass.TabIndex = 7;
            btnchangepass.Text = "Change Password";
            btnchangepass.UseVisualStyleBackColor = true;
            btnchangepass.Click += btnchangepass_Click;
            // 
            // txtnewpass
            // 
            txtnewpass.Location = new Point(200, 270);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.Size = new Size(262, 27);
            txtnewpass.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 277);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 5;
            label1.Text = "Enter New Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.Location = new Point(200, 328);
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.Size = new Size(262, 27);
            txtconfirmpass.TabIndex = 9;
            txtconfirmpass.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 331);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter Confirm Password";
            // 
            // btnshowhidden
            // 
            btnshowhidden.Location = new Point(116, 398);
            btnshowhidden.Name = "btnshowhidden";
            btnshowhidden.Size = new Size(137, 29);
            btnshowhidden.TabIndex = 10;
            btnshowhidden.Text = "Show Password";
            btnshowhidden.UseVisualStyleBackColor = true;
            btnshowhidden.Click += btnshowhidden_Click;
            // 
            // fChangPassword
            // 
            AcceptButton = btnchangepass;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(btnshowhidden);
            Controls.Add(txtconfirmpass);
            Controls.Add(label2);
            Controls.Add(btnchangepass);
            Controls.Add(txtnewpass);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "fChangPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fChangPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnchangepass;
        private TextBox txtnewpass;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtconfirmpass;
        private Label label2;
        private Button btnshowhidden;
    }
}