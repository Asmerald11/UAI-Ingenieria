using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Ej2
    {
        public void Ejercicio2()
        {
            double num, i, res=1;
            Console.WriteLine("Ingrese el numero a trabajar");
            num = Convert.ToDouble(Console.ReadLine());
            double vuelt = num;
            for (i = 1; i < vuelt; i++)
            {
                res = res * num;
                num--;
            }
            Console.WriteLine("El factorial de {0} es {1}", vuelt, res);
        }
    }
}
