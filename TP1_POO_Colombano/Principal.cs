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
    public partial class Principal : Form
    {
        
        public ListadoAlumno lista = new ListadoAlumno();

        
        public Principal()
        {
            InitializeComponent();
            ListadoAlumno lista = new ListadoAlumno();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CompletarDatagrid();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormEmergente Alta = new FormEmergente();
            if (Alta.ShowDialog() == DialogResult.OK);
            {
                lista.AgregarAlumno(Alta.miAlumno);
                CompletarDatagrid();
            }

            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int legajo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Alumno alumno = lista.BuscarLegajo(legajo);
                FormEmergente Modifica = new FormEmergente(alumno);
                Modifica.ShowDialog();
                CompletarDatagrid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int legajo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var alumno = lista.BuscarLegajo(legajo);
            txtAntiguedad.Text = alumno.CalcularAntiguedad(unidadAntiguedad.Text).ToString();
            txtMateriasNoAprob.Text = alumno.CalcularMateriasNoAprob().ToString();
        }
        private void CompletarDatagrid()
        {
            this.dataGridView1.DataSource = null;
            //this.dataGridView1.DataSourse = lista.ListarAlumnos();

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int legajo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                MessageBox.Show(lista.QuitarAlumno(legajo));
                CompletarDatagrid();
            }
        }
    }
}
