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
    public partial class Barras_de_Desplazamiento : Form
    {
        public Barras_de_Desplazamiento()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.label1.Text = hScrollBar1.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.label2.Text = vScrollBar1.Value.ToString();
        }
    }
}
