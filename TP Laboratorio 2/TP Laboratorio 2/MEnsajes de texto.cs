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
    public partial class MEnsajes_de_texto : Form
    {
        public MEnsajes_de_texto()
        {
            InitializeComponent();
        }

        private void Mensaje1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay que revisar el VAR", "Penal para Di Maria");
        }

        private void Mensaje2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted creo que era penal o no?", "Robo Rosalo Ypenal?", MessageBoxButtons.YesNo);
        }

        private void Mensaje3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rosario Central", "Titulo inventado", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }
    }
}
