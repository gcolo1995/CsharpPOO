using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    internal class RepositorioProductos
    {
        private List<Producto> Productos;

        public RepositorioProductos()
        {
            Productos = new List<Producto>();
            AgregarProducto("A1", "Lapiz", 100, 30);
            AgregarProducto("B1", "Birome", 80, 55);
            AgregarProducto("G1", "Goma", 50, 40);
            AgregarProducto("R1", "Regla", 60, 60);
        }

        private void AgregarProducto(string codigo, string nombre, int stock, int precio)
        {
            var producto = new Producto();
            producto.Codigo = codigo;
            producto.Nombre = nombre;
            producto.Stock = stock;
            producto.Precio = precio;
            Productos.Add(producto);
        }
    }


}
