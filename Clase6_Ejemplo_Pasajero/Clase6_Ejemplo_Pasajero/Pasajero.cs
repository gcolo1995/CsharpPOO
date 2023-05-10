using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6_Ejemplo_Pasajero
{
    internal class Pasajero
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }


    }
}
