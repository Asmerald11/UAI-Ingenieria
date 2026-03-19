using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_5
{
    public partial class Juzgado : Form
    {
        public Juzgado()
        {
            InitializeComponent();
        }
        Juicios Inicial = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Juicios culpable = new Juicios();
            culpable.fecha = textBox1.Text;
            culpable.expediente = textBox2.Text;
            culpable.caratula = textBox3.Text;

            if (Inicial == null)
            {
                Inicial = culpable;
            }
            else
            {
                DateTime fechaNuevo = DateTime.Parse(culpable.fecha);
                int expNuevo = int.Parse(culpable.expediente);

                DateTime fechaInicial = DateTime.Parse(Inicial.fecha);
                int expInicial = int.Parse(Inicial.expediente);

                if (fechaNuevo > fechaInicial || (fechaNuevo == fechaInicial && expNuevo >= expInicial))
                {
                    culpable.siguiente = Inicial;
                    Inicial = culpable;
                }
                else
                {
                    Juicios actual = Inicial;

                    while (actual.siguiente != null)
                    {
                        DateTime fechaSig = DateTime.Parse(actual.siguiente.fecha);
                        int expSig = int.Parse(actual.siguiente.expediente);

                        if (fechaNuevo > fechaSig || (fechaNuevo == fechaSig && expNuevo >= expSig))
                        {
                            break;
                        }
                        actual = actual.siguiente;
                    }

                    culpable.siguiente = actual.siguiente;
                    actual.siguiente = culpable;
                }
            }
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void Recorrer(ListBox listBox1, Juicios nodo)
        {
            if (nodo != null)
            {
                listBox1.Items.Add(nodo);
                Recorrer(listBox1, nodo.siguiente);
            }
        }
    }
}
