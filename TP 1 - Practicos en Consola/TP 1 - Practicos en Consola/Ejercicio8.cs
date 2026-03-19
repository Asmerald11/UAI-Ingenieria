using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio8
    {
        public void Ej8()
        {
            int i, num, res=1;
            Console.WriteLine("Ingrese el numero a factorializar: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                res = res * i; 
            }
            Console.WriteLine("El factorial es: " + res);
        }
    }
}
