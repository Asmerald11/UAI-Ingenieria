using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_2_26
{
    public class Ejercicio1
    {
        public void Actividad2()
        {
            int intentos = 10, generado, ingresado;
            Random RNG = new Random();
            generado = RNG.Next(1, 100);
            for (int i = 0; i < intentos; i++)
            {
                Console.WriteLine("Intente adivinar el numero generado.");
                if (!int.TryParse(Console.ReadLine(), out ingresado))
                {
                    Console.WriteLine("el valor es invalido");
                }
                else if (ingresado == generado)
                {
                    Console.WriteLine("Bien pibe, podes ser meteorologo");
                    break;
                }
                else if (ingresado > generado)
                {
                    Console.WriteLine("Mas bajo");
                }
                else
                {
                    Console.WriteLine("Mas alto");
                }
            }
            Console.WriteLine("el numero era " + generado);
        }
    }
}
