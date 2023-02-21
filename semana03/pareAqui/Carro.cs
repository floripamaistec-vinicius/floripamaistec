using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pareAqui
{
    public class Carro
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string marca { get; set; }
        public List<Ticket> listTicket { get; set; }
        public Carro() {
            listTicket = new List<Ticket>();
        }
        public Carro(string Placa, string Modelo, string Cor, string Marca) :this()
        {
            placa = Placa;
            modelo = Modelo;
            cor = Cor;
            marca = Marca;
        }
    }
}
