using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio14
    {
        public void Ej14()
        {
            int fecha, fecha1, dias;
            Console.WriteLine("Ingrese la fecha en formato DDMMAAAA: ");
            fecha = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda fecha en formato DDMMAAAA: ");
            fecha1 = int.Parse(Console.ReadLine());
            DateTime dt1 = DateTime.ParseExact(fecha.ToString("D8"), "ddMMyyyy", null);
            DateTime dt2 = DateTime.ParseExact(fecha1.ToString("D8"), "ddMMyyyy", null);
            TimeSpan diferencia = dt2 - dt1;
            dias = Math.Abs(diferencia.Days);
            Console.WriteLine("La cantidad de dias entre las fechas es: " + dias);
        }
    }
}
