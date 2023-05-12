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

        public Defensor(int amarillas, int rojas)
        {
            TarjAmarillas = amarillas;
            TarjRojas = rojas;
        }
    }
}
