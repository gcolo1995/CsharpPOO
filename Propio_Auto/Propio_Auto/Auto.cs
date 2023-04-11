using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propio_Auto
{
    internal class Auto
    {
        private string _marca;
        private string _modelo;
        private int _velocidad;
        private int _ano;

        public string Marca
        {                                         
            get { return _marca; }
            set { _marca = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public int Velocidad
        {
            get { return _velocidad; }
            set { _velocidad = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }


        public void Acelerar()
        {
            _velocidad++;
        }
        public void Acelerar(int velocidad)
        {
            _velocidad += velocidad;
        }
        public void Desacelerar()
        {
            if (_velocidad >= 0) _velocidad--;
        }



    }
}
