using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio13
    {
        public void Ej13()
        {
            int fecha;
            fecha = int.Parse(System.DateTime.Today.ToString("yyyyMMdd"));
            Console.WriteLine(fecha);
        }
    }
}
