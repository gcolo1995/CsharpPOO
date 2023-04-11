using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto_TV
{
    public class Televisor
    {
        private int _ano;
        private string _marca;
        private int _pulgadas;
        private int _volumen;
        private int _canal;

        public void SubirVolumen()
        {
            _pulgadas += 1;
        }
        public void BajarVolumen()
        {
            _pulgadas -= 1;
        }
        public void SubirCanal()
        {
            _canal += 1;
        }
        public void BajarCanal()
        {
            _canal -= 1;
        }

    }
}
