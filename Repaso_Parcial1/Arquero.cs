using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Parcial1
{
    internal class Arquero : Jugador
    {
        private double _altura;

        public double Altura { get { return _altura; } set { _altura = value; } }

        public override string ToString()
        {
            return "--------ARQUERO \n Apellido y Nombre: " + base.Apellido + " " +
                "" + base.Nombre + " \t Fecha de Nacimiento: " + base.FechaNac + " \t Edad: " + base.Edad + " " +
                "\t Altura: " + this.Altura + ".";
        }

    }
}
