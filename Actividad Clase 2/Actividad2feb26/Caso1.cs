using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2feb26
{
    public class Caso1
    {
        public void caso1()
        {
            bool esAdmin = true, tienePermisoEspecial = false, cuentaActiva = true;
            int intentosFallidos = 0;

            if (esAdmin == true || (tienePermisoEspecial == true && cuentaActiva == true))
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
        }
    }
}
