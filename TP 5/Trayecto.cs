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
    public partial class Trayecto : Form
    {
        public Trayecto()
        {
            InitializeComponent();
        }
        Cities tope = null;
        Cities inicio = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Cities ciudad = new Cities();
            Cities city = new Cities();
            Cities aux = null;
            Cities auxiliar = null;
            ciudad.nombre = textBox1.Text;
            city.nombre = textBox1.Text;
            if (tope == null)
            {
                tope = ciudad;
            }
            else 
            {
                aux = tope;
                tope = ciudad;
                ciudad.siguiente = aux;
            }
            if (inicio == null)
            {
                inicio = city;
            }
            else
            {
                auxiliar = inicio;
                while (auxiliar.siguiente != null)
                {
                    auxiliar = auxiliar.siguiente;
                }
                auxiliar.siguiente = city;
            }
            Mostrarlista1();
            MostrarLista2();
        }

        private void MostrarLista2()
        {
            listBox2.Items.Clear();
            Recorrer2(listBox2, inicio);
        }

        private void Recorrer2(ListBox listBox2, Cities nodo)
        {
            if (nodo != null)
            {
                listBox2.Items.Add(nodo);
                Recorrer2(listBox2, nodo.siguiente);
            }
        }

        private void Mostrarlista1()
        {
            listBox1.Items.Clear();
            Recorrer1(listBox1, tope);
        }

        private void Recorrer1(ListBox listBox1, Cities nodo)
        {
            if (nodo != null)
            {
                listBox1.Items.Add(nodo);
                Recorrer1(listBox1, nodo.siguiente);
            }
        }
    }
}
