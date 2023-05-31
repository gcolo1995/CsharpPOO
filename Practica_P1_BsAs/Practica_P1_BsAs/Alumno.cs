using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_P1_BsAs
{
    internal class Alumno
    {
        private string _legajo;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private TipoAlumno _tipoAlumno;
        private List<Beca> listaBecas;

        public string Legajo { get => _legajo; set => _legajo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni;  set => _dni = value; }
        public TipoAlumno TipoDeAlumno { get => _tipoAlumno; set => _tipoAlumno = value;}

        public Alumno()
        {
            listaBecas = new List<Beca>();
        }

    }
    public enum TipoAlumno
    {
        Ingresante = 0,
        Grado = 1,
        Posgrado = 2,
    }
}
