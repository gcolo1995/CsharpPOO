using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_de_Ahorro
{
    public class CajaAhorro
    {
        #region ATRIBUTOS
        private int _numero;
        private string _tipoMoneda;
        private int _saldo = 0;
        private string _titular;
        #endregion 

        #region PROPIEDADES
        public int Numero
        {                
            get { return _numero; }
            set { _numero = value; }
        }

        public string TipoMoneda
        {
            get { return _tipoMoneda; }
            set { _tipoMoneda = value; }
        }

        public int Saldo
        {
            get { return _saldo; }
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        #endregion

        #region METODOS
        public void Depositar(int monto)
        {
            _saldo += monto;
        }

        public string Extraer(int monto)
        {
            if (_saldo >= monto)
            {
                _saldo -= monto;
                return "Se han extraido $ "+monto+". El nuevo saldo de su cuenta es de $ "+_saldo+"."; 
            }
            else
                return "No dispone de fondos suficientes";
        }
        #endregion
    }
}
