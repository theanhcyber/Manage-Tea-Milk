using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuanLyQuanTraSua.Dao;
using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            flpTable.AutoScroll = true;
            LoadTable();
            loadFoodandCategory();


        }
        public void hienthitenaccount()
        {
            Account ac = menuStrip1.Tag as Account;

            if (ac != null)
            {
                inforaccountname.Text = "Hello " + ac.DisplayName;

            }
        }

        public MenuStrip menu => menuStrip1;
        decimal tongprice = 0;

        public void loadFoodandCategory()
        {
            cmbCategory.DataSource = FoodCategoryDao.Instance.getAllCategoryFood();
            cmbFood.DataSource = FoodDao.Instance.getAllFood();
            cmbMoveTable.DataSource = TableDao.Instance.getAllTable();
        }

        public void LoadTable()
        {

            List<TableFood> list = new List<TableFood>();
            list = TableDao.Instance.getAllTable();
            foreach (TableFood t in list)
            {
                Button b = new Button()
                {
                    Width = TableDao.Width,
                    Height = TableDao.Height,
                    Text = t.NameTable + Environment.NewLine + ((t.Status == true) ? "Ordered" : "Empty")
                };
                b.Click += B_Click;
                b.Tag = t;
                if (t.Status == false)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }
                flpTable.Controls.Add(b);
            }


        }
        public void ShowBill(int id)
        {
            flpTable.Controls.Clear();
            LoadTable();
            listviewBill.Items.Clear();
            Bill billtable = BillDao.Instance.getBillTableUncheck(id);
            List<Food> listfood = FoodDao.Instance.getAllFood();
            List<BillInformation> list = new List<BillInformation>();
            CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
            if (billtable != null)
            {
                decimal totalprice = 0;
                list = BillInformationDao.Instance.getBillInformationTable(billtable.IdBill);

                if (list != null)
                {
                    var billdetail = from b in list
                                     join f1 in listfood on b.IdFood equals f1.IdFood
                                     select new
                                     {
                                         nameFood = f1.NameFood,
                                         Count = b.Quanlity,
                                         Price = (decimal)f1.PriceFood,
                                         TotalPrice = (decimal)(b.Quanlity * f1.PriceFood)
                                     };


                    foreach (var b in billdetail)
                    {
                        totalprice += b.TotalPrice;
                        ListViewItem lsvitem = new ListViewItem(b.nameFood);
                        lsvitem.SubItems.Add(b.Count.ToString());
                        lsvitem.SubItems.Add(b.Price.ToString("C", vietnameseCulture));
                        lsvitem.SubItems.Add(b.TotalPrice.ToString("C", vietnameseCulture));
                        listviewBill.Items.Add(lsvitem);
                    }
                    txttotalprice.Text = totalprice.ToString("C", vietnameseCulture);
                    tongprice = totalprice;
                }
            }
            else
            {
                listviewBill.Items.Clear();

                ListViewItem nbill = new ListViewItem("No Food Order.");
                nbill.SubItems.Add("0");
                nbill.SubItems.Add("0đ");
                nbill.SubItems.Add("0đ");
                listviewBill.Items.Add(nbill);
                txttotalprice.Text = "0đ";
                tongprice = 0;
            }
        }

        private void B_Click(object? sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableFood).IdTable;
            listviewBill.Tag = (sender as Button).Tag as TableFood;
            ShowBill(tableId);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.Show();

        }

        private void informationOfUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ac = menuStrip1.Tag as Account;

            this.Hide();
            fProfile f = new fProfile();
            f.Tag = ac;
            f.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ac = menuStrip1.Tag as Account;
            if(ac != null)
            {
                if (ac.IdRole == 0)
                {
                    MessageBox.Show("You can not access this screen", "Notification");
                }
                else if (ac.IdRole == 1)
                {
                    this.Hide();
                    fAdmin fAdmin = new fAdmin();
                    fAdmin.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                this.Hide();
                fAdmin fAdmin = new fAdmin();
                fAdmin.ShowDialog();
                this.Show();
            }
            


        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodCategory f = (FoodCategory)cmbCategory.SelectedItem;
            List<Food> listfoodbycategory = FoodDao.Instance.getFoodByCategory(f.IdCategory);
            if (listfoodbycategory != null && listfoodbycategory.Count > 0)
            {
                cmbFood.DataSource = listfoodbycategory;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableFood table = listviewBill.Tag as TableFood;
            Bill checkBill = BillDao.Instance.getBillTableUncheck(table.IdTable);
            if (checkBill != null)
            {
                if (table.Status == false)
                {
                    table.Status = true;
                    TableDao.Instance.updateStatusTable(table);
                }
                int quantity = (int)nbudQuantity.Value;
                Food fadd = cmbFood.SelectedItem as Food;
                List<BillInformation> listbillinfor = BillInformationDao.Instance.getBillInformationTable(checkBill.IdBill);
                if (listbillinfor != null && listbillinfor.Count > 0)
                {
                    BillInformation billfor = null;
                    try
                    {
                        billfor = listbillinfor.First(b => b.IdFood == fadd.IdFood);
                    }
                    catch (Exception ex)
                    {
                        billfor = null;
                    }

                    if (billfor != null)
                    {
                        int quantitycheck = (int)billfor.Quanlity + quantity;

                        if (quantitycheck <= 0)
                        {
                            BillInformationDao.Instance.removeBillInforById(billfor);
                            ShowBill(table.IdTable);
                        }
                        else
                        {
                            billfor.Quanlity = quantitycheck;
                            BillInformationDao.Instance.updateBillInfor(billfor);
                            ShowBill(table.IdTable);
                        }
                    }
                    else if (billfor == null && quantity < 0)
                    {
                        MessageBox.Show("Currently, there is no such dish in Bill, " +
                            "so it is not possible to enter a negative quantity", "Notification");
                    }
                    else if (billfor == null && quantity > 0)
                    {
                        BillInformation billinfornew = new BillInformation();
                        billinfornew.Quanlity = quantity;
                        billinfornew.IdBill = checkBill.IdBill;
                        billinfornew.IdFood = fadd.IdFood;
                        BillInformationDao.Instance.insertBillInfor(billinfornew);
                        ShowBill(table.IdTable);

                    }
                }
                else
                {
                    if (quantity > 0)
                    {
                        BillInformation billinfornew = new BillInformation();
                        billinfornew.Quanlity = quantity;
                        billinfornew.IdBill = checkBill.IdBill;
                        billinfornew.IdFood = fadd.IdFood;
                        BillInformationDao.Instance.insertBillInfor(billinfornew);
                        ShowBill(table.IdTable);
                    }
                    else
                    {
                        MessageBox.Show("You cannot enter negative numbers for quantity", "Notification");
                    }

                }

            }
            else
            {
                if (nbudQuantity.Value <= 0)
                {
                    MessageBox.Show("You cannot enter negative numbers for quantity", "Notification");
                }
                else
                {
                    Bill bill = new Bill();
                    bill.IdTable = table.IdTable;
                    bill.DateCheckIn = DateTime.Now;
                    bill.Status = false;
                    bill.discount = 0;
                    BillDao.Instance.InsertBillForTable(bill);
                    int idbill = BillDao.Instance.getMaxIdBill();
                    table.Status = true;
                    TableDao.Instance.updateStatusTable(table);



                    // Insert billinfor 
                    BillInformation billinf = new BillInformation();
                    billinf.IdBill = idbill;
                    billinf.IdFood = (cmbFood.SelectedItem as Food).IdFood;
                    billinf.Quanlity = (int)nbudQuantity.Value;
                    BillInformationDao.Instance.insertBillInfor(billinf);
                    ShowBill(table.IdTable);
                }

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            TableFood table = listviewBill.Tag as TableFood;
            if (!(bool)table.Status)
            {
                MessageBox.Show("This table No people can not checkout", "Notificaion");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to checkout table " + table.NameTable, "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Bill bill = BillDao.Instance.getBillTableUncheck(table.IdTable);
                    if (bill != null)
                    {
                        bill.Status = true;
                        bill.discount = (int)nUdDiscount.Value;
                        BillDao.Instance.updateStatusBill(bill);
                        Bill check = BillDao.Instance.getBillTableUncheck(table.IdTable);
                        if (check == null)
                        {
                            table.Status = false;
                            TableDao.Instance.updateStatusTable(table);
                        }
                    }
                    else
                    {
                        table.Status = false;
                        TableDao.Instance.updateStatusTable(table);
                    }
                }
            }
            flpTable.Controls.Clear();
            LoadTable();
        }


        private void caculPriceWithDiscount(object sender, EventArgs e)
        {
            CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
            decimal discount = (decimal)nUdDiscount.Value;
            if (discount > 0)
            {
                txttotalprice.Text = (tongprice * (1 - discount / 100)).ToString("C", vietnameseCulture);
            }
        }

        private void btnMoveTable_Click(object sender, EventArgs e)
        {
            TableFood tableto = listviewBill.Tag as TableFood;
            TableFood tablefrom = cmbMoveTable.SelectedItem as TableFood;
            if(tableto.IdTable != tablefrom.IdTable)
            {
                Bill billoftableto = BillDao.Instance.getBillTableUncheck(tableto.IdTable);
                Bill billoftablefrom = BillDao.Instance.getBillTableUncheck(tablefrom.IdTable);
                bool check = false;
                if (billoftableto != null && billoftablefrom != null)
                {
                    List<BillInformation> listbilliforto = BillInformationDao.Instance.getBillInformationTable(billoftableto.IdBill);
                    List<BillInformation> listbilliforfrom = BillInformationDao.Instance.getBillInformationTable(billoftablefrom.IdBill);
                    if (listbilliforfrom != null && listbilliforto != null)
                    {

                        foreach (BillInformation infofrom in listbilliforfrom)
                        {
                            check = false;
                            foreach (BillInformation infoto in listbilliforto)
                            {
                                if (infofrom.IdFood == infoto.IdFood)
                                {
                                    check = true;
                                    infoto.Quanlity = infofrom.Quanlity + infoto.Quanlity;
                                    BillInformationDao.Instance.updateBillInfor(infoto);
                                    BillInformationDao.Instance.removeBillInforById(infofrom);

                                }
                            }
                            if (check == false)
                            {
                                infofrom.IdBill = billoftableto.IdBill;
                                BillInformationDao.Instance.updateBillInfor(infofrom);
                            }



                        }

                        billoftablefrom.Status = true;
                        BillDao.Instance.updateStatusBill(billoftablefrom);
                        Bill billcheck = BillDao.Instance.getBillTableUncheck(tablefrom.IdTable);
                        if (billcheck == null)
                        {
                            tablefrom.Status = false;
                            TableDao.Instance.updateStatusTable(tablefrom);
                        }
                        else
                        {
                            tablefrom.Status = true;
                            TableDao.Instance.updateStatusTable(tablefrom);
                        }
                        ShowBill(tableto.IdTable);

                    }
                    else if (listbilliforfrom == null || listbilliforto == null)
                    {
                        MessageBox.Show("There is no list of dishes in Bill. Please check again", "Notification");
                    }

                    listviewBill.Controls.Clear();
                    LoadTable();
                }
                else if (billoftableto == null || billoftablefrom == null)
                {
                    MessageBox.Show("One of the two tables is still available.Please check again", "Notification");
                }
            }
            else
            {
                MessageBox.Show("The table you chose to merge the bill is the same as the table where the bill is merged", "Notification");
            }
            


        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            hienthitenaccount();
        }
    }
}
