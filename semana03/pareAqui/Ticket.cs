using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pareAqui
{
    public class Ticket
    {
        public DateTime _entrada { get; set; }
        public DateTime _saida { get; set; }
        public bool _ativo { get; set; }

        public Ticket() { }
        public Ticket(DateTime Entrada, DateTime Saida, bool Ativo) :this() {
            _entrada = Entrada;
            _saida = Saida;
            _ativo = Ativo;
        }
        public double CalcularTempo()
        {
            TimeSpan _tempo = _saida - _entrada;
            return _tempo.TotalMinutes;
        }
        public double CalcularValor()
        {
            double _valor = CalcularTempo() * 0.09;
            return _valor;
        }
    }
}
