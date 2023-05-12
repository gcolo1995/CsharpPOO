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
        private int _contador;

        public double Altura { get { return _altura; } set { _altura = value; } }
        public int Contador { get { return _contador; } }

        public Arquero(double altura)
        {
            _altura = altura;
        }
    }
}
