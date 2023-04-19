using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clase3MiCaja
{
    public class Titular
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;
        private int _dni;
        private Genero _sexo;
        private int _telefono;

        public string Nombre
        {
            get { return _nombre; }
            set {_nombre = value ; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public DateTime FechaNac
        {
            get {return _fechaNac;}
            set { _fechaNac = value;}   
        }
        public int Edad
        {
            get
            {
                TimeSpan tiempoNacido= DateTime.Now.Subtract(_fechaNac);
                return Convert.ToInt32(Math.Truncate(tiempoNacido.TotalDays/365.25));
            }
        }        
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public Genero Sexo 
        { 
            get { return _sexo; }
            set { _sexo = value; }
        }
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    
    }
}
