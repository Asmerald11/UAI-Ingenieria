using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    internal class Colado
    {
        public string nombre;
        public int ticket;

        public override string ToString()
        {
            return string.Format("{0} Ticket: {1}", nombre, ticket);
        }
    }
}
