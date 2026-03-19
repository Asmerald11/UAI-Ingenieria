using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Laboratorio_2
{
    public partial class Operaciones_con_Vectores : Form
    {
        string dato;
        int[] vector1;
        int i;
        public Operaciones_con_Vectores()
        {
            InitializeComponent();
        }

        private void Operaciones_con_Vectores_Load(object sender, EventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            vector1 = new int[10];
            for (i = 1; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                dato = Console.ReadLine();
                vector1[i] = Int32.Parse(dato);
            }
            Console.WriteLine("Los datos del vector fueron impresos.");
            for (i = 1; i < 10; i++)
            {
                listBox1.Items.Add("En la posicion: " + 1 + "el valor es: " + vector1[i]);
            }
        }

        private void Ordenar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(vector1);
            for (i = 1; i < 10; i++)
            {
                listBox1.Items.Add("El valor es: " + vector1[i] + "en la posicion: " + i);
            }
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            int[] vectorDestino = new int[20];
            Array.Copy(vector1, 0, vectorDestino, 0, 10);
            for (i = 1; i < 10; i++)
            {
                listBox1.Items.Add("El valor es: " + vectorDestino[i] + "en la posicion: " + i);
            }
        }

        private void BusqBinaria_Click(object sender, EventArgs e)
        {
            int posicion;
            posicion = Array.BinarySearch(vector1, 9);
            listBox1.Items.Clear();
            listBox1.Items.Add("En la posicion: " + posicion + " se encuentra el numero 9");
        }

        private void Limites_Click(object sender, EventArgs e)
        {
            int superior, inferior;
            listBox1.Items.Clear();
            superior = vector1.GetUpperBound(0);
            inferior = vector1.GetLowerBound(0);
            listBox1.Items.Add("El limite superior del vector es: " + superior + "y el inferior es " + inferior);
        }
    }
}
