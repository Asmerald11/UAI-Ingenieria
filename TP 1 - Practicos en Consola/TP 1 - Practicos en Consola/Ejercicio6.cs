using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio6
    {
        int circ, diam;
        public void Ej6()
        {
            Console.WriteLine("Ingrese el diametro del circulo: ");
            circ = Convert.ToInt32(Console.ReadLine());
            diam = (int)(circ/3.14);
            Console.WriteLine("La circunferencia del circulo es: " + diam);
        }
    }
}
