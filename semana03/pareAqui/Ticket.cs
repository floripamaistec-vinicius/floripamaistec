using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pareAqui
{
    public class Ticket
    {
        DateTime _entrada { get; set; }
        DateTime _saida { get; set; }
        bool _ativo { get; set; }

        public Ticket() {
            
        }
        public Ticket(DateTime Entrada, DateTime Saida, bool Ativo) {
            this._entrada = Entrada;
            this._saida = Saida;
            this._ativo = Ativo;
        }
        private double CalcularTempo()
        {
            TimeSpan _tempo = _saida - _entrada;
            return _tempo.TotalMinutes;
        }
    }
}
