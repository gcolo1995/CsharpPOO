using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colombano_POO_Parcial1
{
    internal class Jubilado : Pasajero
    {
        private int _nroAfiliadoPAMI;

        public int NroAfiliaroPAMI { get => _nroAfiliadoPAMI; set => _nroAfiliadoPAMI = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
