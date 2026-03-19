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
    public partial class Mas_fechas : Form
    {
        public Mas_fechas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Fecha = this.dateTimePicker1.Value;
            textBox1.Text = Convert.ToString(Fecha);
            textBox2.Text = string.Format("{0:d}", Fecha);
            textBox3.Text = string.Format("{0:D}", Fecha);
            textBox4.Text = string.Format("{0:f}", Fecha);
            textBox5.Text = string.Format("{0:g}", Fecha);
            textBox6.Text = string.Format("{0:G}", Fecha);
        }
    }
}
