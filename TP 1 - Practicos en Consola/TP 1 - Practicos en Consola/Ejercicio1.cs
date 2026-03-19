using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio1
    {
        int num1, num2, res;
        public void Ej1()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + res);
        }
    }
}
