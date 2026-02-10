using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad3
    {
        public void act3()
        {
            string valor;
            int a, b, c;
            Console.WriteLine("Ingrese el valor de una hora:");
            valor = Console.ReadLine();
            a = int.Parse(valor);
            Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
            valor = Console.ReadLine();
            b = int.Parse(valor);
            c = a * b;
            Console.WriteLine("El sueldo total es: " + c);
            Console.ReadKey();
        }
    }
}