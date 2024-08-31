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
    public partial class fChangPassword : Form
    {
        public fChangPassword()
        {
            InitializeComponent();
            txtconfirmpass.UseSystemPasswordChar = true;
            txtnewpass.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnchangepass_Click(object sender, EventArgs e)

        {
            Account ac = this.Tag as Account;
            string newpass = txtnewpass.Text;
            string confirmpass = txtconfirmpass.Text;
            if (newpass.Length == 0 || confirmpass.Length == 0)
            {
                MessageBox.Show("Two passwords cannot be left blank", "Notification");
            }
            else
            {
                if(newpass.Equals(confirmpass))
                {
                    ac.Password = newpass;
                    AccountDao.Instance.updateAccount(ac);
                    MessageBox.Show($"Your new password is " + newpass, "Notification");
                    this.Hide();
                    fLogin f = new fLogin();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("New password and Confirm password do not match, please re-enter","Notification");
                }
            }
        }

        private void btnshowhidden_Click(object sender, EventArgs e)
        {
            if (txtnewpass.UseSystemPasswordChar)
            {
                txtnewpass.UseSystemPasswordChar = false;
                txtconfirmpass.UseSystemPasswordChar=false;
                btnshowhidden.Text = "Hidden Password";
            }
            else
            {
                txtconfirmpass.UseSystemPasswordChar = true;
                txtnewpass.UseSystemPasswordChar = true;
                btnshowhidden.Text = "Show Password";
            }
        }
    }
}
