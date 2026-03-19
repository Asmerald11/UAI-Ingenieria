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
    public partial class Movistar_Arena : Form
    {
        public Movistar_Arena()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        Queue<Colado> cola = new Queue<Colado>();
        private void button1_Click(object sender, EventArgs e)
        {
            string[] nombres = { "Santiago", "Victor", "Camila", "Pablo", "Mariano", "Florencia", "Albano", "Malena", "Victoria", "Sofia", "Maria", "Paz", "Jose", "Guido", "Fernando" };
            int indice = rng.Next(nombres.Length);
            string seleccion = nombres[indice];
            int ticket = 0;
            if (rng.Next(1, 101) > 35) { 
                ticket = rng.Next(1, 50);
            }
            Colado gente = new Colado();
            gente.nombre = seleccion;
            gente.ticket = ticket;

            cola.Enqueue(gente);
            MostrarLista();
        }

        private void MostrarLista()
        {
            {
                listBox1.Items.Clear();
                foreach (Colado gente in cola)
                {
                    listBox1.Items.Add(gente);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Colado gente in listBox1.Items)
            {
                if (gente.ticket == 0)
                {
                    listBox2.Items.Add(gente);
                }
                else
                {
                    listBox3.Items.Add(gente);
                }
            }
            MostrarLista();
            MostrarLista2();
            MostrarLista3();
        }

        private void MostrarLista3()
        {
            listBox3.Items.Clear();
            foreach (Colado gente in listBox3.Items)
            {
                listBox3.Items.Add(gente);
            }
        }

        private void MostrarLista2()
        {
            listBox2.Items.Clear();
            foreach (Colado gente in listBox2.Items)
            {
                listBox2.Items.Add(gente);
            }
        }
    }
}
