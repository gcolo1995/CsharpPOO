using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    internal class Curso
    {
        private string _nombreCurso;
        private List<Alumno> listado;

        public string NombreCurso { get => _nombreCurso; set => _nombreCurso = value; }

        public Curso()
        {
            listado = new List<Alumno>();
        }
        
        public Alumno BuscarAlumno(int legajo)
        {
            var buscado = new Alumno();
            buscado = listado.FirstOrDefault(b => buscado.NroLegajo == legajo);
            return buscado;
        }

        public void AgregarAlumno(Alumno nuevo)
        {
            var alumno = nuevo;
            if (BuscarAlumno(nuevo.NroLegajo)  == null)
            {
                listado.Add(nuevo);
            }
            
                
        }

        public void QuitarAlumno(Alumno quitado)
        {
            listado.Remove(quitado);

        }
    }
}
