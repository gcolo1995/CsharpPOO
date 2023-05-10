using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6_Ejemplo_Pasajero
{
    internal class Estudiante : Pasajero
    {
        private int _nroLegajo;
        private string _institucion;

        public int NroLegajo { get => _nroLegajo; set => _nroLegajo = value; }
        public string Institucion { get => _institucion; set => _institucion = value;}

        

    }
}
