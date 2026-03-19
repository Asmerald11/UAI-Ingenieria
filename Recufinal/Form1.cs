using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recufinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Producto> lista = new List<Producto>();
        Producto Inicial = null;

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.codigo = textBox1.Text;
            producto.nombre = textBox2.Text;
            producto.precio = decimal.Parse(textBox3.Text);
            if (lista.Count == 0)
            {
                lista.Add(producto);
            }
            else
            {
                foreach(Producto item in lista)
                {
                    if (item.codigo == textBox1.Text)
                    {
                        MessageBox.Show("El codigo ya existe");
                        return;
                    }
                }
                lista.Insert(0, producto);
            }
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
            label4.Text = "Cantidad en inventario: " + lista.Count;
            if(lista.Count >= 10)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto();
            producto.codigo = textBox1.Text;
            producto.nombre = textBox2.Text;
            producto.precio = decimal.Parse(textBox3.Text);
            if (Inicial == null)
            {
                Inicial = producto;
            } else
            {
                Producto actual = Inicial;
                while(actual != null)
                {
                    if(actual.codigo == textBox1.Text)
                    {
                        MessageBox.Show("El codigo ya existe");
                        return;
                    }
                    actual = actual.siguiente;
                }
                {
                    Producto aux = null;
                    aux = Inicial;
                    Inicial = producto;
                    Inicial.siguiente = aux;
                }
            }
            MostrarEnlazada();
        }

        private void MostrarEnlazada()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, Inicial);
            label4.Text = "Cantidad en inventario: " + listBox1.Items.Count.ToString();
            if (listBox1.Items.Count >= 10) {
                this.BackColor = Color.Red;
            } else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void Recorrer(ListBox listBox1, Producto nodo)
        {
            if (nodo != null)
            {
                    listBox1.Items.Add(nodo);
                    Recorrer(listBox1, nodo.siguiente);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.codigo = textBox1.Text;
            producto.nombre = textBox2.Text;
            producto.precio = decimal.Parse(textBox3.Text);
            if (lista.Count == 0)
            {
                lista.Add(producto);
            } else
            {
                foreach (Producto item in lista)
                {
                    if (item.codigo == textBox1.Text)
                    {
                        MessageBox.Show("El codigo ya existe");
                        return;
                    }
                }
                lista.Add(producto);
            }
            MostrarLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.codigo = textBox1.Text;
            producto.nombre = textBox2.Text;
            producto.precio = decimal.Parse(textBox3.Text);
            Producto actual = Inicial;
            if (listBox1.Items.Count == 0) {
                Inicial = producto;
            } else
            {
                while (actual != null)
                {
                    if (actual.codigo == textBox1.Text)
                    {
                        MessageBox.Show("El codigo ya existe");
                        return;
                    }
                    actual = actual.siguiente;
                }
                actual = Inicial;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = producto;
            }
            MostrarEnlazada();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                lista.RemoveAt(listBox1.SelectedIndex);
            } else
            {
                MessageBox.Show("Seleccione algo a eliminar");
            }
                MostrarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Producto selec = (Producto)listBox1.SelectedItem;
            Producto actual = Inicial;
            if (selec != null)
            {
                while(actual.siguiente != selec)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = selec.siguiente;
            }
            else
            {
                MessageBox.Show("Seleccione algo a eliminar");
            }
            MostrarEnlazada();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("ingrese datos a operar");
            }
            else
            {
                double resultado = PotenciaRecursiva(double.Parse(textBox4.Text), int.Parse(textBox5.Text));
                label7.Text = "Resultado: " + resultado.ToString();
            }
        }

        private double PotenciaRecursiva(double v1, int v2)
        {
            double resultado = 1;
            int i = 0;
            if (v2 == 0)
            {
                resultado = 1;
                return resultado;
            }
            else if (v1 == 0 && v2 < 0)
            {
                MessageBox.Show("Error, ingrese datos validos");
                return resultado = 0;
            }
            else
            {
                for (i = 0; i<v2 ;i++)
                {
                    resultado = resultado * v1;
                }
            }
            return resultado;
        }
    }
}
