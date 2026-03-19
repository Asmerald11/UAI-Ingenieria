using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class HospitalPaciente
    {
        public int codigo;
        public string nombre;
        public string apellido;
        public string direccion;
        public string telefono;
        public HospitalPaciente siguiente;

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", codigo, nombre, apellido, direccion, telefono);
        }
    }
}
