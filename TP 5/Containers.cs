using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5
{
    internal class Containers
    {
        public string nombre;
        public Containers siguiente;

        public override string ToString()
        {
            return string.Format("{0}", nombre);
        }
    }
}
