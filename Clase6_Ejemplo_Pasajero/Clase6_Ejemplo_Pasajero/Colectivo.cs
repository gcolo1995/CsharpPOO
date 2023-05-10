using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6_Ejemplo_Pasajero
{
    internal class Colectivo
    {
        List<Pasajero> pasajeros;

        public Colectivo()
        {
            pasajeros = new List<Pasajero>();

                        
        }

        public void VenderBoleto(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }
        /*public void MostrarListado()
        {
            MessageBox.Show(" " + Pasajero.Nombre + "");
        }*/
    }
}
