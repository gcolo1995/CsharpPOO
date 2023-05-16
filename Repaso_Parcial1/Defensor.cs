using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Parcial1
{
    internal class Defensor : Jugador
    {
        private int _tarjAmarillas;
        private int _tarjRojas;

        public int TarjAmarillas { get => _tarjAmarillas; set => _tarjAmarillas = value;}
        public int TarjRojas { get => _tarjRojas; set => _tarjRojas = value;}

        public override string ToString()
        {
            return "--------DEFENSOR \n Apellido y Nombre: " + base.Apellido + " " +
                "" + base.Nombre + " \t Fecha de Nacimiento: " + base.FechaNac + " \t Edad: " + base.Edad + " " +
                "\t Amarillas: " + this.TarjAmarillas + "\t Rojas: " + this.TarjRojas+".";
        }
    }
}
