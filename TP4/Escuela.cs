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
    public partial class Escuela : Form
    {
        public Escuela()
        {
            InitializeComponent();
        }
        Estudiante Inicial = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante aux = null;
            Estudiante ingreso = new Estudiante();
            ingreso.nombre = textBox1.Text;
            ingreso.apellido = textBox2.Text;
            ingreso.DNI = textBox3.Text;
            ingreso.nacimiento = textBox4.Text;
            ingreso.direccion = textBox5.Text;
            ingreso.telefono = textBox6.Text;

            if (Inicial == null)
            {
                Inicial = ingreso;
            }
            else {
                aux = Inicial;
                Inicial = ingreso;
                ingreso.siguiente = aux;
                ingreso.siguiente.anterior = Inicial;
            }
            MostrarLista();
        }

        public void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
        }

        private void Recorrer(ListBox listBox1, Estudiante Inicial)
        {
            if (Inicial != null)
            {
                listBox1.Items.Add(Inicial);
                Recorrer(listBox1, Inicial.siguiente);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento");
            }
            else {
                Estudiante aBorrar = (Estudiante)listBox1.SelectedItem;
                if (listBox1.SelectedItem == Inicial)
                {
                    Inicial = Inicial.siguiente;
                    if (Inicial != null)
                    {
                        Inicial.anterior = null;
                    }
                }
                else
                {
                    if (aBorrar.anterior != null)
                    {
                        aBorrar.anterior.siguiente = aBorrar.siguiente;
                    }
                    if (aBorrar.siguiente != null)
                    {
                        aBorrar.siguiente.anterior = aBorrar.anterior;
                    }
                }
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
                Estudiante modificar = (Estudiante)listBox1.SelectedItem;
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    modificar.nombre = textBox1.Text;
                }
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    modificar.apellido = textBox2.Text;
                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    modificar.DNI = textBox3.Text;
                }
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    modificar.nacimiento = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    modificar.direccion = textBox5.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    modificar.telefono = textBox6.Text;
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
            else {
                Estudiante aux = null;
                Estudiante ingreso = new Estudiante();
                Estudiante seleccion = (Estudiante)listBox1.SelectedItem;
                ingreso.nombre = textBox1.Text;
                ingreso.apellido = textBox2.Text;
                ingreso.DNI = textBox3.Text;
                ingreso.nacimiento = textBox4.Text;
                ingreso.direccion = textBox5.Text;
                ingreso.telefono = textBox6.Text;

                if (seleccion.siguiente == null)
                {
                    ingreso.siguiente = null;
                    ingreso.anterior = seleccion;
                    seleccion.siguiente = ingreso;
                }
                else 
                {
                    aux = seleccion.siguiente;
                    ingreso.anterior = seleccion;
                    ingreso.siguiente = aux;
                    seleccion.siguiente = ingreso;
                    aux.anterior = ingreso;
                }

            }
            MostrarLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento");
            }
            else
            {
                Estudiante aux = null;
                Estudiante ingreso = new Estudiante();
                Estudiante seleccion = (Estudiante)listBox1.SelectedItem;
                ingreso.nombre = textBox1.Text;
                ingreso.apellido = textBox2.Text;
                ingreso.DNI = textBox3.Text;
                ingreso.direccion = textBox5.Text;
                ingreso.nacimiento = textBox4.Text;
                ingreso.telefono = textBox6.Text;

                if (seleccion.anterior == null)
                {
                    ingreso.siguiente = seleccion;
                    ingreso.anterior = null;
                    seleccion.anterior = ingreso;
                }
                else 
                {
                    aux = seleccion.anterior;
                    seleccion.anterior = ingreso;
                    ingreso.anterior = aux;
                    ingreso.siguiente = seleccion;
                    aux.siguiente = ingreso;
                }
            }
            MostrarLista();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }
    }
}
