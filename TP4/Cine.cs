using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        Cineasta Inicial = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Cineasta asistente = new Cineasta();
            Cineasta aux = null;
            Random rng = new Random();
            int edad = rng.Next(5, 61);
            asistente.nombre = textBox1.Text;
            asistente.apellido = textBox2.Text;
            asistente.edad = edad;

            if (Inicial == null)
            {
                Inicial = asistente;
            } else
            {
                aux = Inicial;
                Inicial = asistente;
                Inicial.siguiente = aux;
            }
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void Recorrer(ListBox listBox1, Cineasta Inicial)
        {
            if (Inicial != null)
            {
                listBox1.Items.Add(Inicial);
                Recorrer(listBox1, Inicial.siguiente);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento a operar");
            }
            else 
            {
                Cineasta Borrar = (Cineasta)listBox1.SelectedItem;
                Cineasta actual = Inicial;
                if (Borrar == Inicial)
                {
                    Inicial = Inicial.siguiente;
                }
                else
                {
                    while (Borrar != null && actual.siguiente != Borrar)
                    {
                        actual = Inicial.siguiente;
                    }
                    actual.siguiente = Borrar.siguiente;
                }
            }
            MostrarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cineasta Modificar = (Cineasta)listBox1.SelectedItem;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento");
            }
            else 
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    Modificar.nombre = textBox1.Text;
                }
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    Modificar.apellido = textBox2.Text;
                }
            }
            MostrarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cineasta seleccionado = (Cineasta)listBox1.SelectedItem;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento");
            } 
            Cineasta Nuevo = new Cineasta();
            Random rng = new Random();
            int edad = rng.Next(5, 61);
            Cineasta aux = null;
            Nuevo.nombre = textBox1.Text;
            Nuevo.apellido = textBox2.Text;
            Nuevo.edad = edad;
            if (seleccionado.siguiente == null)
            {
                seleccionado.siguiente = Nuevo;
            } else
            {
                aux = seleccionado.siguiente;
                seleccionado.siguiente = Nuevo;
                Nuevo.siguiente = aux;
            }
            MostrarLista();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double precio, total;
            Random personas = new Random();
            int clientes = personas.Next(-1, 51);
            precio = int.Parse(textBox4.Text);
            total = precio * clientes;
            label5.Text = total.ToString();
        }
    }
}
