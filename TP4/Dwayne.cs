using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Dwayne
    {
        public string nombre;
        public string apellido;
        public int edad;
        public Dwayne siguiente;
        public Dwayne anterior;
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", nombre, apellido, edad);
        }
    }
}
