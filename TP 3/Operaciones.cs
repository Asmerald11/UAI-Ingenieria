using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, res = 0;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            res = a + b;
            Resu.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, res = 0;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            res = a - b;
            Resu.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, res = 0;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            res = a * b;
            Resu.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, res = 0;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            res = a / b;
            Resu.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, i=0, res = 1;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            for (i = 0; i < b; i++)
            {
                res = a * res;
            }
            Resu.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, res = 0;
            a = Double.Parse(textBox1.Text);
            res = Math.Sqrt(a);
            Resu.Text = res.ToString();
        }
    }
}
