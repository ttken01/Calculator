using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoa.Text);
            double b = double.Parse(txtSob.Text);
            txtKetQua.Text = (a - b).ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoa.Text);
            double b = double.Parse(txtSob.Text);
            txtKetQua.Text = (a + b).ToString();
        }
    }
}
