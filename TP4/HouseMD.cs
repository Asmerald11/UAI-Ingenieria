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
    public partial class HouseMD : Form
    {
        Foreman Inicial = null;
        public HouseMD()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void Recorrer(ListBox listBox1, Foreman Inicial)
        {
            if (Inicial != null)
            {
                listBox1.Items.Add(Inicial);
                Recorrer(listBox1, Inicial.siguiente);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foreman admit = new Foreman();
            Foreman actual = Inicial;
            Foreman aux = null;
            admit.codigo = textBox1.Text;
            admit.nombre = textBox2.Text;
            admit.apellido = textBox3.Text;
            admit.direccion = textBox4.Text;
            admit.telefono = textBox5.Text;

            if (Inicial == null)
            {
                Inicial = admit;
            }
            else
            {
                aux = Inicial;
                Inicial = admit;
                Inicial.siguiente = aux;
                aux.anterior = Inicial;
            }
            MostrarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Foreman Alta = (Foreman)listBox1.SelectedItem;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente");
            }
            else if (Alta == Inicial)
            {
                Inicial = Inicial.siguiente;
            }
            else if (Alta.siguiente == null)
            {
                Alta.anterior.siguiente = Alta.siguiente;
            }
            else
            {
                Alta.anterior.siguiente = Alta.siguiente;
                Alta.siguiente.anterior = Alta.anterior;
            }
            MostrarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Foreman modificado = (Foreman)listBox1.SelectedItem;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un paciente");
            }
            else
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    modificado.codigo = textBox1.Text;
                }
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    modificado.nombre = textBox2.Text;
                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    modificado.apellido = textBox3.Text;
                }
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    modificado.direccion = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    modificado.telefono = textBox5.Text;
                }
            }
            MostrarLista();
        }

    }   
}
