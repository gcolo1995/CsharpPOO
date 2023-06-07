using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Articulo
    {
        private int _codigo;
        private Categoria _categoria;
        private decimal _precioCompra;
        private decimal _precioVenta;
        private string _nombre;
        private int _cantidad;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public decimal PrecioCompra { get => _precioCompra; set => _precioCompra = value;}
        public decimal PrecioVenta { get => _precioVenta; set => _precioVenta = value;}
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Cantidad { get => _cantidad; set => _codigo = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
    }
    
    public class RepositorioArticulos
    {
        public List<Articulo> listaArticulos ;

        public RepositorioArticulos()
        {
            listaArticulos = new List<Articulo>();
        }
            
        public string Agregar(Articulo articulo) 
        { 
            listaArticulos.Add(articulo);
            return ""+articulo.Nombre+" se ha agregado correctamente.";
        }

        public string Modificar(Articulo articulo)
        {    
            listaArticulos[0] = articulo;   
            return ""+articulo.Nombre+" se ha modificado correctamente.";
        }
        
        public string Eliminar(Articulo articulo)
        {
            listaArticulos.Remove(articulo);
            return "" + articulo.Nombre + " se ha eliminado correctamente.";
        }

        public List<Articulo> Listar()
        {
            return listaArticulos;
        }
    }
    
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }

    public class RepositorioCategorias
    {
        public List<Categoria> listaCategorias;

        public RepositorioCategorias()
        {
            listaCategorias= new List<Categoria>();
        }

        public string Agregar(Categoria categoria)
        {
            listaCategorias.Add(categoria);
            return "" + categoria.Nombre + " se ha agregado correctamente.";
        }

        public string Modificar(Categoria categoria)
        {
            return "" + categoria.Nombre + " se ha modificado correctamente.";
        }

        public string Eliminar(Categoria categoria)
        {
            listaCategorias.Remove(categoria);
            return "" + categoria.Nombre + " se ha eliminado correctamente.";
        }

        public List<Categoria> Listar()
        {
            return listaCategorias;
        }
    }
}

