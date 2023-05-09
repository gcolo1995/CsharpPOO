using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_Forms_ObjetosyClases_Ej1
{
    internal class Inventario
    {
        private List<Producto> listado;

        public Inventario()
        {
            listado = new List<Producto>();
        }
    
        public void AgregarProducto(Producto nuevo)
        {
            if(BuscarProducto(nuevo) == null)
            {
                listado.Add(nuevo);
            }
            else
            {
                MessageBox.Show("El producto " + nuevo.Nombre + " ya estaba cargado.");
            }
        }
        public void BorrarProducto(Producto borrado)
        {
            listado.Remove(BuscarProducto(borrado));
            MessageBox.Show("Se ha eliminado a " + borrado.Nombre + ".");
        }
        public Producto BuscarProducto(Producto buscado)
        {
            var producto = listado.FirstOrDefault(b => b.Nombre == buscado.Nombre); 
            return producto;
        }
        public void ModificarProducto(Producto viejo, Producto modificado)
        {
            BuscarProducto(viejo).Nombre = modificado.Nombre;
            BuscarProducto(viejo).Precio = modificado.Precio;
            BuscarProducto(viejo).Cantidad = modificado.Cantidad;
        }

        public ReadOnlyCollection<Producto> ListarInventario()
        {
            return listado.AsReadOnly();
        }
    }
}
