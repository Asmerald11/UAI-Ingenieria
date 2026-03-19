using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Hospital : Form
    {
       

        public Hospital()
        {
            InitializeComponent();
        }

        public HospitalPaciente Inicial = null;

        private void button1_Click(object sender, EventArgs e)
        {
            HospitalPaciente Paciente = new HospitalPaciente();
            Paciente.codigo = int.Parse(textBox1.Text);
            Paciente.nombre = textBox2.Text;
            Paciente.apellido = textBox3.Text;
            Paciente.direccion = textBox4.Text;
            Paciente.telefono = textBox5.Text;
            if (Inicial != null)
            {
                HospitalPaciente aux = new HospitalPaciente();
                aux = Inicial;
                Inicial = Paciente;
                Paciente.siguiente = aux;
            }
            else
            {
                Inicial = Paciente;
            }
            MostrarLista();
        }
        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void Recorrer(ListBox listBox1, HospitalPaciente Nodo)
        {
            if (Nodo != null)
            {
                listBox1.Items.Add(Nodo);
                Recorrer(listBox1, Nodo.siguiente);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un elemento a operar");
            }
            HospitalPaciente aBorrar = (HospitalPaciente)listBox1.SelectedItem;
            if (aBorrar == Inicial)
            {
                Inicial = Inicial.siguiente;
            }
            else
            {
                HospitalPaciente actual = Inicial;
                while (actual != null && actual.siguiente != aBorrar)
                {
                    actual = actual.siguiente;
                }
                if (actual != null) { 
                    actual.siguiente = aBorrar.siguiente;
                }
            }
                MostrarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un elemento a operar");
            }
            HospitalPaciente Paciente = new HospitalPaciente();
            Paciente.codigo = int.Parse(textBox1.Text);
            Paciente.nombre = textBox2.Text;
            Paciente.apellido = textBox3.Text;
            Paciente.direccion = textBox4.Text;
            Paciente.telefono = textBox5.Text;

            HospitalPaciente Ingreso = (HospitalPaciente) listBox1.SelectedItem;

            HospitalPaciente aux = new HospitalPaciente();

            aux = Ingreso.siguiente;
            Ingreso.siguiente = Paciente;
            Paciente.siguiente = aux;

            MostrarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) {
                MessageBox.Show("Seleccione un elemento a modificar");
            }

            HospitalPaciente Modificar = (HospitalPaciente)listBox1.SelectedItem;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Modificar.codigo = int.Parse(textBox1.Text);
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                Modificar.nombre = textBox2.Text;
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                Modificar.apellido = textBox3.Text;
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                Modificar.direccion = textBox4.Text;
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                Modificar.telefono = textBox5.Text;
            }
            MostrarLista();
        }
    }
}
