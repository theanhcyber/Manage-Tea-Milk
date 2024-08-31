using QuanLyQuanTraSua.Dao;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class fProfile : Form
    {
        public fProfile()
        {
            InitializeComponent();
            pictureBox1.ErrorImage = new Bitmap(Application.StartupPath + "/Image/defaultimage.jpg");
            pictureBox1.Image = new Bitmap(Application.StartupPath + "/Image/defaultimage.jpg");

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadInforAccount()
        {
            CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
            Account ac = this.Tag as Account;
            if (ac != null)
            {
                txtUserName.Text = ac.UserName;
                txtUserNameDisplay.Text = ac.DisplayName;
                txtsalary.Text = ac.salary.ToString("C", vietnameseCulture);
                pictureBox1.Image = new Bitmap(ac.image);

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (txtUserPassword.UseSystemPasswordChar)
            {
                txtUserPassword.UseSystemPasswordChar = false;
                txtNewPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
                button.Text = "Hidden Password";
            }
            else
            {
                txtUserPassword.UseSystemPasswordChar = true;
                txtNewPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
                button.Text = "Show Password";
            }
        }

        private void fProfile_Load(object sender, EventArgs e)
        {
            loadInforAccount();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Account ac = this.Tag as Account;
            string displayname = txtUserNameDisplay.Text;
            string password = txtUserPassword.Text;
            string newpass = txtNewPassword.Text;
            string confirmpass = txtConfirmPassword.Text;
            if (displayname.Length == 0)
            {
                MessageBox.Show("Display name cannot be left blank", "Notification");
                txtUserName.BackColor = Color.Red;

            }
            else
            {
                ac.DisplayName = displayname;
                AccountDao.Instance.updateAccount(ac);
                txtUserName.BackColor = Color.White;
                this.Tag = ac;
            }


            if (password.Length != 0! && newpass.Length != 0 && confirmpass.Length != 0)
            {
                if (!ac.Password.Equals(password))
                {
                    MessageBox.Show("Your password enter is incorrect.");
                    txtUserPassword.BackColor = Color.Red;
                    txtNewPassword.BackColor = Color.White;
                    txtConfirmPassword.BackColor = Color.White;
                }
                else if (!newpass.Equals(confirmpass))
                {
                    MessageBox.Show("New password and confirm password do not match");
                    txtNewPassword.BackColor = Color.Red;
                    txtConfirmPassword.BackColor = Color.Red;
                    txtUserPassword.BackColor = Color.White;
                }
                else
                {
                    ac.Password = newpass;
                    AccountDao.Instance.updateAccount(ac);
                    this.Tag = ac;
                    txtUserPassword.BackColor = Color.White;
                    txtNewPassword.BackColor = Color.White;
                    txtConfirmPassword.BackColor = Color.White;

                    MessageBox.Show("Update Password successfully.");
                    loadInforAccount();
                }
            }
            else if (password.Length != 0 || newpass.Length != 0 || confirmpass.Length != 0)
            {
                if (password.Length == 0)
                {
                    MessageBox.Show("Your password is blank");
                    txtUserPassword.BackColor = Color.Red;
                    txtNewPassword.BackColor = Color.White;
                    txtConfirmPassword.BackColor = Color.White;

                }
                else if (newpass.Length == 0)
                {
                    MessageBox.Show("New password is blank");
                    txtNewPassword.BackColor = Color.Red;
                    txtUserPassword.BackColor = Color.White;
                    txtConfirmPassword.BackColor = Color.White;
                }
                else if (confirmpass.Length == 0)
                {
                    MessageBox.Show("confirm password is blank");
                    txtConfirmPassword.BackColor = Color.Red;
                    txtUserPassword.BackColor = Color.White;
                    txtNewPassword.BackColor = Color.White;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fTableManager f = new fTableManager();
            this.Hide();
            f.ShowDialog();



        }

        private void txtresetpass_Click(object sender, EventArgs e)
        {
            string[] list = new string[]
            {
                "a","b","c","d", "e","f","g","h",
                "1","2","3","4", "5","6","7","8"
            };
            string pass = "";

            for (int i = 0; i < 5; i++)
            {
                int index = new Random().Next(list.Length);
                pass += list[index];
            }
            Account ac = this.Tag as Account;
            ac.Password = pass;
            AccountDao.Instance.updateAccount(ac);
            MessageBox.Show("Your new password is " + pass);
            loadInforAccount();
        }
        string currentImagePath = "";
        private void btnloadanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = openFileDialog.FileName;
                pictureBox1.Image = new System.Drawing.Bitmap(currentImagePath);

            }
        }

        private void btnsaveimage_Click(object sender, EventArgs e)
        {
            Account ac = this.Tag as Account;
            if (!string.IsNullOrEmpty(currentImagePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
                saveFileDialog.DefaultExt = "png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    
                    try
                    {
                        File.Copy(currentImagePath, savePath);
                        ac.image = savePath;
                        AccountDao.Instance.updateAccount(ac);
                        MessageBox.Show("The file has been saved successfully");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("An error occurred while saving the file: " + ex.Message);
                    }
                }
            }
            else
            {

            }
        }
    }
}
