using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio5
    {
        int bas, alt, area;
        public void Ej5()
        {
            Console.WriteLine("Ingrese la base del rectangulo: ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            alt = Convert.ToInt32(Console.ReadLine());
            area = bas * alt;
            Console.WriteLine("La superficie del rectangulo es: " + area);
        }
    }
}
