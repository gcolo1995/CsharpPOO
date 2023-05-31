using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_P1_BsAs
{
    internal class Universidad
    {
        private List<Alumno> listaAlumnos;
        private int _cuota = 100;               //asigno una cuota general 
        private List<Beca> listaBecas;
        private int _cantMaxBecas = 2;          //se sabe que lo maximo son 2 becas por alumno

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
            listaBecas = new List<Beca>();

        }

        public void AgregarAlumno(Alumno alumnoNuevo)
        {
            this.listaAlumnos.Add(alumnoNuevo);
        }

        public void BorrarAlumno(Alumno alumnoBorrado)
        {
            this.listaAlumnos.Remove(alumnoBorrado);
        }

        public void AgregarBeca(Beca becaNueva)
        {
            this.listaBecas.Add(becaNueva);
        }

        public void BorrarBeca(Beca becaBorrada)
        {
            this.listaBecas.Remove(becaBorrada);
        }

    }
}
