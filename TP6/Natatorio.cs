using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6
{
    public partial class Natatorio : Form
    {
        public Natatorio()
        {
            InitializeComponent();
        }
        Nado Inicial = null;
        Nado tope = null;
        Nado frente = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Nado agua = new Nado();
            Nado actual = null;
            agua.nombre = textBox1.Text;
            agua.genero = textBox2.Text;

            if (Inicial == null)
            {
                Inicial = agua;
            } else
            {
                actual = Inicial;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = agua;
            }
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void Recorrer(ListBox listBox1, Nado nodo)
        {
            if (nodo != null)
            {
                listBox1.Items.Add(nodo);
                Recorrer(listBox1, nodo.siguiente);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Inicial == null)
            {
                MessageBox.Show("La lista esta vacia");
                return;
            }

            tope = null;
            frente = null;

            Nado actual = Inicial;
            Nado anterior = null;

            while (actual != null)
            {
                Nado siguienteNodo = actual.siguiente;

                if (actual.genero == "M")
                {
                    Nado copia = new Nado();
                    copia.genero = actual.genero;
                    copia.nombre = actual.nombre;
                    copia.siguiente = null;

                    if (tope == null)
                    {
                        tope = copia;
                    }
                    else
                    {
                        Nado auxTope = tope;
                        while (auxTope.siguiente != null)
                        {
                            auxTope = auxTope.siguiente;
                        }
                        auxTope.siguiente = copia;
                    }

                    if (anterior == null)
                    {
                        Inicial = siguienteNodo;
                    }
                    else
                    {
                        anterior.siguiente = siguienteNodo;
                    }
                }
                else if (actual.genero == "F")
                {
                    Nado copia = new Nado();
                    copia.genero = actual.genero;
                    copia.nombre = actual.nombre;
                    copia.siguiente = null;

                    if (frente == null)
                    {
                        frente = copia;
                    }
                    else
                    {
                        Nado auxFrente = frente;
                        while (auxFrente.siguiente != null)
                        {
                            auxFrente = auxFrente.siguiente;
                        }
                        auxFrente.siguiente = copia;
                    }

                    anterior = actual;
                }
                else
                {
                    MessageBox.Show("Error genero invalido");
                    anterior = actual;
                }

                actual = siguienteNodo;
            }

            MostrarLista2();
            MostrarLista3();
        }

        private void MostrarLista3()
        {
            listBox3.Items.Clear();
            Recorrer3(listBox3, frente);
        }

        private void Recorrer3(ListBox listBox3, Nado nodo)
        {
            if (nodo != null)
            {
                listBox3.Items.Add(nodo);
                Recorrer3(listBox3, nodo.siguiente);
            }
        }

        private void MostrarLista2()
        {
            listBox2.Items.Clear();
            Recorrer2(listBox2, tope);
        }

        private void Recorrer2(ListBox listBox2, Nado nodo)
        {
            if (nodo != null)
            {
                listBox2.Items.Add(nodo);
                Recorrer2(listBox2, nodo.siguiente);
            }
        }
    }
}
