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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void barraDeProgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barra_de_Progreso frm = new Barra_de_Progreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barrasDeDesplazamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barras_de_Desplazamiento frm = new Barras_de_Desplazamiento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cargaDeMatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carga_de_Matrices frm = new Carga_de_Matrices();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cargaDeVectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formatoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formato_de_fechas frm = new Formato_de_fechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formatoDeNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formato_de_Numeros frm = new Formato_de_Numeros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void manejoDeStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manejo_de_Strings frm = new Manejo_de_Strings();
            frm.MdiParent = this;
            frm.Show();
        }

        private void masFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mas_fechas frm = new Mas_fechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void masOperacionesConFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mas_operaciones_con_fechas frm = new Mas_operaciones_con_fechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mensajesDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEnsajes_de_texto frm = new MEnsajes_de_texto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void operacionesConVectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones_con_Vectores frm = new Operaciones_con_Vectores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void operacionesFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones_Fecha frm = new Operaciones_Fecha();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer frm = new Timer();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
