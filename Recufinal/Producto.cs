using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recufinal
{
    internal class Producto
    {
        public string codigo;
        public string nombre;
        public decimal precio;
        public Producto siguiente;

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", codigo, nombre, precio);
        }
    }
}
