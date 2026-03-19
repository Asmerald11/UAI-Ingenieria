using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio7
    {
        public void Ej7()
        {
            int kbytes, res, aux;
            Console.WriteLine("Ingrese la cantidad de Kbytes: ");
            kbytes = Convert.ToInt32(Console.ReadLine());
            aux = kbytes * 1024;
            res = aux * 8;
            Console.WriteLine("La cantidad de bits es: " + res);

            //Llegue a la conclusion mediante una serie de multiplicaciones, ingreso los kbytes
            //y lo multiplico por 1024 para obtener los bytes y ese numero por 8 para obtener los bits.
        }
    }
}
