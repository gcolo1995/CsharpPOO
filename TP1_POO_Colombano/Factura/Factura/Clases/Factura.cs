using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    internal class Factura
    {
        private Cliente _cliente;
        private List<DetalleFactura> detalleFacturas;
        private decimal _total;
        private int _nroFactura;
        private DateTime _fecha;

        public Cliente cliente { get=> _cliente; set => _cliente = value; }
        public decimal Total { get =>  _total; set => _total = value; }
        public int NroFactura { get => _nroFactura; set => _nroFactura = value;}
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        
        public Factura()
        {
            _cliente = new Cliente();
            var detalleFacturas = new List<DetalleFactura>();
        }

        public string AgregarDetalle(Producto producto, int cantidad)
        {
            var detalle = new DetalleFactura();
            detalle.Producto = producto;
            detalle.Cantidad = cantidad;
            detalle.Subtotal = producto.Precio * cantidad;

            detalleFacturas.Add(detalle);
            return "Producto Cargado";

        }

        public void QuitarDetalle(Producto producto)
        {

        }

        public void ModificarDetalle(Producto produto, int cantidad)
        {

        }
    }
}
