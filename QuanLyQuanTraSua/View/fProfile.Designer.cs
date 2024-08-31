namespace QuanLyQuanTraSua
{
    partial class fProfile
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
            panel45 = new Panel();
            btnsaveimage = new Button();
            btnloadanh = new Button();
            pictureBox1 = new PictureBox();
            txtresetpass = new Button();
            button1 = new Button();
            txtsalary = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            btnUpdateProfile = new Button();
            panel4 = new Panel();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txtUserPassword = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            txtNewPassword = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            txtUserNameDisplay = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtUserName = new TextBox();
            label1 = new Label();
            panel45.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel45
            // 
            panel45.Controls.Add(btnsaveimage);
            panel45.Controls.Add(btnloadanh);
            panel45.Controls.Add(pictureBox1);
            panel45.Controls.Add(txtresetpass);
            panel45.Controls.Add(button1);
            panel45.Controls.Add(txtsalary);
            panel45.Controls.Add(label7);
            panel45.Controls.Add(btnCancel);
            panel45.Controls.Add(btnUpdateProfile);
            panel45.Controls.Add(panel4);
            panel45.Controls.Add(panel5);
            panel45.Controls.Add(panel6);
            panel45.Controls.Add(panel3);
            panel45.Controls.Add(label2);
            panel45.Controls.Add(panel2);
            panel45.Location = new Point(158, 16);
            panel45.Margin = new Padding(5, 4, 5, 4);
            panel45.Name = "panel45";
            panel45.Size = new Size(877, 682);
            panel45.TabIndex = 0;
            panel45.Paint += panel1_Paint;
            // 
            // btnsaveimage
            // 
            btnsaveimage.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsaveimage.Location = new Point(225, 410);
            btnsaveimage.Name = "btnsaveimage";
            btnsaveimage.Size = new Size(117, 41);
            btnsaveimage.TabIndex = 11;
            btnsaveimage.Text = "Save Image";
            btnsaveimage.UseVisualStyleBackColor = true;
            btnsaveimage.Click += btnsaveimage_Click;
            // 
            // btnloadanh
            // 
            btnloadanh.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnloadanh.Location = new Point(52, 410);
            btnloadanh.Name = "btnloadanh";
            btnloadanh.Size = new Size(122, 41);
            btnloadanh.TabIndex = 10;
            btnloadanh.Text = "Load Image";
            btnloadanh.UseVisualStyleBackColor = true;
            btnloadanh.Click += btnloadanh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(5, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtresetpass
            // 
            txtresetpass.Location = new Point(313, 592);
            txtresetpass.Margin = new Padding(5, 4, 5, 4);
            txtresetpass.Name = "txtresetpass";
            txtresetpass.Size = new Size(132, 85);
            txtresetpass.TabIndex = 8;
            txtresetpass.Text = "Reset Password";
            txtresetpass.UseVisualStyleBackColor = true;
            txtresetpass.Click += txtresetpass_Click;
            // 
            // button1
            // 
            button1.Location = new Point(462, 592);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(135, 85);
            button1.TabIndex = 7;
            button1.Text = "Show Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(5, 638);
            txtsalary.Margin = new Padding(5, 4, 5, 4);
            txtsalary.Name = "txtsalary";
            txtsalary.ReadOnly = true;
            txtsalary.Size = new Size(262, 34);
            txtsalary.TabIndex = 2;
            txtsalary.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(52, 600);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(159, 19);
            label7.TabIndex = 2;
            label7.Text = "Salary of Employee";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(729, 593);
            btnCancel.Margin = new Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 85);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new Point(607, 592);
            btnUpdateProfile.Margin = new Padding(5, 4, 5, 4);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(114, 85);
            btnUpdateProfile.TabIndex = 5;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtConfirmPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(396, 490);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(470, 90);
            panel4.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(203, 29);
            txtConfirmPassword.Margin = new Padding(5, 4, 5, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(259, 30);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 39);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(154, 19);
            label4.TabIndex = 0;
            label4.Text = "Confirm Password";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtUserPassword);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(396, 284);
            panel5.Margin = new Padding(5, 4, 5, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(470, 101);
            panel5.TabIndex = 3;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPassword.Location = new Point(203, 24);
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
            label5.Location = new Point(59, 34);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 0;
            label5.Text = "User Password";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtNewPassword);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(396, 393);
            panel6.Margin = new Padding(5, 4, 5, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(470, 90);
            panel6.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(203, 29);
            txtNewPassword.Margin = new Padding(5, 4, 5, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(259, 30);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 39);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 19);
            label6.TabIndex = 0;
            label6.Text = "New Password";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtUserNameDisplay);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(396, 187);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 90);
            panel3.TabIndex = 2;
            // 
            // txtUserNameDisplay
            // 
            txtUserNameDisplay.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserNameDisplay.Location = new Point(208, 29);
            txtUserNameDisplay.Margin = new Padding(5, 4, 5, 4);
            txtUserNameDisplay.Name = "txtUserNameDisplay";
            txtUserNameDisplay.Size = new Size(254, 30);
            txtUserNameDisplay.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 39);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 19);
            label3.TabIndex = 0;
            label3.Text = "User Name Display";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(313, 23);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 27);
            label2.TabIndex = 1;
            label2.Text = "USer Profile";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(396, 90);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 90);
            panel2.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(208, 29);
            txtUserName.Margin = new Padding(5, 4, 5, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(254, 30);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 39);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 0;
            label1.Text = "User Name Login";
            // 
            // fProfile
            // 
            AcceptButton = btnUpdateProfile;
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1174, 706);
            Controls.Add(panel45);
            Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "fProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Profile";
            Load += fProfile_Load;
            panel45.ResumeLayout(false);
            panel45.PerformLayout();
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

        private Panel panel45;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private Panel panel4;
        private TextBox txtConfirmPassword;
        private Label label4;
        private Panel panel6;
        private TextBox txtNewPassword;
        private Label label6;
        private Panel panel3;
        private TextBox txtUserNameDisplay;
        private Label label3;
        private Button btnUpdateProfile;
        private Button btnCancel;
        private TextBox txtsalary;
        private Label label7;
        private Button button1;
        private Button txtresetpass;
        private Panel panel5;
        private TextBox txtUserPassword;
        private Label label5;
        private Button btnsaveimage;
        private Button btnloadanh;
        private PictureBox pictureBox1;
    }
}