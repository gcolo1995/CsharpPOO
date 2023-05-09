using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_Forms_ObjetosyClases_Ej1
{
    public partial class Principal : Form
    {
        private Inventario productos;
        public Principal()
        {
            InitializeComponent();
            productos = new Inventario();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CompletarDatagrid();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDouble(Math.Round(numPrecio.Value,2));
            /*     no me funcionó                   //uso de tryparse 
            bool conversionOk = true;               //boolean para entrar en el do/while
            do                                      //nombre del boolean = tipo de dato que quiero + . + TryParse
            {                                       //+(lugar donde se carga el dato.ToString() + , + out + declaro una variable que almacene el dato correcto
                conversionOk = double.TryParse(numPrecio.Value.ToString(), out double valorPrecio);
                if (conversionOk)                   //condicional si la conversión funcionó
                    producto.Precio = valorPrecio;  //asigno el dato correcto en mi clase
            } while (conversionOk);                 //para que no salga del do hasta que funcione
            */
            producto.Cantidad = Convert.ToInt32(numCantidad.Value);

            productos.AgregarProducto(producto);
            CompletarDatagrid();
            LimpiarCajas();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CompletarDatagrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = productos.ListarInventario();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDouble(Math.Round(numPrecio.Value, 2));
            producto.Cantidad = Convert.ToInt32(numCantidad.Value);

            productos.BorrarProducto(producto);

            LimpiarCajas();
            CompletarDatagrid();
            
        }
        public void LimpiarCajas()
        {
            txtNombre.Text = String.Empty;
            numPrecio.Value = 0;
            numCantidad.Value = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            numPrecio.Value = (decimal)Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value);
            numCantidad.Value = (int)dataGridView1.CurrentRow.Cells[2].Value;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto productoModif = new Producto();
            productoModif.Nombre = txtNombre.Text;
            productoModif.Precio = Convert.ToDouble(Math.Round(numPrecio.Value, 2));
            productoModif.Cantidad = Convert.ToInt32(numCantidad.Value);

            Producto productoAnterior = new Producto();
            productoAnterior.Nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            productoAnterior.Precio = Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value);
            productoAnterior.Cantidad = (int)dataGridView1.CurrentRow.Cells[2].Value;

            productos.ModificarProducto(productoAnterior, productoModif);

            LimpiarCajas();
            CompletarDatagrid();
        }
    }
}
