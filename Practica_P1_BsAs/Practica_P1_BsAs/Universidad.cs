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

        public List<Alumno> ObtenerAlumnos()
        {
            return listaAlumnos;
        }

        public List<Beca> ObtenerBecas()
        {
            return listaBecas;
        }




        /*
        public List<Beca> ObtenerBecasPorAlumno(Alumno alumno)
        {
            List<Beca> becasPorAlumno = new List<Beca>();
            becasPorAlumno = alumno.ListaBecas;

            foreach (Beca beca in listaBecas)
            {
                if (beca.Alumno == alumno)
                {
                    becasPorAlumno.Add(beca);
                }
            }

            return becasPorAlumno;
        }


        public void AsignarBeca(Alumno alumno, Beca beca)
        {
            if (!listaBecas.Contains(beca))
            {
                throw new Exception("La beca especificada no está disponible.");
            }

            if (ObtenerBecasPorAlumno(alumno).Count >= _cantMaxBecas)
            {
                throw new Exception("El alumno ya ha alcanzado el número máximo de becas.");
            }

            if (beca.Importe > 1)
            {
                throw new Exception("El importe de la beca no puede ser mayor que 1 (100% de la cuota).");
            }

            alumno.AgregarBeca(alumno, beca);
        }*/

        public void QuitarBeca(Alumno alumno, Beca beca)
        {
            alumno.QuitarBeca(alumno, beca);

        }
    }





}

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
        public int Dni { get => _dni; set => _dni = value; }
        public TipoAlumno TipoDeAlumno { get => _tipoAlumno; set => _tipoAlumno = value; }
        public List<Beca> ListaBecas { get => listaBecas; }

        public Alumno()
        {
            listaBecas = new List<Beca>();
        }

        public void AgregarBeca(Alumno alumno, Beca beca)
        {
            alumno.listaBecas.Add(beca);
        }
        public void QuitarBeca(Alumno alumno, Beca beca)
        {
            alumno.listaBecas.Remove(beca);
        }

}
    public enum TipoAlumno
    {
        Ingresante = 0,
        Grado = 1,
        Posgrado = 2,
    }

    internal class Beca
    {
        private DateTime _fechaOtrorg;
        private string _codigo;
        private decimal _importe;       //porque es un porcentaje de la cuota, no debe ser mayor que 1 (100% de la cuota)

        public DateTime FechaOtorg { get => _fechaOtrorg; set => _fechaOtrorg = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public decimal Importe { get => _importe; set => _importe = value; }

    }

}
