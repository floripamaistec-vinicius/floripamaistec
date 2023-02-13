using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    public class Cobrar
    {
        private decimal Valor { get; set; }
        private decimal Multa { get; set; }
        public Cobrar(decimal Valor, decimal Multa)
        {
            this.Valor = Valor;
            this.Multa = Multa;
        }
        private decimal CalcularMulta()
        {
            decimal SomaValor = (Valor + Multa);
            return SomaValor;
        }
        public void Calcular()
        {
            Console.WriteLine("Valor cobrado {0}, Multa {1}, Soma Valor {2}", Valor, Multa, CalcularMulta());
        }
    }
}
