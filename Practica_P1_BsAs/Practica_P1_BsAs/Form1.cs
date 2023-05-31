using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_P1_BsAs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAltaAlumno_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno();
            //alumno.Dni = MessageBox.Show("Ingrese Nombre", );
        }
    }
}
