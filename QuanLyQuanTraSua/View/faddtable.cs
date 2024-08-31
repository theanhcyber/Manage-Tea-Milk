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
    public partial class faddtable : Form
    {
        public faddtable()
        {
            InitializeComponent();
            cmbstatutable.SelectedIndex = 0;
            loadanh();
        }
        private void loadanh()
        {
            pictureBox2.Image = new Bitmap(Application.StartupPath + "/Image/ban.png");
        }
        public TextBox nameTable => txtnametable;
        public ComboBox statutable => cmbstatutable;
        public NumericUpDown numbertable => nbudpeopletable;
        public Button btnaddtable1 => btnaddtable;
    }
}
