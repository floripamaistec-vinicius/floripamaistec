using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pareAqui
{
    public class Ticket
    {
        public DateTime entrada { get; set; }
        public DateTime saida { get; set; }
        public bool ativo { get; set; }

        public Ticket() { }
        public Ticket(DateTime Entrada, DateTime Saida, bool Ativo) :this()
        {
            entrada = Entrada;
            saida = Saida;
            ativo = Ativo;
        }
        public double CalcularTempo()
        {
            TimeSpan tempo = saida - entrada;
            return tempo.TotalMinutes;
        }
        public double CalcularValor()
        {
            double valor = CalcularTempo() * 0.09;
            return valor;
        }
    }
}
