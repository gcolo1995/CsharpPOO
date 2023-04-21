using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3MiCaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CajaAhorro PrimerCA = new CajaAhorro();
            Titular PrimerTitular = new Titular();

            Console.WriteLine("Ingrese el Nombre: ");
            PrimerTitular.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido: ");
            PrimerTitular.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI:");
            PrimerTitular.Dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el teléfono: ");
            PrimerTitular.Telefono = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el sexo: ");
            var genero = Console.ReadLine();
            if (Enum.TryParse(genero, out Genero sexo))
            {
                PrimerTitular.Sexo = sexo; 
            }   

            
            Console.WriteLine("Ingrese la fecha de nacimiento (DD/MM/AAAA)");
            PrimerTitular.FechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("La edad del cliente es de "+ PrimerTitular.Edad +" años.");

            /*
            Console.WriteLine("Ingrese la fecha de nacimiento (DD/MM/AAAA)");
            PrimerTitular.FechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("La edad del cliente es de "+ PrimerTitular.CalcularEdad()+" años.");
            */

            PrimerCA.TitularCta = PrimerTitular;

            Console.WriteLine("El nombre del titular es " + PrimerCA.TitularCta.Nombre + "");

            Console.ReadKey();
        }
    }
}
