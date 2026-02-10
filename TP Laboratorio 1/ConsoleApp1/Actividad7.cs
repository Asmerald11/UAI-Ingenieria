using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad7
    {
        public void act7()
        {
            int legajo, sueldo, suma = 0, i = 0;
            float promedio;
            Console.WriteLine("Ingrese el numero de legajo:");
            legajo = int.Parse(Console.ReadLine());
            while (legajo != 0)
            {
                Console.WriteLine("Ingrese el sueldo:");
                sueldo = int.Parse(Console.ReadLine());
                suma += sueldo;
                i = i + 1;
                Console.WriteLine("Ingrese el numero de legajo:");
                legajo = int.Parse(Console.ReadLine());
            }
            promedio = suma / i;
            Console.WriteLine("El promedio de sueldos es: " + promedio);
            Console.ReadKey();
        }
    }
}