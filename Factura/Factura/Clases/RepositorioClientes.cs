using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class RepositorioCliente
    {
        private List<Cliente> Clientes;

        public RepositorioCliente()
        {
            Clientes = new List<Cliente>();
            AgregarCliente("20112233449", "Juan Perez");
            AgregarCliente("23556677880", "Pablo Gomez");
            AgregarCliente("27990011221", "Susana Gimenez");
            AgregarCliente("30102030409", "UAI");

        }
        private void AgregarCliente(string cuit, string nombre)
        {
            var cliente = new Cliente();
            cliente.CUIT = cuit;
            cliente.RazonSocial = nombre;
            Clientes.Add(cliente);
        }
    }
}
