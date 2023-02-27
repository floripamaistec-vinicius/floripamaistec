namespace pareAqui
{
    public class CadastroTicket
    {

        public static void CadastrarEntrada(Carro carro)
        {
            if (carro.listaDeTickets.Count() == 0)
            {
                PreencherTicketEntrada(carro);
            }
            else
            {
                if (PesquisarTicket(carro).Ativo == true)
                {
                    PreencherTicketEntrada(carro);
                }
                else
                {
                    Console.WriteLine("Ticket Ativo inexistente.");
                }
            }
        }
        public static void CadastrarSaida(Carro carro)
        {
            if (carro.listaDeTickets.Count == 0)
            {
                Console.WriteLine("Ticket Ativo inexistente.");
            }
            else
            {
                Ticket ticket = PesquisarTicket(carro);
                if (ticket.Ativo == true)
                {
                    Console.WriteLine("Ticket Ativo existente.");
                }
                else
                {
                    PreencherTicketSaida(ticket, carro);
                }
            }
        }
        private static Ticket PesquisarTicket(Carro carro)
        {
            return carro.listaDeTickets.Last();
        }
        private static void PreencherTicketEntrada(Carro carro)
        {
            Ticket ticket = new Ticket();
            ticket.Entrada = DateTime.Now;
            ticket.Ativo = false;
            carro.listaDeTickets.Add(ticket);
        }
        private static void PreencherTicketSaida(Ticket ticket, Carro carro)
        {
            ticket.Saida = DateTime.Now;
            ticket.Ativo = true;
        }
        public static void ListarTickets(Carro carro)
        {
            if (carro.listaDeTickets.Count() == 0)
            {
                Console.WriteLine("Tickets cadastradados inexistentes");
            }
            foreach(Ticket ticket in carro.listaDeTickets)
            {
                if (ticket.Ativo == false)
                {
                    Console.WriteLine("Placa: {0} --- Entrada: {1}", carro.Placa, ticket.Entrada);
                }
                else
                {
                    Console.WriteLine("Placa: {0} --- Entrada: {1} --- Saida: {2} --- Valor Total: {3}", carro.Placa, ticket.Entrada, ticket.Saida, ticket.CalcularValor());
                }
                
            }
        }
    }
}
