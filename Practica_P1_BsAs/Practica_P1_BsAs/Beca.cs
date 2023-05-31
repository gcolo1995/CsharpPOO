using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_P1_BsAs
{
    internal class Beca
    {
        private DateTime _fechaOtrorg;
        private string _codigo;
        private decimal _importe;       //porque es un porcentaje de la cuota, no debe ser mayor que 1 (100% de la cuota)

        public DateTime FechaOtorg { get => _fechaOtrorg; set => _fechaOtrorg = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public decimal Importe { get => _importe; set => _importe = value; }

    }
}
