using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Colombano_POO_Parcial1
{
    internal class Colectivo
    {
        private string _marca;
        private string _modelo;
        private int _anoFabricacion;
        private int _capacidadMaxima;           //si bien se indica que la cap max es 40, en otro modelo podria ser mayor
        private List<Pasajero> pasajeros;
        private int _contPasajeros;
        private int _totalRecaudado;
        private int _costoBoleto;       //considero que dependiendo el viaje será el valor del boleto. No se define por el colectivo, sino por el viaje




        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }    
        public int AnoFabricacion { get => _anoFabricacion; set => _anoFabricacion = value; }

        public int CapacidadMaxima { get => _capacidadMaxima; set => _capacidadMaxima = value; }

        public int ContPasajeros { get => _contPasajeros; }
        public int TotalRecaudado { get => _totalRecaudado; }

        public Colectivo ()     //el enunciado no pide que se carguen los datos del colectivo, preestablesco valores por defecto
        {
            Marca = "MarcoPolo";
            Modelo = "Linea Urbana";
            AnoFabricacion = 2022;
            CapacidadMaxima = 40;       //viene determinado por el ejercicio
            pasajeros = new List<Pasajero>();
            _contPasajeros = 0;
            _totalRecaudado = 0;
            _costoBoleto = 100;         //pongo como costo del pasaje los $100
        }


        public string AgregarPasajero(Pasajero pasajero)
        {
            if (_contPasajeros >= _capacidadMaxima)       //valida la capacidad máxima
            {
                return "Se alcanzó la capacidad máxima. No se podrá sumar otro pasajero.";
            }
            else
            {
                if (BuscarDNI(pasajero.Dni) == pasajero.Dni)        //valida que no se duplique el DNI
                {
                    return "DNI DUPLICADO \nEl pasajero " + pasajero.Nombre + " " + pasajero.Apellido + " se había cargado previamente";
                }
                else
                {
                    if (pasajero is Estudiante)
                    {
                        _totalRecaudado += (_costoBoleto / 2);
                        pasajeros.Add(pasajero);
                        _contPasajeros++;
                        return "El estudiante " + pasajero.Nombre + " " + pasajero.Apellido + " se ha ingresado";

                    }
                    if (pasajero is Jubilado)
                    {
                        _totalRecaudado += (_costoBoleto * 0);
                        pasajeros.Add(pasajero);
                        _contPasajeros++;
                        return "El jubilado " + pasajero.Nombre + " " + pasajero.Apellido + " se ha ingresado";
                    }
                    else
                    {
                        _totalRecaudado += _costoBoleto;
                        pasajeros.Add(pasajero);
                        _contPasajeros++;
                        return "El pasajero " + pasajero.Nombre + " " + pasajero.Apellido + " se ha ingresado";
                    }
                }
            }
        }


        public int BuscarDNI(int dni)      //valida que no se duplique el DNI
        {
            var buscado = pasajeros.FirstOrDefault(b => b.Dni == dni);
            if (buscado == null)
                return 0;
            return buscado.Dni;


        }

        public ReadOnlyCollection<Pasajero> ListarPasajeros()       //muestra el listado de pasajeros
        {
            return pasajeros.AsReadOnly();
        }




    }
}
