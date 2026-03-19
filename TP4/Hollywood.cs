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
    public partial class Hollywood : Form
    {
        public Hollywood()
        {
            InitializeComponent();
        }
        Dwayne Inicial = null;
        private void button4_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void Recorrer(ListBox listBox1, Dwayne inicial)
        {
            if (inicial != null)
            {
                listBox1.Items.Add(inicial);
                Recorrer(listBox1, inicial.siguiente);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dwayne Johnson = new Dwayne();
            Random rng = new Random();
            Dwayne aux = null;
            int i = 0;
            int edad = rng.Next(5, 61);
            Johnson.nombre = textBox1.Text;
            Johnson.apellido = textBox2.Text;
            Johnson.edad = edad;
            if (Inicial == null)
                {
                    Inicial = Johnson;
                }
                else
                {
                    aux = Inicial;
                    Inicial = Johnson;
                    Johnson.siguiente = aux;
                    aux.anterior = Johnson;
                }
                MostrarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dwayne Fuera = (Dwayne)listBox1.SelectedItem;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione a un cliente");
            }
            else
            {
                if (Fuera == Inicial)
                {
                    Inicial = Inicial.siguiente;
                }
                else if (Fuera.siguiente == null)
                {
                    Fuera.anterior.siguiente = Fuera.siguiente;
                }
                else 
                {
                    Fuera.anterior.siguiente = Fuera.siguiente;
                    Fuera.siguiente.anterior = Fuera.anterior;
                }
            }
            MostrarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dwayne Modificado = (Dwayne)listBox1.SelectedItem;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Modificado.nombre = textBox1.Text;
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                Modificado.apellido = textBox2.Text;
            }
            MostrarLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random asistentes = new Random();
            int presentes = asistentes.Next(0, 51);
            int precio = int.Parse(textBox3.Text);
            int recaudacion = presentes * precio;
            label7.Text = presentes.ToString();
            label6.Text = recaudacion.ToString();
        }
    }
}
