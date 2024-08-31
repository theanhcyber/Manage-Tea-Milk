using QuanLyQuanTraSua.Dao;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.View
{
    public partial class fforgetpassword : Form
    {
        public fforgetpassword()
        {
            InitializeComponent();
        }

        private void fforgetpassword_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "/Image/forget.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            if (email.Length == 0)
            {
                MessageBox.Show("You need to enter your email to be able to change your password", "Notification");
            }
            else
            {
                Account ac = AccountDao.Instance.getAccount(email);
                if (ac != null)
                {
                    fChangPassword f = new fChangPassword();
                    f.Tag = ac;
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Email invalid. Enter try agian!", "Notification");
                }
            }
        }
    }
}
