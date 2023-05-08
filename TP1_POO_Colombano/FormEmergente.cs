using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_POO_Colombano
{
    public partial class FormEmergente : Form
    {
        //private static int ContadorLegajo = 1;
        public ListadoAlumno listaEmerg;

        public FormEmergente()
        {
            
            InitializeComponent();
            
            lblLegajo.Text = "Pendiente";
            numericUpDown1.Maximum = 36;     //el enunciado indica que son 36 materias
            dateNacimiento.MaxDate = DateTime.Today;
            dateIngreso.MaxDate = DateTime.Today;
            dateIngreso.MinDate = dateNacimiento.Value;

        }
        public FormEmergente(Alumno alumno)
        {
            InitializeComponent();
            
            lblLegajo.Text = alumno.Legajo.ToString();
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            dateNacimiento.Value = alumno.FechaNacimiento;
            dateIngreso.Value = alumno.FechaIngreso;
            numericUpDown1.Value = (36 - alumno.CalcularMateriasNoAprob());

            numericUpDown1.Maximum = 36;        //el enunciado indica que son 36 materias
            dateNacimiento.MaxDate = DateTime.Today;
            dateIngreso.MaxDate = DateTime.Today;
            dateIngreso.MinDate = dateNacimiento.Value;

        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno();

            Principal formPrincipal = (Principal)this.Owner;
            
            if (formPrincipal.lista.BuscarNombreApellidoNac(txtNombre.Text, txtApellido.Text, dateNacimiento.Value) != null)
            {
                MessageBox.Show("El alumno ya se encontraba cargado \n" +
                        "con el legajo nº " + formPrincipal.lista.BuscarNombreApellidoNac(txtNombre.Text, txtApellido.Text, dateNacimiento.Value) + ".");


                
            }
            else
            {
                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.FechaNacimiento = dateNacimiento.Value;
                alumno.FechaIngreso = dateIngreso.Value;
                alumno.CantAprobadas = (int)numericUpDown1.Value;
                //alumno.Legajo = ContadorLegajo;
                formPrincipal.lista.AgregarAlumno(alumno);

                MessageBox.Show("Alumno cargado.\n Número de legajo " + alumno.Legajo + ".");
                //ContadorLegajo++;
                this.DialogResult = DialogResult.OK;
            }
        this.Close();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acción cancelada.");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
