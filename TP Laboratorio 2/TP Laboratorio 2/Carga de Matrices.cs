using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Laboratorio_2
{
    public partial class Carga_de_Matrices : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Carga_de_Matrices()
        {
            AllocConsole();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato;
            int[,] matriz = new int[3, 4];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese un valor: ");
                    dato = Console.ReadLine();
                    matriz[i, j] = Int32.Parse(dato);
                }
            }
            Console.WriteLine("Los datos de la matriz fueron impresos.");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Listado.Items.Add("En la fila: " + i + " columna:" + j + " el valor es: " + matriz[i, j]);
                }
            }
        }
    }
}
