using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_2_26
{
    public class Ejercicio2
    {
        public void operaciones()
        {
            int opcion, a, b, i;
            float c;
            for (i = 0; i < 5; i++) {
                Console.WriteLine("Seleccione la operacion a ejecutar: 1) Suma 2) Resta 3) Multiplicacion 4) Division");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    i--;
                } else {
                    switch (opcion) {
                        case 1:
                            Console.WriteLine("Ingrese el primer valor de la suma");
                            int.TryParse(Console.ReadLine(), out a);
                            Console.WriteLine("Ingrese el segundo valor de la suma");
                            int.TryParse(Console.ReadLine(), out b);
                            c = a + b;
                            Console.WriteLine("El resultado es: " + c);
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el primer valor de la resta");
                            int.TryParse(Console.ReadLine(), out a);
                            Console.WriteLine("Ingrese el segundo valor de la resta");
                            int.TryParse(Console.ReadLine(), out b);
                            c = a - b;
                            Console.WriteLine("El resultado es: " + c);
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el primer valor de la multiplicacion");
                            int.TryParse(Console.ReadLine(), out a);
                            Console.WriteLine("Ingrese el segundo valor de la multiplicacion");
                            int.TryParse(Console.ReadLine(), out b);
                            c = a * b;
                            Console.WriteLine("El resultado es: " + c);
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el primer valor de la division");
                            int.TryParse(Console.ReadLine(), out a);
                            Console.WriteLine("Ingrese el segundo valor de la division");
                            int.TryParse(Console.ReadLine(), out b);
                            c = a / b;
                            Console.WriteLine("El resultado es: " + c);
                            break;
                        default:
                            Console.WriteLine("Opcion no valida, seleccione una opcion valida");
                            i--;
                            break;
                    }
                }
            } 
        } 
    } 
}
