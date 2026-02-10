using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Actividad6
    {
        public void act6()
        {
            int a, b, c, d, tot;
            Console.WriteLine("ingrese el primer numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero:");
            d = int.Parse(Console.ReadLine());
            tot = a + b + c + d;
            Console.WriteLine("La suma total es: " + tot);
            Console.ReadKey();

        }
    }
}