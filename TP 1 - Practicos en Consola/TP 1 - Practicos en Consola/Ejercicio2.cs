using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio2
    {
        int num1, num2, res;
        public void Ej2()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 - num2;
            Console.WriteLine("Entre los numeros hay " + res + " numeros");
        }
    }
}
