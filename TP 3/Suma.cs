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
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, suma = 0;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            suma = a + b;
            MessageBox.Show("El resultado es " + suma);
        }
    }
}
