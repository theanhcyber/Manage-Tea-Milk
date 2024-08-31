namespace QuanLyQuanTraSua
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            inforaccountname = new ToolStripMenuItem();
            menuprofile = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            listviewBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txttotalprice = new TextBox();
            button1 = new Button();
            cmbMoveTable = new ComboBox();
            nUdDiscount = new NumericUpDown();
            btnCheckOut = new Button();
            btnDiscount = new Button();
            btnMoveTable = new Button();
            panel4 = new Panel();
            nbudQuantity = new NumericUpDown();
            btnAddFood = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbFood = new ComboBox();
            cmbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUdDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbudQuantity).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, inforaccountname });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1308, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // inforaccountname
            // 
            inforaccountname.DropDownItems.AddRange(new ToolStripItem[] { menuprofile, logoutToolStripMenuItem });
            inforaccountname.Name = "inforaccountname";
            inforaccountname.Size = new Size(177, 24);
            inforaccountname.Text = "Information of Account";
            // 
            // menuprofile
            // 
            menuprofile.Name = "menuprofile";
            menuprofile.Size = new Size(221, 26);
            menuprofile.Text = "Information of User";
            menuprofile.Click += informationOfUserToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(221, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listviewBill);
            panel2.Location = new Point(700, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(587, 379);
            panel2.TabIndex = 1;
            // 
            // listviewBill
            // 
            listviewBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listviewBill.GridLines = true;
            listviewBill.Location = new Point(3, 3);
            listviewBill.Name = "listviewBill";
            listviewBill.Size = new Size(581, 373);
            listviewBill.TabIndex = 0;
            listviewBill.UseCompatibleStateImageBehavior = false;
            listviewBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name Food";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Count ";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price Of Food";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total Of Price";
            // 
            // panel3
            // 
            panel3.Controls.Add(txttotalprice);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(cmbMoveTable);
            panel3.Controls.Add(nUdDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnMoveTable);
            panel3.Location = new Point(700, 521);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 86);
            panel3.TabIndex = 2;
            // 
            // txttotalprice
            // 
            txttotalprice.Location = new Point(361, 50);
            txttotalprice.Name = "txttotalprice";
            txttotalprice.ReadOnly = true;
            txttotalprice.Size = new Size(137, 27);
            txttotalprice.TabIndex = 12;
            txttotalprice.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(359, 3);
            button1.Name = "button1";
            button1.Size = new Size(139, 40);
            button1.TabIndex = 11;
            button1.Text = "Total Price";
            button1.UseVisualStyleBackColor = false;
            // 
            // cmbMoveTable
            // 
            cmbMoveTable.FormattingEnabled = true;
            cmbMoveTable.Location = new Point(5, 55);
            cmbMoveTable.Name = "cmbMoveTable";
            cmbMoveTable.Size = new Size(182, 28);
            cmbMoveTable.TabIndex = 10;
            // 
            // nUdDiscount
            // 
            nUdDiscount.Location = new Point(208, 55);
            nUdDiscount.Name = "nUdDiscount";
            nUdDiscount.Size = new Size(122, 27);
            nUdDiscount.TabIndex = 9;
            nUdDiscount.TextAlign = HorizontalAlignment.Center;
            nUdDiscount.ValueChanged += caculPriceWithDiscount;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ActiveCaption;
            btnCheckOut.Location = new Point(504, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(71, 80);
            btnCheckOut.TabIndex = 8;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(208, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(122, 40);
            btnDiscount.TabIndex = 7;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnMoveTable
            // 
            btnMoveTable.Location = new Point(5, 3);
            btnMoveTable.Name = "btnMoveTable";
            btnMoveTable.Size = new Size(182, 40);
            btnMoveTable.TabIndex = 6;
            btnMoveTable.Text = "Merge Bill  Table";
            btnMoveTable.UseVisualStyleBackColor = true;
            btnMoveTable.Click += btnMoveTable_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nbudQuantity);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmbFood);
            panel4.Controls.Add(cmbCategory);
            panel4.Location = new Point(700, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(587, 82);
            panel4.TabIndex = 3;
            // 
            // nbudQuantity
            // 
            nbudQuantity.Location = new Point(453, 52);
            nbudQuantity.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nbudQuantity.Name = "nbudQuantity";
            nbudQuantity.Size = new Size(122, 27);
            nbudQuantity.TabIndex = 5;
            nbudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(453, 6);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(122, 40);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Food";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // cmbFood
            // 
            cmbFood.FormattingEnabled = true;
            cmbFood.Location = new Point(78, 49);
            cmbFood.Name = "cmbFood";
            cmbFood.Size = new Size(269, 28);
            cmbFood.TabIndex = 1;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(78, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(269, 28);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(15, 50);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(682, 548);
            flpTable.TabIndex = 4;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 619);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormManageTable";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUdDiscount).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem inforaccountname;
        private ToolStripMenuItem menuprofile;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView listviewBill;
        private Panel panel4;
        private ComboBox cmbFood;
        private ComboBox cmbCategory;
        private Button btnAddFood;
        private Label label2;
        private Label label1;
        private Button btnCheckOut;
        private Button btnDiscount;
        private Button btnMoveTable;
        private NumericUpDown nbudQuantity;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nUdDiscount;
        private ComboBox cmbMoveTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txttotalprice;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}