using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Laboratorio_2
{
    public partial class Formato_de_Numeros : Form
    {
        public Formato_de_Numeros()
        {
            InitializeComponent();
        }

        private void Puntofijo_Click(object sender, EventArgs e)
        {

        }
        private void Ejecutar_Click(object sender, EventArgs e)
        {
            double auxiliar, auxiliar1, auxiliar2;
            auxiliar = double.Parse(textBox1.Text);
            textBox1.Text = string.Format("{0:c}", auxiliar);
            auxiliar1 = (auxiliar / 100);
            textBox2.Text = string.Format("{0:N}", auxiliar);
            textBox3.Text = string.Format("{0:N4}", auxiliar);
            textBox4.Text = string.Format("{0:D8}", Convert.ToInt32(auxiliar));
            textBox5.Text = string.Format("{0:f3}", auxiliar);
            textBox6.Text = string.Format("{0:E3}", auxiliar);
            textBox7.Text = string.Format("{0:p}", auxiliar);
            textBox8.Text = string.Format("el valor es {0:c}", auxiliar);
            auxiliar2 = (auxiliar + 10);
            textBox9.Text = string.Format("{0:c} {1:c}", auxiliar, auxiliar2);
        }
    }
}
