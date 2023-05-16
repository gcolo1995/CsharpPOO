using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Parcial1
{
    internal class Equipo
    {
        private string _nombre;
        private List<Jugador> jugadores;
        private int _cantArqueros = 0;
        private int _cantMaxArqueros = 3;
        private int _cantDefensores = 0;
        private int _cantMaxDefensores = 6; 
        private int _cantMediocampistas = 0;
        private int _cantMaxMediocampistas = 5;
        private int _cantDelanteros = 0;
        private int _cantMaxDelanteros = 4;



        public string Nombre { get => _nombre; set => _nombre = value; }

        public Equipo()
        {
            jugadores = new List<Jugador>();
        }


        /*public string AgregarJugador()
        {
            if (_cantJugadores < _cantMaxima)
            {
                Console.WriteLine("Indique la posición: \n 1 - Arquero \t 2 - Defensor" +
                    "\t 3 - Mediocampista \t 4 - Delantero");
                var opcion = Convert.ToInt32(Console.ReadLine());

                Jugador nuevo = new Jugador();
                jugadores.Add(IndicarPoscion)




                var nuevo = PedirJugador();
                jugadores.Add(nuevo);   //debo revisar la validacion
                _cantJugadores++;
                return "" + nuevo.Nombre + " " + nuevo.Apellido + " cargado correctamente";

            }
            else
            {
                return "Equipo completo, debe eliminar un jugador antes.";
            }


        }*/

        public void MostrarListado()
        {
            Console.WriteLine("\tNombre \tApellido \tEdad");
            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine("" + jugador.Nombre + " " + jugador.Apellido + " " + jugador.Edad + "\n");
            }

        }



        public string RegistrarJugador(Jugador jugador)
        {
            if (jugador is Arquero)
            {
                if (_cantMaxArqueros > _cantArqueros)
                {
                    jugadores.Add(jugador);
                    _cantArqueros++;
                    return $"El arquero {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas arqueros";
            }
            else if (jugador is Defensor)
            {
                if (_cantMaxDefensores > _cantDefensores)
                {
                    jugadores.Add(jugador);
                    _cantDefensores++;
                    return $"El defensor {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas defensores";
            }
            else if (jugador is Mediocampista)
            {
                if (_cantMaxMediocampistas > _cantMediocampistas)
                {
                    jugadores.Add(jugador);
                    _cantMediocampistas++;
                    return $"El mediocampista {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas mediocampistas";
            }
            else
            {
                if (_cantMaxDelanteros > _cantDelanteros)
                {
                    jugadores.Add(jugador);
                    _cantDelanteros++;
                    return $"El delantero {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas delanteros";
            }
        }

        public ReadOnlyCollection<Jugador> ListarCompleto()
        {
            return jugadores.AsReadOnly();
        }

        public ReadOnlyCollection<Arquero> ListarArqueros()
        {
            return jugadores.OfType<Arquero>().ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Defensor> ListarDefensores()
        {
            return jugadores.OfType<Defensor>().ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Mediocampista> ListarMedioCampistas()
        {
            return jugadores.OfType<Mediocampista>().ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Delantero> ListarDelanteros()
        {
            return jugadores.OfType<Delantero>().ToList().AsReadOnly();
        }




        /*public Arquero AgregarArquero()
        {
            var nuevo = new Arquero();      

            Console.WriteLine("Ingrese el nombre: ");
            nuevo.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            nuevo.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            nuevo.FechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Indique la altura:");
            var altura = Convert.ToDouble(Console.ReadLine());

            return nuevo;
        }
        public Defensor AgregarDefensor()
        {
            var nuevo = new Defensor();      

            Console.WriteLine("Ingrese el nombre: ");
            nuevo.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            nuevo.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            nuevo.FechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Indique la cantidad de amarillas");
            var amarillas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la cantidad de rojas");
            var rojas = Convert.ToInt32(Console.ReadLine());

            return nuevo;
        }
        public Mediocampista AgregarMediocampista()
        {
            var nuevo = new Mediocampista();      

            Console.WriteLine("Ingrese el nombre: ");
            nuevo.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            nuevo.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            nuevo.FechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Indique la cantidad de asistencias");
            var asistencias = Convert.ToInt32(Console.ReadLine());

            return nuevo;
        }
        public Delantero AgregarDelantero()
        {
            var nuevo = new Delantero();      

            Console.WriteLine("Ingrese el nombre: ");
            nuevo.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            nuevo.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            nuevo.FechaNac = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Indique la cantidad de goles");
            var goles = Convert.ToInt32(Console.ReadLine());

            return nuevo;
        }
        */









    }
}

