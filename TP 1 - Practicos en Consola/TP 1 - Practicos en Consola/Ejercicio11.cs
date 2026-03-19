using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio11
    {
        public void Ej11()
        {
            string frase, longitud;
            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
            longitud = Convert.ToString(frase.Length);
            Console.WriteLine("En la frase hay " + longitud + " caracteres.");
        }
    }
}
