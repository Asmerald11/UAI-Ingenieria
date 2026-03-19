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
    public partial class Operaciones_Fecha : Form
    {
        public Operaciones_Fecha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Fecha = this.dateTimePicker1.Value;
            DateTime Fecha2 = this.dateTimePicker2.Value;
            textBox1.Text = Fecha.Subtract(Fecha2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
