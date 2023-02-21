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
        public Cobrar(decimal Valor, decimal Multa)
        {
            this._valor = Valor;
            this._multa = Multa;
        }
        private decimal CalcularMulta()
        {
            decimal SomaValor = (_valor + _multa);
            return SomaValor;
        }
        public void Calcular()
        {
            Console.WriteLine("Valor cobrado {0}, Multa {1}, Soma Valor {2}", _valor, _multa, CalcularMulta());
        }
    }
}
