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
    public partial class Mas_operaciones_con_fechas : Form
    {
        public Mas_operaciones_con_fechas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            txtresultado.Text = (fecha1.AddDays(Convert.ToInt32(txtdias.Text)).ToString("dd/MM/yyyy")).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            txtresultado.Text = (fecha1.AddDays(-1*Convert.ToInt32(txtdias.Text)).ToString("dd/MM/yyyy")).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
