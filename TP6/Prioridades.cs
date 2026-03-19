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
    public partial class Prioridades : Form
    {
        public Prioridades()
        {
            InitializeComponent();
        }
        VIP inicial = null;
        private void button1_Click(object sender, EventArgs e)
        {
            VIP persona = new VIP();
            persona.nombre = textBox1.Text;
            persona.prioridades = int.Parse(textBox2.Text);
            if (persona.prioridades > 3)
            {
                MessageBox.Show("Prioridad invalida");
                return;
            } else if (persona.prioridades < 0)
            {
                MessageBox.Show("Prioridad invalida");
                return;
            }
            if (inicial == null)
            {
                inicial = persona;
            }
            else
            {
                if (inicial.siguiente == null)
                {
                    VIP actual = inicial;
                    if (persona.prioridades == 1 && inicial.prioridades == 1)
                    {
                        VIP auxilio = inicial.siguiente;
                        inicial.siguiente = persona;
                        persona.siguiente = auxilio;
                    }
                    else
                    if (persona.prioridades == 1 && inicial.prioridades == 2 || inicial.prioridades == 3)
                    {
                        VIP auxilio = inicial;
                        inicial = persona;
                        inicial.siguiente = auxilio;
                    }
                    else if (persona.prioridades == 2 && inicial.prioridades == 1 || inicial.prioridades == 2)
                    {
                        inicial.siguiente = persona;
                    }
                    else if (persona.prioridades == 2 && inicial.prioridades == 3)
                    {
                        VIP auxilio = inicial;
                        inicial = persona;
                        inicial.siguiente = auxilio;
                    }
                }
                else
                {
                    if (persona.prioridades == 1 && inicial.prioridades == 1)
                    {
                        VIP auxilio = inicial.siguiente;
                        inicial.siguiente = persona;
                        persona.siguiente = auxilio;
                    }
                    else if (persona.prioridades == 1 && inicial.prioridades != 1)
                    {
                        VIP auxilio = inicial;
                        inicial = persona;
                        inicial.siguiente = auxilio;
                    }
                    else if (persona.prioridades == 2 && inicial.prioridades != 3)
                    {
                        VIP move = inicial;
                        while (move.siguiente != null && move.siguiente.prioridades != 3)
                        {
                            move = move.siguiente;
                        }
                        VIP guarda = move.siguiente;
                        move.siguiente = persona;
                        persona.siguiente = guarda;
                    }
                    else if (persona.prioridades == 3)
                    {
                        VIP move = inicial;
                        while (move.siguiente != null)
                        {
                            move = move.siguiente;
                        }
                        move.siguiente = persona;
                    }
                }
            }
            MostrarLista();
        }

        private void MostrarLista()
        {
            listBox1.Items.Clear();
            Recorrer(listBox1, inicial);
        }

        private void Recorrer(ListBox listBox1, VIP nodo)
        {
            if (nodo != null)
            {
                listBox1.Items.Add(nodo);
                Recorrer(listBox1, nodo.siguiente);
            }
        }
    }
}
