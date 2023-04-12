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

            /*Console.WriteLine("¿Desea dar de alta una cuenta?");
            if(Console.ReadLine().ToUpper() == "SI") 
            {
                CajaAhorro miCajaAhorro = new CajaAhorro();            
            }*/
            
            CajaAhorro miCajaAhorro = new CajaAhorro();

            Console.WriteLine("Ingrese el titular de la cuenta");
            miCajaAhorro.Titular = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de la cuenta");
            miCajaAhorro.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la moneda de la cuenta");
            miCajaAhorro.TipoMoneda = Console.ReadLine().ToUpper();

            int opcion = 1;
            while(opcion != 9)
            {
                do
                {
                    Console.WriteLine("Ingrese el número de la operación que desea realizar" +
                    "\n \t 1 - Consultar Saldo \n \t 2 - Depositar \n \t 3 - Extraer dinero \n \t 4 -" +
                    " Consultar datos de la cuenta \n \t 9 - Salir");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion == 1 && opcion == 2 && opcion == 3 && opcion == 9 && opcion == 4);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El saldo de su caja de ahorro es $" + miCajaAhorro.Saldo + ".");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a depositar");
                        int deposito = int.Parse(Console.ReadLine());
                        miCajaAhorro.Depositar(deposito);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto a extraer");
                        int extraccion = int.Parse(Console.ReadLine());
                        Console.WriteLine(miCajaAhorro.Extraer(extraccion));
                        break;
                    case 4:
                        Console.WriteLine("Los datos de su cuenta son: \n \tTitular: " + miCajaAhorro.Titular + "" +
                            "\n \tNúmero de Cuenta: " + miCajaAhorro.Numero + " \n \tTipo: CA " + miCajaAhorro.TipoMoneda + "");
                        break;
                    case 9:
                        break;
                }
            }
            Console.WriteLine("Gracias por operar con nosotros.");

            Console.ReadKey();
        }
    }
}
