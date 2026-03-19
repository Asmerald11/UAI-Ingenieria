using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_5
{
    internal class Juicios
    {
        public string fecha;
        public string expediente;
        public string caratula;
        public Juicios siguiente;

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", fecha, expediente, caratula);
        }
    }
}
