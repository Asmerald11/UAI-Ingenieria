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
    public partial class PlazoFijo : Form
    {
        public PlazoFijo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Mon, Dia, Tasa, Plazo;
            Mon = Convert.ToDouble(textBox1.Text);
            Dia = Convert.ToDouble(textBox3.Text);
            Tasa = Convert.ToDouble(textBox2.Text);
            Plazo = (Mon * Dia * Tasa)/36500;
            dataGridView1.Rows.Add(Mon, Tasa, Dia, Plazo);
        }
    }
}
