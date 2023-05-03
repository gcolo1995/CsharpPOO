using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    internal class Alumno
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private int _nroLegajo;

        public string Nombre {get => _nombre; set =>_nombre = value; } 
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNac { get => _fechaNacimiento; set => _fechaNacimiento = (DateTime)value; }
        public int NroLegajo { get => _nroLegajo; set => _nroLegajo = value;}



    }
}
