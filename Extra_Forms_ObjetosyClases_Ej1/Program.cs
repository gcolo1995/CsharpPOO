using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_Forms_ObjetosyClases_Ej1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Creando un proyecto WinForms, usando DataGridView, Label, TextBox y Botón Agregar.
             * Crear una clase "Producto" con los atributos "nombre", "precio" y "cantidad". 
             * Crear otra clase "Inventario" que contenga una lista de objetos "Producto". 
             * Crear un constructor para la clase "Producto" que reciba los tres atributos.*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
