﻿using System;
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
    public partial class faddfoodcategory : Form
    {
        public faddfoodcategory()
        {
            InitializeComponent();
        }
        public TextBox faddnameCate => textBox1;
        public Button faddbutton => button1;
    }
}
