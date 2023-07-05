using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    internal class Producto
    {
        private string _codigo;
        private string _nombre;
        private int _stock;
        private int _precio;

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int Precio { get => _precio; set => _precio = value; }
    }
}
