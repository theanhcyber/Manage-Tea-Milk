using Microsoft.EntityFrameworkCore;
using QuanLyQuanTraSua.Dao;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.View
{
    public partial class fAddAccount : Form
    {
        public fAddAccount()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
        string currentImagePath = "";
        string saveImagePath = "";
        private void btnloadanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = openFileDialog.FileName;
                pictureBox1.Image = new System.Drawing.Bitmap(currentImagePath);
                DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
                long namefile = dateTimeOffset.ToUnixTimeMilliseconds();
                saveImagePath = Application.StartupPath + "/Image/" + namefile + ".jpg";
            }
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtUserPassword.Text;
            string display = txtUserNameDisplay.Text;
            RoleAccount r = cmbRoleAccount.SelectedItem as RoleAccount;
            string salary = txtSalary.Text;
            Account ac = new Account();
            Account check = AccountDao.Instance.getAccount(username);
            if (check != null)
            {
                MessageBox.Show("This account already exists try another accoun", "Notification");
            }
            else
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass)
               || string.IsNullOrEmpty(display) || string.IsNullOrEmpty(salary))
                {
                    MessageBox.Show("You Need full information", "Notification");
                }
                else
                {
                    try
                    {
                        File.Copy(currentImagePath, saveImagePath);
                        ac.image = saveImagePath;
                        ac.UserName = username;
                        ac.Password = pass;
                        ac.DisplayName = display;
                        ac.salary = double.Parse(salary);
                        ac.IdRole = r.IdRole;
                        ac.IdRoleNavigation = r;
                        AccountDao.Instance.insertAccount(ac);
                        MessageBox.Show("Insert susccessfully Account " + ac.UserName, "Notification");
                        fAdmin f = new fAdmin();
                        f.getAllAcoount();

                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("An error occurred while saving the file: " + ex.Message);
                    }
                }
            }


        }

        private void fAddAccount_Load(object sender, EventArgs e)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
            long namefile = dateTimeOffset.ToUnixTimeMilliseconds();
            cmbRoleAccount.DataSource = AccountDao.Instance.GetAllRoleAccounts();
            pictureBox1.Image = new Bitmap(Application.StartupPath + "/Image/defaultimage.jpg");

            currentImagePath = Application.StartupPath + "/Image/defaultimage.jpg";
            saveImagePath = Application.StartupPath + "/Image/" + namefile + ".jpg";
        }
    }
}
