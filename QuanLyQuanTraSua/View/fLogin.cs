using Microsoft.Extensions.Configuration;
using QuanLyQuanTraSua.Dao;
using QuanLyQuanTraSua.Models;
using QuanLyQuanTraSua.View;

namespace QuanLyQuanTraSua
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            logofpt.SizeMode = PictureBoxSizeMode.StretchImage;
            logofpt.Image = new Bitmap(Application.StartupPath + "/Image/fpt.png");
        }
        #region Method

        #endregion

        #region Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            fTableManager f = new fTableManager();
            DialogResult check = DialogResult.Yes;/*MessageBox.Show("Are You Sure Login This Account ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);*/
            Account ac = AccountDao.Instance.loginAccount(username, password);

            if (check == DialogResult.Yes)
            {
                if (checkLoginAccountDefalt(username, password))
                {
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (ac != null)
                {
                    f.menu.Tag = ac;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("User Name or Password fail. Try Login again!");
                }
            }
            else
            {
                txtPassword.Text = username;
                txtUserName.Text = password;
            }
        }

        public bool checkLoginAccountDefalt(string username, string password)
        {
            bool check = false;
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            string email1 = configuration["DefaultAccount:Email"];
            string password1 = configuration["DefaultAccount:Password"];
            if (username.Equals(email1) && password.Equals(password1))
            {
                check = true;
            }
            return check;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Notificatiopn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                button1.Text = "Hidden Password";
            }
            else
            {

                txtPassword.UseSystemPasswordChar = true;
                button1.Text = "Show Password";
            }
        }

        private void lbforgetpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            fforgetpassword f = new fforgetpassword();
            f.ShowDialog();
            this.Show();
        }
    }
}