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
    public partial class faddfood : Form
    {
        public faddfood()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(Application.StartupPath + "/Image/110441.jpg");

        }
        public TextBox nameFood => txtnamefood;
        public ComboBox categoryFood => cmbcategoryfood;
        public NumericUpDown priceFood => nbudpricefood;
        public Button addFood => btnaddfood;
    }
}
