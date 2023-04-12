using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_de_Ahorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CajaAhorro miCajaAhorro = new CajaAhorro();

            Console.WriteLine("Ingrese el monto a depositar");            
            int deposito = int.Parse(Console.ReadLine());
            miCajaAhorro.Depositar(deposito);

            Console.WriteLine("Ingrese el monto a extraer");
            int extraccion = int.Parse(Console.ReadLine());           
            Console.WriteLine(miCajaAhorro.Extraer(extraccion));

            Console.ReadKey();
        }

    }
}
