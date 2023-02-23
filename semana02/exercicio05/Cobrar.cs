using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    public class Cobrar
    {
        private decimal _valor { get; set; }
        private decimal _multa { get; set; }
        public Cobrar(decimal valor, decimal multa)
        {
            this._valor = valor;
            this._multa = multa;
        }
        private decimal CalcularMulta()
        {
            return (_valor + _multa);
        }
        public void Calcular()
        {
            Console.WriteLine("Valor cobrado {0}, Multa {1}, Soma Valor {2}", _valor, _multa, CalcularMulta());
        }
    }
}
