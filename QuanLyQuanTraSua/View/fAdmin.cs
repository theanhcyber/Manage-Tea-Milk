using QuanLyQuanTraSua.Dao;
using QuanLyQuanTraSua.Models;
using QuanLyQuanTraSua.View;
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
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyQuanTraSua
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            getAllBill();
            getAllTable();
            getAllCategory();
            getAllFood();
            getallcategoryforfood();
            getAllAcoount();
            f.btnaddtable1.Click += Btnaddtable1_Click1;
            fcate.faddbutton.Click += Faddbutton_Click;
            ffood.addFood.Click += AddFood_Click;
        }



        faddtable f = new faddtable();
        faddfoodcategory fcate = new faddfoodcategory();
        faddfood ffood = new faddfood();
        private CultureInfo vietnameseCulture1 = new CultureInfo("vi-VN");

        #region Bill
        public void getAllBill()
        {
            List<Bill> listbills = BillDao.Instance.getAllBill();
            dgvDisplayBill.DataSource = listbills.Select(x => new
            {
                x.IdBill,
                x.IdTableNavigation.NameTable,
                x.DateCheckIn,
                x.DateCheckOut,
                StatusBill = (x.Status == true) ? "Paid" : "Unpaid",
                Discount = x.discount
            }).ToList();

        }
        private void dgvDisplayBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                int idBill = (int)dgvDisplayBill[0, row].Value;
                int discount = (int)dgvDisplayBill[5, row].Value;

                double revenue = 0;
                CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
                List<BillInformation> listBillInfor = BillInformationDao.Instance.getAllBillInforByIdBill(idBill);

                if (listBillInfor != null)
                {
                    foreach (BillInformation b in listBillInfor)
                    {
                        revenue = revenue + (b.Quanlity.Value * b.IdFoodNavigation.PriceFood);
                    }

                    txtrevenue.Text = (revenue - revenue * discount / 100).ToString("C", vietnameseCulture);
                    dgvBillInforList.DataSource = listBillInfor.Select(x => new
                    {
                        IdBillDetail = x.IdBillInfor,
                        x.IdBill,
                        x.IdFoodNavigation.NameFood,
                        PriceFood = x.IdFoodNavigation.PriceFood.ToString("C", vietnameseCulture),
                        Quantity = x.Quanlity
                    }).ToList();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            List<Bill> listbills = BillDao.Instance.getBillsByDay(from, to);
            dgvDisplayBill.DataSource = listbills.Select(x => new
            {
                x.IdBill,
                x.IdTableNavigation.NameTable,
                x.DateCheckIn,
                x.DateCheckOut,
                StatusBill = (x.Status == true) ? "Paid" : "Unpaid",
                Discount = x.discount
            }).ToList();
        }

        private void btnshowallbill_Click(object sender, EventArgs e)
        {
            getAllBill();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            List<Bill> listbills = BillDao.Instance.getAllBillPaid();
            dgvDisplayBill.DataSource = listbills.Select(x => new
            {
                x.IdBill,
                x.IdTableNavigation.NameTable,
                x.DateCheckIn,
                x.DateCheckOut,
                StatusBill = (x.Status == true) ? "Paid" : "Unpaid",
                Discount = x.discount
            }).ToList();
        }

        private void btnunPaid_Click(object sender, EventArgs e)
        {
            List<Bill> listbills = BillDao.Instance.getAllBillUnpaid();
            dgvDisplayBill.DataSource = listbills.Select(x => new
            {
                x.IdBill,
                x.IdTableNavigation.NameTable,
                x.DateCheckIn,
                x.DateCheckOut,
                StatusBill = (x.Status == true) ? "Paid" : "Unpaid",
                Discount = x.discount
            }).ToList();
        }

        private void btnbillinday_Click(object sender, EventArgs e)
        {
            List<Bill> listbills = BillDao.Instance.getAllBillInDay();
            dgvDisplayBill.DataSource = listbills.Select(x => new
            {
                x.IdBill,
                x.IdTableNavigation.NameTable,
                x.DateCheckIn,
                x.DateCheckOut,
                StatusBill = (x.Status == true) ? "Paid" : "Unpaid",
                Discount = x.discount
            }).ToList();
        }
        #endregion
        #region Table
        public void getAllTable()
        {

            dgvlisttable.DataSource = TableDao.Instance.getAllTable().Select(x => new
            {
                x.IdTable,
                x.NameTable,
                Status = (bool)x.Status ? "Ordered" : "Empty",
                x.MaximunPeople
            }).ToList();
        }
        private void dgvlisttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtidtable.Text = dgvlisttable[0, row].Value.ToString();
                txtnametable.Text = dgvlisttable[1, row].Value.ToString();
                cmbstatutable.SelectedItem = dgvlisttable[2, row].Value.ToString();
                nbudpeopletable.Value = (int)dgvlisttable[3, row].Value;
            }
        }

        private void btnlisttable_Click(object sender, EventArgs e)
        {
            dgvlisttable.DataSource = TableDao.Instance.getAllTable().Select(x => new
            {
                x.IdTable,
                x.NameTable,
                Status = (bool)x.Status ? "Ordered" : "Empty",
                x.MaximunPeople
            }).ToList();
        }

        private void btntableempty_Click(object sender, EventArgs e)
        {
            dgvlisttable.DataSource = TableDao.Instance.getAllTableEmpty().Select(x => new
            {
                x.IdTable,
                x.NameTable,
                Status = (bool)x.Status ? "Ordered" : "Empty",
                x.MaximunPeople
            }).ToList();
        }

        private void btntableordered_Click(object sender, EventArgs e)
        {
            dgvlisttable.DataSource = TableDao.Instance.getAllTableOrdered().Select(x => new
            {
                x.IdTable,
                x.NameTable,
                Status = (bool)x.Status ? "Ordered" : "Empty",
                x.MaximunPeople
            }).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = txtsearchtable.Text;
            dgvlisttable.DataSource = TableDao.Instance.getAllTableByName(search).Select(x => new
            {
                x.IdTable,
                x.NameTable,
                Status = (bool)x.Status ? "Ordered" : "Empty",
                x.MaximunPeople
            }).ToList();

        }
        private void btnupdatetable_Click(object sender, EventArgs e)
        {
            string nametable = "";
            string statustable = "";
            int numberofpeople = -1;
            int idtable = 1;
            try
            {
                nametable = txtnametable.Text;
                statustable = cmbstatutable.SelectedItem.ToString();
                numberofpeople = (int)nbudpeopletable.Value;
                idtable = Convert.ToInt32(txtidtable.Text);
            }
            catch (Exception ee)
            {
                idtable = -1;
            }



            if (idtable != -1)
            {
                if (nametable.Length == 0)
                {
                    MessageBox.Show("Table name cannot be left blank", "Notification");
                }
                else if (numberofpeople == 0)
                {
                    MessageBox.Show("The number of people must not be equal to 0", "Notification");
                }
                else
                {
                    TableFood table = TableDao.Instance.gettableById(idtable);
                    table.NameTable = nametable;
                    table.Status = statustable.Equals("Ordered");
                    table.MaximunPeople = numberofpeople;
                    TableDao.Instance.updateStatusTable(table);
                }
            }
            else
            {
                MessageBox.Show("You have not entered any information", "Notification");
            }
            getAllTable();
        }

        private void Btnaddtable1_Click1(object? sender, EventArgs e)
        {
            string nametable = f.nameTable.Text;
            string statustable = f.statutable.SelectedItem.ToString();
            int numberofpeople = (int)f.numbertable.Value;


            if (nametable.Length == 0)
            {
                MessageBox.Show("Table name cannot be left blank", "Notification");
            }
            else if (numberofpeople == 0)
            {
                MessageBox.Show("The number of people must not be equal to 0", "Notification");
            }
            else
            {
                TableFood table = TableDao.Instance.getTableByName(nametable);
                if (table != null)
                {
                    MessageBox.Show("The table name is already the same as another table", "Notification");

                }
                else
                {
                    table = new TableFood();
                    table.NameTable = nametable;
                    table.Status = statustable.Equals("Ordered");
                    table.MaximunPeople = numberofpeople;
                    TableDao.Instance.addtable(table);
                    f.Hide();
                }

            }
            getAllTable();
        }
        private void btnaddtable_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
        }
        private void btndeletetable_Click(object sender, EventArgs e)
        {
            string nametable = "";
            string statustable = "";
            int numberofpeople = 0;
            int idtable = -1;
            try
            {
                nametable = txtnametable.Text;
                statustable = cmbstatutable.SelectedItem.ToString();
                numberofpeople = (int)nbudpeopletable.Value;
                idtable = Convert.ToInt32(txtidtable.Text);
            }
            catch (Exception ee)
            {
                idtable = -1;
            }

            if (idtable != -1)
            {

                if (MessageBox.Show("If you delete the table, the bill will also be deleted! " +
                    "Are you sure to delete the table " + nametable
                , "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    TableFood table = TableDao.Instance.gettableById(idtable);
                    List<Bill> listbill = new List<Bill>();
                    List<BillInformation> listbillinfor = new List<BillInformation>();
                    if (table != null)
                    {
                        listbill = BillDao.Instance.getBillTable(table.IdTable);
                        if (listbill == null || listbill.Count == 0)
                        {
                            TableDao.Instance.removetable(table);
                        }
                        else
                        {

                            foreach (Bill bill in listbill)
                            {
                                List<BillInformation> listcheck = new List<BillInformation>();
                                listcheck = BillInformationDao.Instance.getAllBillInforByIdBill(bill.IdBill);
                                if (listcheck != null)
                                {
                                    listbillinfor.AddRange(listcheck);
                                    listcheck.Clear();
                                }
                            }

                            if (listbillinfor.Count != 0)
                            {
                                BillInformationDao.Instance.removeBillInforArrage(listbillinfor);
                                BillDao.Instance.deleteListBill(listbill);
                                TableDao.Instance.removetable(table);
                            }
                        }

                    }

                }

            }
            getAllTable();
        }
        #endregion
        #region FoodCategory
        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            fcate.ShowDialog();
        }
        private void Faddbutton_Click(object? sender, EventArgs e)
        {
            string name = fcate.faddnameCate.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Name category cannot be left blank", "Notification");
            }
            else
            {
                FoodCategory category = new FoodCategory();
                category.NameCategory = name;
                int check = FoodCategoryDao.Instance.addFoodCategory(category);
                if (check == 0)
                {
                    MessageBox.Show("Add Food Category :" + category.NameCategory + " failed", "Notification");
                }
                else
                {
                    MessageBox.Show("Add Food Category :" + category.NameCategory + " successed", "Notification");
                }
                getAllCategory();
            }


        }
        private void btnupdatecategory_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtidcategory.Text);
            string name = txtnamecategory.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Name category cannot be left blank", "Notification");
            }
            else
            {
                FoodCategory category = FoodCategoryDao.Instance.getFoodCategory(id);
                if (category != null)
                {
                    category.NameCategory = name;
                }
                int check = FoodCategoryDao.Instance.updateFoodCategory(category);
                if (check == 0)
                {
                    MessageBox.Show("Update Food Category :" + category.NameCategory + " failed", "Notification");
                }
                else
                {
                    MessageBox.Show("Update Food Category :" + category.NameCategory + " successed", "Notification");
                }
                getAllCategory();
            }
        }
        private void btndeletecategory_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtidcategory.Text);
            string name = txtnamecategory.Text;
            FoodCategory category = FoodCategoryDao.Instance.getFoodCategory(id);
            if (MessageBox.Show("Are you sure you want to delete this type of food", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int check = FoodCategoryDao.Instance.deleteFoodCategory(category);
                if (check == 0)
                {
                    MessageBox.Show("Delete Food Category :" + category.NameCategory + " failed", "Notification");
                }
                else
                {
                    MessageBox.Show("Delete Food Category :" + category.NameCategory + " successed.", "Notification");
                }
                getAllCategory();
            }

        }

        private void btnlistcategory_Click(object sender, EventArgs e)
        {
            dgvfoodcategory.DataSource = FoodCategoryDao.Instance.getAllCategoryFood().Select(x => new
            {
                x.IdCategory,
                x.NameCategory,

            }).ToList();
        }
        public void getAllCategory()
        {
            dgvfoodcategory.DataSource = FoodCategoryDao.Instance.getAllCategoryFood().Select(x => new
            {
                x.IdCategory,
                x.NameCategory,

            }).ToList();
        }

        private void dgvfoodcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                int idcater = (int)dgvfoodcategory[0, row].Value;
                string namecate = dgvfoodcategory[1, row].Value.ToString();
                dgvlistfoodcategory.DataSource = FoodDao.Instance.getFoodByCategory(idcater).Select(x => new
                {
                    x.IdFood,
                    x.NameFood,
                    x.PriceFood
                }).ToList();


                // show infor
                txtnamecategory.Text = namecate;
                txtidcategory.Text = idcater.ToString();
            }
        }
        #endregion
        #region Food
        public void getAllFood()
        {
            dgvfood.DataSource = FoodDao.Instance.getAllFood().Select(x => new
            {
                x.IdFood,
                x.NameFood,
                x.PriceFood,
                x.IdCategoryNavigation.NameCategory

            }).ToList();
        }

        public void getallcategoryforfood()
        {
            cmbcategoryfood.DataSource = FoodCategoryDao.Instance.getAllCategoryFood();
            cmbcategoryfoodview.DataSource = FoodCategoryDao.Instance.getAllCategoryFood();
        }


        private void txtsearchnamefood_TextChanged(object sender, EventArgs e)
        {
            string namefood = txtsearchnamefood.Text;
            dgvfood.DataSource = FoodDao.Instance.getListFoodByName(namefood).Select(x => new
            {
                x.IdFood,
                x.NameFood,
                PriceFood = x.PriceFood.ToString("C", vietnameseCulture1),
                x.IdCategoryNavigation.NameCategory

            }).ToList(); ;


        }

        private void cmbcategoryfood_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategory f = (FoodCategory)cmbcategoryfood.SelectedItem;
            dgvfood.DataSource = FoodDao.Instance.getFoodByCategory(f.IdCategory).Select(x => new
            {
                x.IdFood,
                x.NameFood,
                PriceFood = x.PriceFood.ToString("C", vietnameseCulture1),
                x.IdCategoryNavigation.NameCategory

            }).ToList();
        }

        private void btnlistfood_Click(object sender, EventArgs e)
        {
            getAllFood();
        }

        private void dgvfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Food f = new Food();
            int row = e.RowIndex;
            if (row >= 0)
            {
                int id = (int)dgvfood[0, row].Value;
                f = FoodDao.Instance.getFoodByid(id);
                txtidfood.Text = f.IdFood.ToString();
                txtfoodname.Text = f.NameFood;
                nbudpricefood.Value = (int)f.PriceFood;
                cmbcategoryfood.SelectedItem = f.IdCategoryNavigation;



            }
        }

        private void btnupdatefood_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtidfood.Text);
            string name = txtfoodname.Text;
            double price = (double)nbudpricefood.Value;
            FoodCategory f = (FoodCategory)cmbcategoryfood.SelectedItem;
            if (name.Length == 0)
            {
                MessageBox.Show("The name of the food cannot be left blank", "Notification");
            }
            else
            {
                Food food = FoodDao.Instance.getFoodByid(id);
                food.NameFood = name.Trim();
                food.IdCategory = f.IdCategory;
                food.PriceFood = price;
                int check = FoodDao.Instance.updateFood(food);

                if (check == 0)
                {
                    MessageBox.Show("Update Food  :" + food.NameFood + " failed", "Notification");
                }
                else
                {
                    MessageBox.Show("Update Food  :" + food.NameFood + " successed", "Notification");
                    FoodCategory f1 = (FoodCategory)cmbcategoryfood.SelectedItem;
                    dgvfood.DataSource = FoodDao.Instance.getFoodByCategory(f1.IdCategory).Select(x => new
                    {
                        x.IdFood,
                        x.NameFood,
                        PriceFood = x.PriceFood.ToString("C", vietnameseCulture1),
                        x.IdCategoryNavigation.NameCategory

                    }).ToList();
                }
            }

        }

        private void btndeletefood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this  food"
                , "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = Int32.Parse(txtidfood.Text);
                Food food = FoodDao.Instance.getFoodByid(id);
                int check = FoodDao.Instance.removeFood(food);
                if (check == 0)
                {
                    MessageBox.Show("Delete Food  :" + food.NameFood + " failed", "Notification");
                }
                else
                {
                    MessageBox.Show("Delete Food  :" + food.NameFood + " successed", "Notification");
                    FoodCategory f1 = (FoodCategory)cmbcategoryfood.SelectedItem;
                    dgvfood.DataSource = FoodDao.Instance.getFoodByCategory(f1.IdCategory).Select(x => new
                    {
                        x.IdFood,
                        x.NameFood,
                        PriceFood = x.PriceFood.ToString("C", vietnameseCulture1),
                        x.IdCategoryNavigation.NameCategory

                    }).ToList();
                }
            }

        }

        private void btnaddfood_Click(object sender, EventArgs e)
        {

            ffood.categoryFood.DataSource = FoodCategoryDao.Instance.getAllCategoryFood();
            ffood.ShowDialog();
        }
        private void AddFood_Click(object? sender, EventArgs e)
        {
            string nameFood = ffood.nameFood.Text;
            FoodCategory category = (FoodCategory)ffood.categoryFood.SelectedItem;
            double priceFood = (double)ffood.priceFood.Value;
            if (MessageBox.Show("Are you sure you want to add this  food"
                , "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (nameFood.Length == 0)
                {
                    MessageBox.Show("Name food can not empty", "Notification");
                }
                else if (priceFood == 0)
                {
                    MessageBox.Show("Price  food can not = 0 đ", "Notification");
                }
                else
                {
                    Food fadd = new Food();
                    fadd.NameFood = nameFood;
                    fadd.IdCategory = category.IdCategory;
                    fadd.PriceFood = priceFood;
                    int check1 = FoodDao.Instance.addFood(fadd);
                    if (check1 == 0)
                    {
                        MessageBox.Show("Add Food  :" + fadd.NameFood + " failed", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Add Food  :" + fadd.NameFood + " successed", "Notification");
                        FoodCategory f1 = (FoodCategory)ffood.categoryFood.SelectedItem;
                        dgvfood.DataSource = FoodDao.Instance.getFoodByCategory(f1.IdCategory).Select(x => new
                        {
                            x.IdFood,
                            x.NameFood,
                            PriceFood = x.PriceFood.ToString("C", vietnameseCulture1),
                            x.IdCategoryNavigation.NameCategory

                        }).ToList();
                        ffood.Hide();
                    }

                }
            }
        }
        #endregion
        #region Account
        public void getAllAcoount()
        {
            dgvacount.DataSource = AccountDao.Instance.GetAllAccounts().Select(x => new
            {
                x.UserName,
                x.DisplayName,
                x.IdRoleNavigation.NameRole,
                x.salary
            }).ToList();

            cmbroleaccount.DataSource = AccountDao.Instance.GetAllRoleAccounts();
        }
        private void dgvacount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            int row = e.RowIndex;
            if (row >= 0)
            {
                string username = dgvacount[0, row].Value.ToString();
                Account account = AccountDao.Instance.GetAccountByuserName(username);
                txtnameaccount.Text = account.UserName;
                txtpass.Text = account.Password;
                txtdisplayname.Text = account.DisplayName;
                cmbroleaccount.SelectedItem = AccountDao.Instance.GetRoleAccountById(account.IdRole);
                txtsalary.Text = account.salary.ToString();

            }
        }

        private void btnresetpass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure reset password for this account", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string username = txtnameaccount.Text;
                Account account = AccountDao.Instance.GetAccountByuserName(username);
                account.Password = "1234";
                MessageBox.Show("The new password for the account is 1234", "Notification");
                AccountDao.Instance.ResetPassword(account);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar)
            {
                txtpass.UseSystemPasswordChar = false;
                button2.Text = "Hidd Password";
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                button2.Text = "Show Password";
            }

        }

        private void btnlistaccount_Click(object sender, EventArgs e)
        {
            getAllAcoount();
        }

        private void btnupdateaccount_Click(object sender, EventArgs e)
        {
            string username = txtnameaccount.Text;
            string password = txtpass.Text;
            string displayname = txtdisplayname.Text;
            string salary = txtsalary.Text;
            RoleAccount r = cmbroleaccount.SelectedItem as RoleAccount;
            Account ac = AccountDao.Instance.GetAccountByuserName(username);
            ac.Password = password;
            ac.DisplayName = displayname;
            ac.IdRole = r.IdRole;
            ac.IdRoleNavigation = r;
            ac.salary = double.Parse(salary);
            AccountDao.Instance.updateAccount(ac);
            MessageBox.Show("Update successfully " + ac.UserName);
            getAllAcoount();


        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnaddaccount_Click(object sender, EventArgs e)
        {
            fAddAccount f = new fAddAccount();
            f.ShowDialog();
        }

        private void btndeleteaccount_Click(object sender, EventArgs e)
        {
            string namecheck = txtnameaccount.Text;
            if (namecheck.Length == 0)
            {
                MessageBox.Show("You have not selected an account to delete", "Notification");
            }
            else
            {
                Account ac = AccountDao.Instance.GetAccountByuserName(namecheck);
                if (ac == null)
                {
                    MessageBox.Show("Account dont't exit to delete", "Notification");
                }
                else
                {
                    AccountDao.Instance.deleteAccount(ac);
                    MessageBox.Show("Delete account " + ac.UserName + " successfull.", "Notification");
                    getAllAcoount();
                }
            }


        }
        #endregion


    }
}
