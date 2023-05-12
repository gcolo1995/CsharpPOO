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


            var mensaje = equipo.Agregar();
            Console.WriteLine(mensaje);
            Console.ReadKey();


        

        }
    }
}
