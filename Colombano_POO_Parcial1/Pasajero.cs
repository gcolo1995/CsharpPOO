using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombano_POO_Parcial1
{
    internal class Pasajero
    {
        private string _nombre;
        private string _apellido;
        private int _dni;

        public string Nombre { get => _nombre; set => _nombre = value;  }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }


        public override string ToString()
        {
            return base.ToString();
        }


    }
}
