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

        public Delantero(int goles)
        {
            CantGoles = goles;
        }
    }
}
