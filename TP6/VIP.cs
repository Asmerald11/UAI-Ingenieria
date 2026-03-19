using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    internal class VIP
    {
        public string nombre;
        public int prioridades;
        public VIP siguiente;

        public override string ToString()
        {
            return string.Format("{0} {1}", nombre, prioridades);
        }
    }
}
