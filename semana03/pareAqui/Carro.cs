using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pareAqui
{
    public class Carro
    {
        public string _placa { get; set; }
        public string _modelo { get; set; }
        public string _cor { get; set; }
        public string _marca { get; set; }
        public List<Ticket> _ticketList { get; set; }
        public Carro() {
            _ticketList = new List<Ticket>();
        }
        public Carro(string Placa, string Modelo, string Cor, string Marca) :this()
        {
            _placa = Placa;
            _modelo = Modelo;
            _cor = Cor;
            _marca = Marca;
        }
    }
}
