using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2feb26
{
    public class Caso6
    {
        public void caso6()
        {
            bool esAdmin = true, tienePermisoEspecial = true, cuentaActiva = true;
            int intentosFallidos = 0;

            if (esAdmin == true ^ (tienePermisoEspecial == true && cuentaActiva == true))
            {
                Console.WriteLine("Acceso permitdo");
            }
            else if (cuentaActiva == false || intentosFallidos > 3)
            {
                Console.WriteLine("Acceso denegado");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            //¿Qué devuelve esAdmin ^ tienePermisoEspecial ?

            //Teniendo en cuenta los datos proporcionados deberia devolver "Acceso denegado" dado que XOR compara si uno o el otro es true y ambos son true.


            //    ¿En qué situación sería útil este operador?

            //    Hay casos donde el inicio de sesion en ciertas plataformas se implementan o podria estar implementado como por ejemplo cuando se pide usuario o correo y contraseña
            //    pudiendo en un mismo campo tener dos opciones para iniciar sesion y sumandole la contraseña.
        }
    }
}
