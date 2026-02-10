using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad8
    {
        public void act8()
        {
            string cadena;
            int[] vecval = Enumerable.Repeat(0, 5).ToArray();
            int cat, legajo, empleado, sueldo, total, j;
            for (int i = 0; i < vecval.Length; i++)
            {
                cat = vecval[i];
                Console.WriteLine("Ingrese el valor de la hora:");
                cadena = Console.ReadLine();
                vecval[i] = Convert.ToInt32(cadena);
            }
            Console.WriteLine("Ingrese el numero de legajo");
            legajo = int.Parse(Console.ReadLine());
            empleado = legajo;
            while (legajo != 0)
            {
                Console.WriteLine("Ingrese el sueldo");
                sueldo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la categoria del empleado: ");
                j = int.Parse(Console.ReadLine());
                cat = vecval[j];
                total = sueldo * cat;
                Console.WriteLine("El sueldo del empleado {0} es de {1}: ", empleado, total);
                Console.WriteLine("Ingrese el numero de legajo");
                legajo = int.Parse(Console.ReadLine());
            }
        }
    }
}