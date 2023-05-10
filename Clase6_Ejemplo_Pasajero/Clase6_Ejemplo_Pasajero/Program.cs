using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6_Ejemplo_Pasajero
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Pasajero pasajero = new Pasajero();
            Estudiante estudiante = new Estudiante();
                        
            
            Colectivo colectivo = new Colectivo();
            estudiante.Nombre = "Gabriel";
            estudiante.Apellido = "Batistuta";
            estudiante.Edad = 25;
            estudiante.Institucion = "UAI";
            estudiante.NroLegajo = 1;

            colectivo.VenderBoleto(estudiante);

            colectivo.VenderBoleto(estudiante);


            Console.ReadKey();

        }
    }
}
