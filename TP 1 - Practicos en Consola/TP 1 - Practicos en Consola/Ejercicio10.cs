using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio10
    {
        public void Ej10()
        {
            string frase, mitad1, mitad2;
            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
            mitad1 = frase.Substring(0, frase.Length / 2);
            mitad2 = frase.Substring(frase.Length / 2);
            Console.WriteLine(mitad2 + " " + mitad1);
        }
    }
}
