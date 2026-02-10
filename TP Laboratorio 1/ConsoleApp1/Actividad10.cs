using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad10
    {
        public void act10()
        {
            int[,] matriz = new int[50, 5];
            int i, j, categoria, departamento, horas;
            for (i=1; i<=4; i++)
            {
                Console.WriteLine("Ingrese el valor de las horas para la categoria " + i);
                categoria = int.Parse(Console.ReadLine());
                for (j=1; j<=4; j++)
                {
                    Console.WriteLine("Ingrese el numero del departamento");
                    departamento = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de horas trabajadas");
                    horas = int.Parse(Console.ReadLine());
                    matriz[categoria, departamento] += horas; 
                }

            }
            for (i=1; i<=4; i++)
            {
                for (j=1; j<=4; j++)
                {
                    Console.WriteLine("Categoria {0}, departamento {1} y horas {2}\n", i, j, matriz[i, j]);
                }
            }
        }
    }
}
