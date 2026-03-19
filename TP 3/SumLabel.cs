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
    public partial class SumLabel : Form
    {
        public SumLabel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, suma;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            suma = a + b;
            label2.Text = suma.ToString();
        }
    }
}
