using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_POO_Colombano
{
    public class ListadoAlumno
    {
        private List<Alumno> listaAlumnos;       //atributo
        // private int _contadorLegajo;         no pude usar el contador desde ListadoAlumnos
        
        public ListadoAlumno()
        {
            listaAlumnos = new List<Alumno>();
            //_contadorLegajo = 1;
        }

        /*public int ContadorLegajo 
        {
            get { return _contadorLegajo; }
        }*/

        #region MetodosDeBusqueda
        public Alumno BuscarNombreApellidoNac (string nombre, string apellido, DateTime fecha)
        {
            var alumno = listaAlumnos.FirstOrDefault(a => a.Nombre == nombre && a.Apellido == apellido &&
            a.FechaNacimiento == fecha);
            if (alumno != null)
                return alumno;
            else
                return null;

        }
        

        public Alumno BuscarLegajo(int legajo)
        {
            var alumno = listaAlumnos.FirstOrDefault(a => a.Legajo == legajo);
            if (alumno != null)
                return alumno;
            else
                return null;
        }
        #endregion

        public void AgregarAlumno (Alumno alumno)
        {     
            listaAlumnos.Add(alumno);
            //_contadorLegajo++;
        }
        public string QuitarAlumno(int legajo)
        {
            var alumno = BuscarLegajo(legajo);
            if (alumno != null)
            {
                listaAlumnos.Remove(alumno);
                return $"El alumno {alumno.Nombre} {alumno.Apellido} ha sido eliminado correctamente";
            }
            else
            {
                return $"La operacion no se puede completar. El numero de legajo {legajo} no existe.";
            }
        }

        public ReadOnlyCollection<Alumno> ListarAlumnos()
        {
            return listaAlumnos.AsReadOnly();
        }


        public static implicit operator List<object>(ListadoAlumno v)
        {
            throw new NotImplementedException();
        }
    }
}
