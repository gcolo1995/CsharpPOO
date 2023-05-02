using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_POO_Colombano
{
    public class Alumno
    {
        #region atributes
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private DateTime _fechaIngreso;
        private bool _activo;
        private int _cantMateriasAprobadas;
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
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }
        public int Edad
        {
            get
            {
                TimeSpan _edad = DateTime.Now.Subtract(_fechaNacimiento);
                return Convert.ToInt32(Math.Truncate(_edad.TotalDays / 365.25)); 
            }
        }
        public bool Activo
        {
            get { return _activo;}
            set { _activo = value; }
        }
        public int CantAprobadas
        {
            set { _cantMateriasAprobadas = value; }
        }
        #endregion

        #region metods

        public int CalcularAntiguedad(string unidad)            //la unidad ya va a estar convertida en .Year
        {
            int _tiempo = 0;
            
            if (unidad == "Años")
            {
                _tiempo = DateTime.Now.Year - _fechaIngreso.Year;
                if( DateTime.Now.DayOfYear < _fechaIngreso.DayOfYear )
                {
                    _tiempo--;
                }
            }
            else if (unidad == "Meses")
            {
                int _ano = DateTime.Now.Year - _fechaIngreso.Year;
                int _meses = DateTime.Now.Month - _fechaIngreso.Month;
                if (DateTime.Now.DayOfYear < _fechaIngreso.DayOfYear)
                {
                    _meses--;
                }

                _tiempo = _ano * 12 + _meses ;
            }
            else if (unidad == "Días")    
            {
                TimeSpan _dias = DateTime.Now.Subtract(_fechaIngreso);
                _tiempo = Convert.ToInt32(_dias.TotalDays);
            }

            return _tiempo;

        }

        public int CalcularMateriasNoAprob()
        {
            int _cantMaterias = 36;
            return (_cantMaterias - _cantMateriasAprobadas);
        }

        public int CalcularEdadIngreso()
        {
            TimeSpan _tiempo = _fechaIngreso - _fechaNacimiento;
            return Convert.ToInt32(Math.Truncate(_tiempo.TotalDays / 365.25));
        }

        #endregion
        ~Alumno()
        {
            MessageBox.Show("Se ha eliminado un alumno");
        }
    }
}
