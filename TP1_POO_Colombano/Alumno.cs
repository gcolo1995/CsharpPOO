using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_POO_Colombano
{
    public class Alumno
    {
        #region atributes
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private DateTime _fecha_Nacimiento;
        private DateTime _fecha_Ingreso;
        private int _edad;
        private Boolean _activo;
        private int _cant_Materias_Aprobadas;
        #endregion

        #region properties
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        public string Nombre
        {
            get { return _nombre;}
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            set { _fecha_Nacimiento = value; }
        }
        public DateTime FechaIngreso
        {
            set { _fecha_Ingreso = value; }
        }
        public int Edad
        {
            get
            {
                TimeSpan _tiempo = DateTime.Now.Subtract(_fecha_Nacimiento);
                _edad = Convert.ToInt32(Math.Truncate(_tiempo.TotalDays / 365.25));
                return _edad;

            }
        }
        public Boolean Activo
        {
            get { return _activo;}
            set { _activo = value; }
        }
        public int CantAprobadas
        {
            set { _cant_Materias_Aprobadas = value; }
        }
        #endregion

        #region metods

        public int Antiguedad(string unidad)            //la unidad ya va a estar convertida en .Year
        {
            int _tiempo = 0;
            
            if (unidad == "Años")
            {
                _tiempo = DateTime.Now.Year - _fecha_Ingreso.Year;
                if( DateTime.Now.DayOfYear < _fecha_Ingreso.DayOfYear )
                {
                    _tiempo--;
                }
            }
            else if (unidad == "Meses")
            {
                int _ano = DateTime.Now.Year - _fecha_Ingreso.Year;
                int _meses = DateTime.Now.Month - _fecha_Ingreso.Month;
                if (DateTime.Now.DayOfYear < _fecha_Ingreso.DayOfYear)
                {
                    _meses--;
                }

                _tiempo = _ano * 12 + _meses ;
            }
            else if (unidad == "Dias")    
            {
                TimeSpan _dias = DateTime.Now.Subtract(_fecha_Ingreso);
                _tiempo = Convert.ToInt32(_dias.TotalDays);
            }

            return _tiempo;

        }

        public int Materias_No_Aprobadas()
        {
            int _cantMaterias = 36;
            return (_cantMaterias - _cant_Materias_Aprobadas);
        }

        public int Edad_De_Ingreso()
        {
            TimeSpan _tiempo = _fecha_Ingreso - _fecha_Nacimiento;
            return Convert.ToInt32(Math.Truncate(_tiempo.TotalDays / 365.25));
        }

        #endregion

    }
}
