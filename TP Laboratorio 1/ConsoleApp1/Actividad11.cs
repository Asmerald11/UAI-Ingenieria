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
           
            int ticket, codPizza, cantidad, nroMoto;
            double monto;

            double maxMonto = -1;       
            int maxTicket = 0;          
            int maxMoto = 0;            

            int[] viajesPorMoto = new int[5];
                                             

            int totalPizzasA = 0;       
            int totalEnvios = 0;        
            double facturacionTotal = 0;


            Console.WriteLine("Ingrese el numero de ticket (0 para terminar):");
            ticket = int.Parse(Console.ReadLine());

            while (ticket != 0)
            {
                Console.WriteLine("Ingrese el código de pizza (1-6):");
                codPizza = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de pizzas:");
                cantidad = int.Parse(Console.ReadLine());

                if (codPizza == 1)
                {
                    totalPizzasA += cantidad;
                }
                Console.WriteLine("Ingrese el Nro de moto (1-4):");
                nroMoto = int.Parse(Console.ReadLine());

                if (nroMoto >= 1 && nroMoto <= 4)
                {
                    viajesPorMoto[nroMoto]++;
                }
                else
                {
                    Console.WriteLine("Error: Moto desconocida.");
                }


                Console.WriteLine("Ingrese el monto del pedido:");
                monto = double.Parse(Console.ReadLine());

                facturacionTotal += monto;
                totalEnvios++;

                if (monto > maxMonto)
                {
                    maxMonto = monto;
                    maxTicket = ticket;
                    maxMoto = nroMoto;
                }

                Console.WriteLine("Ingrese el numero de ticket (0 para terminar):");
                ticket = int.Parse(Console.ReadLine());
            }


            if (totalEnvios > 0)
            {

                int minViajes = 100000;
                int motoMenosViajes = 0;

                for (int m = 1; m <= 4; m++)
                {
                    if (viajesPorMoto[m] < minViajes)
                    {
                        minViajes = viajesPorMoto[m];
                        motoMenosViajes = m;
                    }
                }

                double promedio = facturacionTotal / totalEnvios;
                double porcentaje = (double)(totalPizzasA * 100) / totalEnvios;

                Console.WriteLine("\nRESULTADOS:");
                Console.WriteLine("1. El Ticket de mayor valor fue el Nro: " + maxTicket +
                                  " ($" + maxMonto + ") llevado por la Moto " + maxMoto);
                Console.WriteLine("2. La moto con menos viajes fue la Nro: " + motoMenosViajes +
                                  " (" + minViajes + " viajes)");
                Console.WriteLine("3. Valor promedio de los tickets: $" + promedio);
                Console.WriteLine("4. Porcentaje de cantidad Pizzas 'A' sobre total de envíos: " + porcentaje + "%");
                Console.WriteLine("5. Facturación total del negocio: $" + facturacionTotal);
            }
            else
            {
                Console.WriteLine("No se ingresaron datos.");
            }
        }
    }
}
