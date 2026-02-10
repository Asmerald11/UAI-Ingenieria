using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad11
    {
        public void act11()
        {
            int ticket, pizza=0, cant=0, vuelta=0, moto, costo, max=0, min=100000, total=0, i=0, pizA=0;
            int[,] motomatriz = new int[5, 1000];
            int[,] pizzamatriz = new int[6, 1000];
            float prom, porcentaje;

            Console.WriteLine("Ingrese el numero de ticket:");
            ticket = int.Parse(Console.ReadLine());
            while (ticket != 0)
            {
                Console.WriteLine("Ingresar el tipo de pizza");
                pizza = int.Parse(Console.ReadLine());
                if (pizza == 1)
                {
                    pizA = pizA + cant;
                }
                Console.WriteLine("Ingrese la cantidad de pizzas");
                cant = int.Parse(Console.ReadLine());
                cant += cant;
                pizzamatriz[pizza, cant] += cant;
                Console.WriteLine("Ingrese la moto encargada");
                moto = int.Parse(Console.ReadLine());
                motomatriz[moto, vuelta] += vuelta;
                Console.WriteLine("Ingrese el costo:");
                costo = int.Parse(Console.ReadLine());
                total += costo;
                if (costo < min)
                {
                    min = costo;
                } else if (costo > max)
                {
                    max = costo;
                }
                i++;
                Console.WriteLine("Ingrese el numero de ticket:");
                ticket = int.Parse(Console.ReadLine());

            }
            int motomin = 0;
            for (int j=1; j<=4; j++)
            {
                if (motomatriz[j, vuelta] < motomin)
                {
                    motomin = motomatriz[j, vuelta];
                }
            }
            prom = total / i;
            porcentaje = (pizA * 100) / cant;
            Console.WriteLine("El costo maximo es: " + max);
            Console.WriteLine("El costo minimo es: " + min);
            Console.WriteLine("El promedio de los costos es: " + prom);
            Console.WriteLine("El porcentaje de pizzas A vendidas es: " + porcentaje);
            Console.WriteLine("El total de la recaudacion es: " + total);
            Console.WriteLine("La moto que menos entregas realizo es: " + motomin);
        }
    }
}
