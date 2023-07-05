using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    internal class Cliente
    {
        private string _cuit;
        private string _razonSocial;

        public string CUIT { get => _cuit; set => _cuit = value; } 
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }

    }  

}
