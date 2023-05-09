using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Forms_ObjetosyClases_Ej1
{
    internal class Producto
    {
        private string _nombre;
        private double _precio;
        private int _cantidad;

        public string Nombre
            { get =>_nombre; set => _nombre = value; }

        public double Precio
        { get => _precio; set => _precio = value; }

        public int Cantidad
        { get => _cantidad; set => _cantidad = value; }


    }
}
