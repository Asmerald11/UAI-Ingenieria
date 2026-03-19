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
    public partial class Contenedores : Form
    {
        public Contenedores()
        {
            InitializeComponent();
        }
        Containers tope = null;
        Containers arriba = null;

        private void MostrarPila1()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, tope);
        }
        private void MostrarPila2()
        {
            listBox2.Items.Clear();
            Recorrer2(listBox2, arriba);
        }
        private void Recorrer2(ListBox listBox2, Containers node)
        {
            if (node != null)
            {
                listBox2.Items.Add(node);
                if (node.siguiente != null)
                {
                    Recorrer2(listBox2, node.siguiente);
                }
            }
        }

        private void Recorrer(ListBox listBox1, Containers nodo)
        {
            if (nodo != null)
            {
                listBox1.Items.Add(nodo);
                if (nodo.siguiente != null)
                {
                    Recorrer(listBox1, nodo.siguiente);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Containers cajon = new Containers();
            Containers aux = null;
            cajon.nombre = textBox1.Text;

            if (tope == null)
            {
                tope = cajon;
            }
            else
            {
                aux = tope;
                tope = cajon;
                cajon.siguiente = aux;
            }

            MostrarPila1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tope != null)
            {
                Containers aMover = tope;
                tope = tope.siguiente;
                aMover.siguiente = null;
                if (arriba == null)
                {
                    arriba = aMover;
                }
                else
                {
                    Containers auxiliar = null;
                    auxiliar = arriba;
                    arriba = aMover;
                    aMover.siguiente = auxiliar;
                }
            }
            MostrarPila1();
            MostrarPila2();
        }
    }
}
