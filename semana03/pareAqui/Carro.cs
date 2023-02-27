namespace pareAqui
{
    public class Carro
    {
        public string Placa { get; set; }
        /*
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        */
        public bool Ativo { get; set; }
        public List<Ticket> listaDeTickets { get; set; }
        public Carro() {
            listaDeTickets = new List<Ticket>();
        }
        public Carro(string placa/*, string modelo, string cor, string marca*/, bool ativo) :this()
        {
            Placa = placa;
            /*
            Modelo = modelo;
            Cor = cor;
            Marca = marca;
            */
            Ativo = ativo;
        }
    }
}
