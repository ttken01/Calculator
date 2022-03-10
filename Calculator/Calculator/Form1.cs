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


        static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
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
            Button button = (Button)sender;
            double a = double.Parse(txtSoa.Text);
            double b =  double.Parse(txtSob.Text);
            Calculation d = new Calculation(a, b);
            double result = 0;
            switch (button.Text) { 
                case "Cong":
                    result = d.Execute("+");
                    break;
                case "Tru":
                    result = d.Execute("-");
                    break;
                case "Nhan":
                    result = d.Execute("*");
                    break;
                case "Chia":
                    result = d.Execute("/");
                    break;
            }
            txtKetQua.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path.Text = Calculation.getPath;
        }
    }
}
