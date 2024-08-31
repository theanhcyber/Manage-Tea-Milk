namespace QuanLyQuanTraSua.View
{
    partial class fAddAccount
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
            btnloadanh = new Button();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            txtSalary = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txtUserPassword = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            cmbRoleAccount = new ComboBox();
            label6 = new Label();
            panel3 = new Panel();
            txtUserNameDisplay = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            txtUserName = new TextBox();
            label1 = new Label();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnloadanh
            // 
            btnloadanh.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnloadanh.Location = new Point(135, 344);
            btnloadanh.Name = "btnloadanh";
            btnloadanh.Size = new Size(122, 41);
            btnloadanh.TabIndex = 13;
            btnloadanh.Text = "Load Image";
            btnloadanh.UseVisualStyleBackColor = true;
            btnloadanh.Click += btnloadanh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSalary);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(424, 326);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(470, 56);
            panel4.TabIndex = 19;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(203, 11);
            txtSalary.Margin = new Padding(5, 4, 5, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(259, 30);
            txtSalary.TabIndex = 1;
            txtSalary.KeyPress += txtConfirmPassword_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 18);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 0;
            label4.Text = "Salary";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtUserPassword);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(424, 178);
            panel5.Margin = new Padding(5, 4, 5, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(470, 56);
            panel5.TabIndex = 17;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPassword.Location = new Point(203, 13);
            txtUserPassword.Margin = new Padding(5, 4, 5, 4);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(259, 30);
            txtUserPassword.TabIndex = 1;
            txtUserPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 24);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 0;
            label5.Text = "User Password";
            // 
            // panel6
            // 
            panel6.Controls.Add(cmbRoleAccount);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(424, 258);
            panel6.Margin = new Padding(5, 4, 5, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(470, 60);
            panel6.TabIndex = 18;
            // 
            // cmbRoleAccount
            // 
            cmbRoleAccount.FormattingEnabled = true;
            cmbRoleAccount.Location = new Point(203, 18);
            cmbRoleAccount.Name = "cmbRoleAccount";
            cmbRoleAccount.Size = new Size(259, 28);
            cmbRoleAccount.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 18);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 19);
            label6.TabIndex = 0;
            label6.Text = "Role Account";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtUserNameDisplay);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(424, 115);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 55);
            panel3.TabIndex = 16;
            // 
            // txtUserNameDisplay
            // 
            txtUserNameDisplay.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNameDisplay.Location = new Point(203, 10);
            txtUserNameDisplay.Margin = new Padding(5, 4, 5, 4);
            txtUserNameDisplay.Name = "txtUserNameDisplay";
            txtUserNameDisplay.Size = new Size(254, 30);
            txtUserNameDisplay.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 17);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 19);
            label3.TabIndex = 0;
            label3.Text = "User Name Display";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(424, 34);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 53);
            panel2.TabIndex = 15;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(203, 18);
            txtUserName.Margin = new Padding(5, 4, 5, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(254, 30);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 0;
            label1.Text = "User Name Login";
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(627, 404);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(158, 41);
            btnInsert.TabIndex = 20;
            btnInsert.Text = "Insert Account";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // fAddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 498);
            Controls.Add(btnInsert);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnloadanh);
            Controls.Add(pictureBox1);
            Name = "fAddAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAddAccount";
            Load += fAddAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnloadanh;
        private PictureBox pictureBox1;
        private Panel panel4;
        private TextBox txtSalary;
        private Label label4;
        private Panel panel5;
        private TextBox txtUserPassword;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel3;
        private TextBox txtUserNameDisplay;
        private Label label3;
        private Panel panel2;
        private TextBox txtUserName;
        private Label label1;
        private ComboBox cmbRoleAccount;
        private Button btnInsert;
    }
}