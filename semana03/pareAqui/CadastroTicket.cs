namespace pareAqui
{
    public class CadastroTicket
    {
        public static void TryCatchCarro(string Opcao)
        {
            try
            {
                Carro carro = CadastroCarro.ConsultarPlacaNoCadastroDeCarros();
                if (carro == null)
                {
                    throw new CarroNaoCadastradoException("Carro inexistente.");
                }
                else
                {
                    IFElseTryCatchCarro(Opcao, carro);
                }
            }
            catch (CarroNaoCadastradoException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        static private void IFElseTryCatchCarro(String Opcao, Carro carro)
        {
            if (Opcao == "4")
            {
                CadastrarEntrada(carro);
            }
            else
            {
                CadastrarSaida(carro);
            }
        }
        private static void CadastrarEntrada(Carro carro)
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
                    Console.WriteLine("Placa: {0}", carro.Placa);
                    Console.WriteLine("Ticket Ativo inexistente.");
                }
            }
        }
        private static void CadastrarSaida(Carro carro)
        {
            if (carro.listaDeTickets.Count() == 0)
            {
                Console.WriteLine("Placa: {0}", carro.Placa);
                Console.WriteLine("Ticket Ativo inexistente.");
            }
            else
            {
                Ticket ticket = PesquisarTicket(carro);
                if (ticket.Ativo == true)
                {
                    Console.WriteLine("Placa: {0}", carro.Placa);
                    Console.WriteLine("Ticket Ativo existente.");
                }
                else
                {
                    PreencherTicketSaida(ticket);
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
        private static void PreencherTicketSaida(Ticket ticket)
        {
            ticket.Saida = DateTime.Now;
            ticket.Ativo = true;
        }
    }
}
