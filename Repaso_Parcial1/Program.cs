using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Se solicita el desarrollo de una aplicacion que permita la registracion de jugadores a un equipo de futbol
la aplicacion debera registrar 3 arqueros, 6 defensores, 5 mediocampistas y 4 delanteros.por cada arquero, nombre, apellido, fecha de nacimiento, edad, y altura.
Se solicitara por cada defensor, nombre, apellido, fecha de nacimiento, edad, y cantidad de tarjetas amarillas y rojas.
Se solicitara por cada mediocampista, nombre, apellido, fecha de nacimiento, edad, y cantidad de asistencias.
Se solicitara por cada delantero, nombre, apellido, fecha de nacimiento, edad, y cantidad de goles.
Se desea visualizar un listado con todos los jugadores.
Se deberá validar que no se carguen mas jugadores de la cantidad solicitada.
*/
namespace Repaso_Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo();

            Console.WriteLine("Ingrese el nombre del equipo:");
            equipo.Nombre = Console.ReadLine();

            int opcionMenu = 1;
            do
            {
                opcionMenu = MostrarMenu();
                EjecutarOpcion(opcionMenu, equipo);

                
                //var mensaje = equipo.RegistrarJugador();
                //Console.WriteLine(mensaje);
            } while (opcionMenu != 9);

                Console.ReadKey();
                   

        }

        private static int MostrarMenu()
        {
            Console.WriteLine("Ingrese la opción a realizar: \n 1 - Agregar jugador" +
                "\n 2 - Borrar Jugador \n 3 - Modificar Jugador \n 4 - Listar equipo" +
                "\n 9 - SALIR");

            return Convert.ToInt32(Console.ReadLine());

        }

        private static void EjecutarOpcion(int opcion, Equipo equipo)
        {
            int posicion = 1;
            switch(opcion)
            {
                case 1:                     //agregar
                    do
                    {
                        Console.WriteLine("Indicar la posición a cargar:" +
                            "\n 1 - Arquero\t 2 - Defensor\t 3 - Mediocampista\t 4 - Delantero");
                        posicion = Convert.ToInt32(Console.ReadLine());
                    } while (posicion < 1 || posicion > 4);

                    
                    Console.WriteLine(equipo.RegistrarJugador(AgregarPosicion(posicion)));
                    break;
                    
                /*case 2:
                    break;
                case 3:
                    break;
                */case 4:
                    do
                    {
                        Console.WriteLine("Indicar la posición a listar:" +
                            "\n0 - Todos \t 1 - Arquero\t 2 - Defensor\t 3 - Mediocampista\t 4 - Delantero");
                        posicion = Convert.ToInt32(Console.ReadLine());
                    } while (posicion < 0 || posicion > 4);

                    ListarPosicion(posicion, equipo);

                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Código erróneo");
                    break;



            }


        }

        private static Jugador PedirDatosComunes()
        {
            var jugador = new Jugador();

            Console.WriteLine("Ingrese el nombre: ");
            jugador.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            jugador.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            jugador.FechaNac = Convert.ToDateTime(Console.ReadLine());

            return jugador;
        }

        public static void ListarPosicion(int opcion, Equipo equipo)
        {
            switch(opcion)
            {
                case 0:
                    Console.WriteLine(string.Join("\n", equipo.ListarCompleto()));
                    break;
                case 1:
                    Console.WriteLine(string.Join("\n", equipo.ListarArqueros()));
                    break;
                case 2:
                    Console.WriteLine(string.Join("\n", equipo.ListarDefensores()));
                    break;
                case 3:
                    Console.WriteLine(string.Join("\n", equipo.ListarMedioCampistas()));
                    break;
                case 4:
                    Console.WriteLine(string.Join("\n", equipo.ListarDelanteros()));
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }
        }
        public static Jugador AgregarPosicion(int opcion) 
        {
            switch (opcion)
            {
                case 1:                                         //arquero
                    Arquero arquero = new Arquero();
                    Console.WriteLine("Ingrese el nombre: ");
                    arquero.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido: ");
                    arquero.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento: ");
                    arquero.FechaNac = Convert.ToDateTime(Console.ReadLine());


                    Console.WriteLine("Indique la altura:");
                    arquero.Altura = Convert.ToDouble(Console.ReadLine());

                    return arquero;
                case 2:                                         //defensor
                    Defensor defensor = new Defensor();
                    Console.WriteLine("Ingrese el nombre: ");
                    defensor.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido: ");
                    defensor.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento: ");
                    defensor.FechaNac = Convert.ToDateTime(Console.ReadLine());


                    Console.WriteLine("Indique la cantidad de amarillas");
                    defensor.TarjAmarillas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique la cantidad de rojas");
                    defensor.TarjRojas = Convert.ToInt32(Console.ReadLine());
                    
                    return defensor;
                case 3:                                         //mediocampista
                    Mediocampista mediocamp = new Mediocampista();
                    Console.WriteLine("Ingrese el nombre: ");
                    mediocamp.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido: ");
                    mediocamp.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento: ");
                    mediocamp.FechaNac = Convert.ToDateTime(Console.ReadLine());



                    Console.WriteLine("Indique la cantidad de asistencias");
                    mediocamp.CantAsist = Convert.ToInt32(Console.ReadLine());
                    
                    return mediocamp;
                case 4:                                         //delantero
                    Delantero delantero = new Delantero();
                    Console.WriteLine("Ingrese el nombre: ");
                    delantero.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido: ");
                    delantero.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento: ");
                    delantero.FechaNac = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Indique la cantidad de goles");
                    delantero.CantGoles = Convert.ToInt32(Console.ReadLine());
                    
                    return delantero;
                default:
                    Console.WriteLine("Opción inválida");
                    return null;

            }
        }

    }
}
