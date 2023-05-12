using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Parcial1
{
    internal class Jugador
    {
        protected string _nombre;
        protected string _apellido;
        protected DateTime _fechaNac;
        // protected int _edad;         no se termina usando nunca como atributo

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNac { get => _fechaNac; set=> _fechaNac = (DateTime)value; }
        public int Edad
        {
            get
            { 
                TimeSpan tiempoNacido = DateTime.Now.Subtract(_fechaNac);
                return Convert.ToInt32(Math.Truncate(tiempoNacido.TotalDays/365.25));
            }
        }
    }
}
