using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colombano_POO_Parcial1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Colectivo miColectivo = new Colectivo();
            int opcion = 1;

            do
            {
                opcion = MenuOpciones(opcion);

                var mensaje = OpcionEegida(opcion, miColectivo);
                Console.WriteLine(mensaje);
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 5);

            Console.WriteLine("Muchas gracias por operar con nosotros");
            Console.ReadKey();


        }

        private static int MenuOpciones(int opcion)
        {
            int opciones = 1;
            do
            {
                Console.WriteLine("Ingrese la opción a realizar: \n1- Agregar Pasajero \n2- Listar pasajeros" +
                    "\n3- Ver el monto recaudado \n4- Ver la cantidad de pasajes vendidos \n5- Salir");
                opciones = Convert.ToInt32(Console.ReadLine());
            } while (opciones < 0 || opciones > 5);

            return opciones;
        }

        private static string OpcionEegida(int opcion, Colectivo miColectivo)
        {
            string mensaje ="";
            if (opcion == 1)        //agregar
            {
                int tipoPasajero = 0;

                do
                {
                    Console.WriteLine("Si es estudiante marque 1 \nSi es jubilado marque 2 \nSi no es ninguno de ambos marque 0");
                    tipoPasajero = Convert.ToInt32(Console.ReadLine());
                } while (tipoPasajero < 0 || tipoPasajero > 2);

                if (tipoPasajero == 0)
                {
                    var pasajero = new Pasajero();
                    Console.WriteLine("Ingrese el Nombre: ");
                    pasajero.Nombre = Console.ReadLine();
                    Console.WriteLine("Igrese el Apellido: ");
                    pasajero.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI: ");
                    pasajero.Dni = Convert.ToInt32(Console.ReadLine());

                    mensaje = miColectivo.AgregarPasajero(pasajero);

                }
                else if (tipoPasajero == 1)
                {
                    var pasajero = new Estudiante();
                    Console.WriteLine("Ingrese el Nombre: ");
                    pasajero.Nombre = Console.ReadLine();
                    Console.WriteLine("Igrese el Apellido: ");
                    pasajero.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI: ");
                    pasajero.Dni = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la institución a la que asiste: ");
                    pasajero.Institucion = Console.ReadLine();
                    Console.WriteLine("Ingrese el legajo en su institución: ");
                    pasajero.NroLegajo = Convert.ToInt32(Console.ReadLine());

                    mensaje = miColectivo.AgregarPasajero(pasajero);

                }
                else if (tipoPasajero == 2)
                {
                    var pasajero = new Jubilado();
                    Console.WriteLine("Ingrese el Nombre: ");
                    pasajero.Nombre = Console.ReadLine();
                    Console.WriteLine("Igrese el Apellido: ");
                    pasajero.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI: ");
                    pasajero.Dni = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el número de Afiliado en PAMI: ");
                    pasajero.NroAfiliaroPAMI = Convert.ToInt32(Console.ReadLine());

                    mensaje = miColectivo.AgregarPasajero(pasajero);

                }
            }
            else if (opcion == 2 )
            {
                string pasajerosConcatenados = string.Join("\n", miColectivo.ListarPasajeros());
                List<string> pasajerosLista = pasajerosConcatenados.Split('\n').ToList();


                return pasajerosConcatenados;
                //solo me falta convertir la informacion concatenada a listado, pero no se como hacerlo
            }            
            else if (opcion == 3)
            {
                mensaje = "Se recaudaron $" + miColectivo.TotalRecaudado + ".";
            }
            else if (opcion == 4)
            {
                mensaje = "Se vendieron " + miColectivo.ContPasajeros + " pasajes";
            }
            else if (opcion == 5 )
            {
                mensaje =  "El programa se finalizará.";
            }
            return mensaje;

        }
        

    }
}
