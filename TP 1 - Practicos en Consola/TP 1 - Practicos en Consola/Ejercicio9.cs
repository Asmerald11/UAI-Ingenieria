using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio9
    {
        public void Ej9()
        {
            string frase1, frase2, oracion;
            Console.WriteLine("Ingrese la primera frase: ");
            frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda frase: ");
            frase2 = Console.ReadLine();
            oracion = frase1 + " " + frase2;
            Console.WriteLine(oracion);
        }
    }
}
