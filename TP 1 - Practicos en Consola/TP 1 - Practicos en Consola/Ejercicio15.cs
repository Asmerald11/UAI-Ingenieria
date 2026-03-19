using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio15
    {
        public void Ej15()
        {
            DateTime fec = new DateTime(2030, 12, 25);
            System.DateTime.Today.ToString("ddMMyyyy");
            DateTime fecha = DateTime.ParseExact(fec.ToString("ddMMyyyy"), "ddMMyyyy", null);
            TimeSpan diferencia = fecha - DateTime.Today;
            int diasFaltantes = diferencia.Days;
            Console.WriteLine("Los dias que faltan son: " + diasFaltantes);
        }
    }
}
