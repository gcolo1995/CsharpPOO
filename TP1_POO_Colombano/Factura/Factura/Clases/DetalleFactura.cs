using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    internal class DetalleFactura
    {
        private Producto _producto;
        private int _cantidad;
        private decimal _subtotal;

        public Producto Producto { get => _producto; set => _producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal Subtotal { get => _subtotal; set => _subtotal = (_cantidad*Producto.Precio); }

    }
}
