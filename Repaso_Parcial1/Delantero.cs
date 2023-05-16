using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Parcial1
{
    internal class Delantero : Jugador
    {
        private int _cantGoles;

        public int CantGoles { get => _cantGoles; set => _cantGoles = value; }

        public override string ToString()
        {
            return "--------DELANTERO \n Apellido y Nombre: " + base.Apellido + " " +
                "" + base.Nombre + " \t Fecha de Nacimiento: " + base.FechaNac + " \t Edad: " + base.Edad + " " +
                "\t Goles: " + this.CantGoles + ".";
        }
    }
}
