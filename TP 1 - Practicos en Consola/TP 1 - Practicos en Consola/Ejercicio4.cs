using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio4
    {
        int lado, area;
        public void Ej4()
        {
            Console.WriteLine("Ingrese el lado del cuadrado: ");
            lado = Convert.ToInt32(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El area del cuadrado es: " + area);
        }
    }
}
