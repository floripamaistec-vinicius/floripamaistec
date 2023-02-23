using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pareAqui
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public List<Ticket> listaDeTickets { get; set; }
        public Carro() {
            listaDeTickets = new List<Ticket>();
        }
        public Carro(string placa, string modelo, string cor, string marca) :this()
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;
            Marca = marca;
        }
    }
}
