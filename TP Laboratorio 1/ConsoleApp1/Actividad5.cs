using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad5
    {
        public void act5()
        {
            Console.WriteLine("ingrese el primer numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("los numeros son iguales");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("el menor es :" + b);
                }
                else
                {
                    Console.WriteLine("el menor es :" + a);
                }
                Console.ReadKey();
            }
        }
    }
}