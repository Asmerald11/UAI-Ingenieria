using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Estudiante
    {
        public string nombre;
        public string apellido;
        public string DNI;
        public string nacimiento;
        public string direccion;
        public string telefono;
        public Estudiante siguiente;
        public Estudiante anterior;

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", nombre, apellido, DNI, nacimiento, direccion, telefono);
        }
    }
}
