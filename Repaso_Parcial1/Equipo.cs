using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Parcial1
{
    internal class Equipo
    {
        List<Jugador> jugadores;
        private int _cantJugadores = 0;
        private int _cantMaxima = 2;

        public int CantJugadores { get { return _cantJugadores; } }
        public Equipo()
        {
            jugadores = new List<Jugador>();
        }


        public string Agregar()
        {
            if (_cantJugadores < _cantMaxima)
            {
                var nuevo = PedirJugador();
                jugadores.Add(nuevo);   //debo revisar la validacion
                _cantJugadores++;
                return "" + nuevo.Nombre + " " + nuevo.Apellido + " cargado correctamente";

            }
            else
            {
                return "Equipo completo, debe eliminar un jugador antes.";
            }


        }

        public void MostrarListado()
        {
            Console.WriteLine("\tNombre \tApellido \tEdad");
            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine("" + jugador.Nombre + " " + jugador.Apellido + " " + jugador.Edad + "\n");
            }

        }

        public Jugador PedirJugador() //debo plantear mejor como cargar los datos
        {
            var nuevo = new Jugador();

            Console.WriteLine("Ingrese el nombre: ");
            nuevo.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            nuevo.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            nuevo.FechaNac = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese la posición");
            var opcion = Convert.ToInt32(Console.ReadLine());
            IndicarPosicion(opcion, nuevo);

            Console.WriteLine("" + nuevo.Nombre + " " + nuevo.Apellido + " tiene " + nuevo.Edad + " años.");

            return nuevo;

        }
        public Jugador IndicarPosicion(int opcion, Jugador datos) //debo repensarlo
        {
            switch (opcion)
            {
                case 1:                                         //arquero
                    Console.WriteLine("Indique la altura:");
                    var altura = Convert.ToDouble(Console.ReadLine());
                    Arquero arquero = new Arquero(altura);
                    return arquero;
                case 2:                                         //defensor
                    Console.WriteLine("Indique la cantidad de amarillas");
                    var amarillas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique la cantidad de rojas");
                    var rojas = Convert.ToInt32(Console.ReadLine());
                    Defensor defensor = new Defensor(amarillas, rojas);
                    return defensor;
                case 3:                                         //mediocampista
                    Console.WriteLine("Indique la cantidad de asistencias");
                    var asistencias= Convert.ToInt32(Console.ReadLine());
                    Mediocampista mediocamp = new Mediocampista(asistencias);
                    return mediocamp;
                case 4:                                         //delantero
                    Console.WriteLine("Indique la cantidad de goles");
                    var goles = Convert.ToInt32(Console.ReadLine());
                    Delantero delantero= new Delantero(goles);
                    return delantero;
                default:
                    Console.WriteLine("Código erróneo");
                    break;

            }
        }
         
    }
}

