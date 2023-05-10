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

            
            pasajero.Nombre = "Gabriel";
            pasajero.Apellido = "Batistuta";
            pasajero.Edad = 25;

            estudiante.Institucion = "UAI";
            estudiante.NroLegajo = 1;
            estudiante.Nombre = "Lionel";

            Console.WriteLine("Nombre "+ estudiante.Nombre +" " + estudiante.Apellido + "");
            Console.ReadKey();

        }
    }
}
