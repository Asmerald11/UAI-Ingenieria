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
    public partial class Barra_de_Progreso : Form
    {
        public Barra_de_Progreso()
        {
            InitializeComponent();
        }

        private void Comenzar_Click(object sender, EventArgs e)
        {
            long contador;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            while ((progressBar1.Value < progressBar1.Maximum))
            {
                progressBar1.Value++;
                for (contador = 1; contador < 100000000; contador++)
                { }
                ;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
