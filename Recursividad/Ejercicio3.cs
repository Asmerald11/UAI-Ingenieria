using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Ejercicio3
    {
        public void Ejercici3()
        {
            int[] desordenado = new int[4];
            for (int i = 0; i < desordenado.Length; i++)
            {
                Console.WriteLine("Escriba el numero a agregar");
                desordenado[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < desordenado.Length; i++)
            {
                Console.Write(desordenado[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < desordenado.Length; i++)
            {
                int j = i++;
                if (desordenado[i] > desordenado[j])
                {
                    int aux = desordenado[i];
                    desordenado[i] = desordenado[j];
                    desordenado[j] = aux;
                }
            }
            Console.WriteLine("El vector ordenado de manera descendente es:");
            for (int i = 0; i < desordenado.Length; i++)
            {
                Console.Write(desordenado[i] + " ");
            }
        }
    }
}
