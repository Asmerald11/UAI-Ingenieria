using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    internal class Nado
    {
        public string nombre;
        public string genero;
        public Nado siguiente;

        public override string ToString()
        {
            return string.Format("{0} {1}", nombre, genero);
        }
    }
}
