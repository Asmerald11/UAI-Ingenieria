using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5
{
    internal class Cities
    {
        public string nombre;
        public Cities siguiente;

        public override string ToString()
        {
            return string.Format("{0}", nombre);
        }
    }
}
