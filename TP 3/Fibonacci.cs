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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Binet = (1 + Math.Sqrt(5)) / 2;
            double n = int.Parse(textBox1.Text);
            double part1 = 1;
            double part2 = 1;
            for (int i = 0; i < n; i++)
            {
                part1 = Binet * part1;
            }
            for (int i = 0; i < n; i++)
            {
                part2 = (1 - Binet) * part2;
            }
            double res = (part1 - part2)/Math.Sqrt(5);
            label2.Text = res.ToString();
        }
    }
}
