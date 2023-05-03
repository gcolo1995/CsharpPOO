using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5
{
    public partial class Form1 : Form
    {
        private Curso curso;  //declaré un objeto curso, para tener visibilidad al objeto curso
        //aca no se declara private Alumno alumno para que los objetos sean locales

        public Form1()
        {
            InitializeComponent();
            curso = new Curso();      //instancio el objeto curso declarado
            //lo instancio en el constructor para que se creeal abrir el Form1
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();   //declaro e instancio aca para que el objeto sea local
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.NroLegajo = Convert.ToInt32(txtLegajo.Text);
            //alumno.NroLegajo = int.TryParse(txtLegajo.Text,out );  ver como funciona
            curso.AgregarAlumno(alumno);
        }
    }
}
