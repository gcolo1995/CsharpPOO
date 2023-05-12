using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Parcial1
{
    internal class Mediocampista : Jugador
    {
        private int _cantAsist;

        public int CantAsist { get => _cantAsist; set => _cantAsist = value; }

        public Mediocampista(int asistencias)
        {
            CantAsist = asistencias;
        }
    }
}
