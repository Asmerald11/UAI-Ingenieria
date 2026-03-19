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
    public partial class Jardin : Form
    {
        public Jardin()
        {
            InitializeComponent();
        }
        Participantes Inicial = null;
        private void Recorrer(ListBox listBox1, Participantes actual)
        {
            if (actual != null)
            {
                if (actual.siguiente != Inicial)
                {
                    Recorrer(listBox1, actual.siguiente);
                }
            }
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();
            if (Inicial == null) {
                return;
            }
            Participantes actual = Inicial;
            do
            {
                listBox1.Items.Add(actual);
                actual = actual.siguiente;
            } while (actual != Inicial);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Participantes jugador = new Participantes();

            jugador.nombre = textBox1.Text;
            jugador.apellido = textBox2.Text;
            jugador.edad = int.Parse(textBox3.Text);
            jugador.DNI = textBox4.Text;

            if (Inicial == null) {
                Inicial = jugador;
                Inicial.siguiente = Inicial;
            } else
            {
                Participantes ultimo = Inicial;
                while (ultimo.siguiente != Inicial)
                {
                    ultimo = ultimo.siguiente;
                }

                jugador.siguiente = Inicial;
                Inicial = jugador;
                ultimo.siguiente = Inicial;
            }
            MostrarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento");
            }
            else
            {
                Participantes seleccionado = (Participantes)listBox1.SelectedItem;
                Participantes actual = Inicial;
                if (seleccionado == Inicial)
                {
                    Inicial = null;
                }
                while (actual.siguiente != seleccionado)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = seleccionado.siguiente;
            }
            MostrarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento");
            }
            else
            {
                Participantes modificado = (Participantes)listBox1.SelectedItem;
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    modificado.nombre = textBox1.Text;
                }
                if (!string.IsNullOrEmpty(textBox2.Text)) 
                {
                    modificado.apellido = textBox2.Text;
                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    modificado.edad = int.Parse(textBox3.Text);
                }
                if  (!string.IsNullOrEmpty(textBox4.Text))
                {
                    modificado.DNI = textBox4.Text;
                }
            }
            MostrarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento");
            }
            else
            {
                Participantes seleccionado = (Participantes)listBox1.SelectedItem;
                Participantes despues = new Participantes();
                Participantes aux = null;
                despues.nombre = textBox1.Text;
                despues.apellido = textBox2.Text;
                despues.edad = int.Parse(textBox3.Text);
                despues.DNI = textBox4.Text;

                if (seleccionado.siguiente == Inicial)
                {
                    seleccionado.siguiente = despues;
                    despues.siguiente = Inicial;
                }
                else
                {
                    aux = seleccionado.siguiente;
                    seleccionado.siguiente = despues;
                    despues.siguiente = aux;
                }
            }
            MostrarLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }
    }
}
