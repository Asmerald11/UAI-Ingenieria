using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            Resu.Text = (Int32.Parse(Op1.Text) + Int32.Parse(Op2.Text)).ToString();
        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            Resu.Text = (Int32.Parse(Op1.Text) - Int32.Parse(Op2.Text)).ToString();
        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(Op1.Text);
            int den = Int32.Parse(Op2.Text);
            if (den != 0)
            {
                Resu.Text = (Int32.Parse(Op1.Text) / Int32.Parse(Op2.Text)).ToString();
            }
        }

        private void Btnmult_Click(object sender, EventArgs e)
        {
            Resu.Text = (Int32.Parse(Op1.Text) * Int32.Parse(Op2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Op1.Text = "";
            Op2.Text = "";
            Resu.Text = "";
            this.Op1.Focus();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
