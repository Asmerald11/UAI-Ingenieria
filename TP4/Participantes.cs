using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    internal class Participantes
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string DNI;
        public Participantes siguiente;

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", nombre, apellido, edad, DNI);
        }
    }
}
