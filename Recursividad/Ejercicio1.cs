using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Ejercicio1
    {
        int i, num, res;
        public void Ej1()
        {
            Console.WriteLine("Ingrese un numero a trabajar");
            num = Convert.ToInt32(Console.ReadLine());
            res = num;
            for (i = 1; i < num; i++) {
                res = res - 1;
                Console.WriteLine("{0}", res);
            }
        }
    }
}
