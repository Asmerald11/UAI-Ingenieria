using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Actividad_2_2_26
{
    public class Ejercicio3
    {
        public void Calificaciones()
        {
            int salir = 0, opcion, nota=0, cantAlumnos = 0, i=0, total=0, min=1000, max=0;
            float prom = 0;
            int[] calificaciones = new int[cantAlumnos];
            while (salir != 1)
            {
                Console.WriteLine("Elija la opcion a ejecutar 1) Ingresar calificaciones 2) Mostrar calificaciones 3)Calcular promedio 4) Mostrar mas alta y mas baja");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("El valor ingresado no es valido");
                }
                else { 
                 switch (opcion) {
                        case 1:
                            Console.WriteLine("Ingrese la cantidad de alumnos");
                            int.TryParse(Console.ReadLine(), out cantAlumnos);
                            calificaciones = new int[cantAlumnos];
                            for (i = 0; i < cantAlumnos; i++)
                            {
                                Console.WriteLine("Ingrese la calificacion del alumno");
                                int.TryParse(Console.ReadLine(), out nota);
                                calificaciones[i] = nota;
                                total = total + nota;
                                prom = total / cantAlumnos;
                                if (nota < min)
                                {
                                    min = nota;
                                }
                                else
                                {
                                }
                                if (nota > max) { 
                                
                                    max = nota;
                                    } else { }
                                }
                                break;
                        case 2:
                            {
                                if (cantAlumnos == 0) {
                                    Console.WriteLine("No hay notas para mostrar, seleccione ingresar notas en el menu");
                                } else {
                                    Console.WriteLine("Las calificaciones de los alumnos son: ");
                                    for (i = 0; i < cantAlumnos; i++){
                                    Console.WriteLine(" " + calificaciones[i]);
                                }
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("El promedio es: " + prom);
                            break;
                        case 4:
                            Console.WriteLine("La nota maxima es: " + max );
                            Console.WriteLine("La nota minima es: " + min);
                            break;
                        default:
                            {
                                Console.WriteLine("Opcion invalida, por favor elija una opcion valida");
                            }
                            break;
                    }
                }
            }
        }
    }
}
