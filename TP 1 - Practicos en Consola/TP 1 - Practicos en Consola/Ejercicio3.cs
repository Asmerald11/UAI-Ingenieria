using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1___Practicos_en_Consola
{
    public class Ejercicio3
    {
        int lado1, lado2, lado3, perimetro;
        public void Ej3()
        {
            Console.WriteLine("Ingrese el primer lado del triangulo: ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado del triangulo: ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado del triangulo: ");
            lado3 = Convert.ToInt32(Console.ReadLine());
            perimetro = lado1 + lado2 + lado3;
            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
        }
    }
}
