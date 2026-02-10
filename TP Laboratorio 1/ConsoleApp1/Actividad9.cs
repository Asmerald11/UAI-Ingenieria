using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad9
    {
        public void act9()
        {
            string cadena;
            int[] vecval = Enumerable.Repeat(0, 5).ToArray();
            int[] veccantidad = Enumerable.Repeat(0, 5).ToArray();
            int sueldo, total = 0, horas, cat, i, j, legajo;
            for (i = 0; i < vecval.Length; i++)
            {
                cat = vecval[i];
                Console.WriteLine("Ingrese el valor de la hora");
                cadena = Console.ReadLine();
                vecval[i] = Convert.ToInt32(cadena);
            }
            Console.WriteLine("Ingrese el numero de legajo");
            legajo = int.Parse(Console.ReadLine());
            while (legajo != 0)
            {
                Console.WriteLine("Ingrese el sueldo");
                sueldo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la categoria del empleado");
                j = int.Parse(Console.ReadLine());
                veccantidad[j] = veccantidad[j] + 1;
                Console.WriteLine("Ingrese la cantidad de horas trabajadas");
                horas = int.Parse(Console.ReadLine());
                cat = vecval[j];
                sueldo = horas * cat;
                total += sueldo;
                Console.WriteLine("El sueldo del empleado {0} es de {1}: ", legajo, total);
                Console.WriteLine("Ingrese el numero de legajo");
                legajo = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < vecval.Length; i++)
            {
                Console.WriteLine("Hay {0} empleados en la categoria {1}", vecval[i], veccantidad[i]);
                Console.WriteLine("El total a pagar por sueldos es de: $" + total);
            }
            Console.ReadKey();
        }
    }
}
