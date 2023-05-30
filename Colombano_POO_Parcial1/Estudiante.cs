using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombano_POO_Parcial1
{
    internal class Estudiante : Pasajero
    {
        private string _institucion;
        private int _nroLegajo;

        public string Institucion { get => _institucion; set => _institucion = value; }
        public int NroLegajo { get => _nroLegajo; set => _nroLegajo = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
