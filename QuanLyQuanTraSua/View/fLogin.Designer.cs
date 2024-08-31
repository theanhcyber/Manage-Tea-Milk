namespace QuanLyQuanTraSua
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            logofpt = new PictureBox();
            btnExit = new Button();
            btnLogin = new Button();
            panel2 = new Panel();
            txtPassword = new TextBox();
            label2 = new Label();
            pnlUserName = new Panel();
            txtUserName = new TextBox();
            label1 = new Label();
            lbforgetpass = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logofpt).BeginInit();
            panel2.SuspendLayout();
            pnlUserName.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbforgetpass);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(logofpt);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlUserName);
            panel1.Location = new Point(50, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 422);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(387, 322);
            button1.Name = "button1";
            button1.Size = new Size(181, 32);
            button1.TabIndex = 3;
            button1.Text = "Show Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // logofpt
            // 
            logofpt.Location = new Point(164, 0);
            logofpt.Name = "logofpt";
            logofpt.Size = new Size(448, 133);
            logofpt.TabIndex = 5;
            logofpt.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(598, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(269, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(73, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 71);
            panel2.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.Hand;
            txtPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(254, 23);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 23);
            label2.Name = "label2";
            label2.Size = new Size(162, 24);
            label2.TabIndex = 0;
            label2.Text = "Password Login";
            // 
            // pnlUserName
            // 
            pnlUserName.Controls.Add(txtUserName);
            pnlUserName.Controls.Add(label1);
            pnlUserName.Location = new Point(73, 142);
            pnlUserName.Name = "pnlUserName";
            pnlUserName.Size = new Size(619, 71);
            pnlUserName.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Cursor = Cursors.Hand;
            txtUserName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(254, 27);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(300, 31);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 27);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 0;
            label1.Text = "User Name Login";
            // 
            // lbforgetpass
            // 
            lbforgetpass.AutoSize = true;
            lbforgetpass.Location = new Point(564, 374);
            lbforgetpass.Name = "lbforgetpass";
            lbforgetpass.Size = new Size(128, 20);
            lbforgetpass.TabIndex = 6;
            lbforgetpass.Text = "Forget Password ?";
            lbforgetpass.Click += lbforgetpass_Click;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(822, 450);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Login";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logofpt).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlUserName.ResumeLayout(false);
            pnlUserName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlUserName;
        private TextBox txtUserName;
        private Label label1;
        private Panel panel2;
        private TextBox txtPassword;
        private Label label2;
        private Button btnExit;
        private Button btnLogin;
        private PictureBox logofpt;
        private Button button1;
        private Label lbforgetpass;
    }
}