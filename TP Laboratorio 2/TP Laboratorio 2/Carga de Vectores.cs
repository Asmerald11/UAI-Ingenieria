using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TP_Laboratorio_2
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Form1()
        {
            AllocConsole();
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            string dato;
            int[] vector = new int[10];
            int i;
            for (i = 1; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                dato = Console.ReadLine();
                vector[i] = Int32.Parse(dato);
            }
            Console.WriteLine("Los datos del vector fueron impresos.");
            for (i = 1; i < 10; i++)
            {
                Listado.Items.Add("En la posicion: " + 1 + "el valor es: " + vector[i]);
            }
        }
    }
}
