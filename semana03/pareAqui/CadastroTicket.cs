namespace pareAqui
{
    public class CadastroTicket
    {
        public static void CadastrarEntrada()
        {
            try
            {
                Carro carro = CadastroCarro.ConsultarPlacaNoCadastroDeCarros();
                if (carro == null)
                {
                    throw new ArgumentNullException("Carro não cadastrado.");
                }
                else
                {
                    if (PesquisarTicket(carro).Ativo == true)
                    {
                        Console.WriteLine("Placa: {0}", carro.Placa);
                        Console.WriteLine("Ticket Ativo cadastrado anteriormente.");
                    }
                    else
                    {
                        PreencherTicketEntrada();
                    }
                }
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public static void CadastrarSaida()
        {
            try
            {
                Carro carro = CadastroCarro.ConsultarPlacaNoCadastroDeCarros();
                if (carro == null)
                {
                    throw new ArgumentNullException("Carro não cadastrado.");
                }
                else
                {
                    if (carro.listaDeTickets.Last().Ativo == false)
                    {
                        Console.WriteLine("Placa: {0}", carro.Placa);
                        Console.WriteLine("Ticket Ativo não cadastrado.");
                    }
                    else
                    {
                        PreencherTicketSaida(PesquisarTicket(carro));
                    }
                }
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private static Ticket PesquisarTicket(Carro carro)
        {
            return carro.listaDeTickets.Last();
        }
        private static void PreencherTicketEntrada()
        {
            Ticket ticket = new Ticket();
            ticket.Entrada = DateTime.Now;
            ticket.Ativo = false;
        }
        private static void PreencherTicketSaida(Ticket ticket)
        {
            ticket.Saida = DateTime.Now;
            ticket.Ativo = true;
        }
    }
}
/*
try
{
    Carro carro = ObterCarro();
    if (carro is null)
    {
        throw new ArgumentNullException("Veículo não cadastrado");
    }
    else
    {
        if (carro.listaDeTickets.Count == 0)
        {
            Ticket novoTicket = new Ticket();
            novoTicket.Entrada = DateTime.Now;
            novoTicket.Ativo = true;
            carro.listaDeTickets.Add(novoTicket);
        }
        else
        {
            foreach (Ticket ticket in carro.listaDeTickets)
            {
                if (ticket.Ativo = false)
                {
                    Ticket novoTicket = new Ticket();
                    novoTicket.Entrada = DateTime.Now;
                    novoTicket.Ativo = true;
                    carro.listaDeTickets.Add(novoTicket);
                    Console.WriteLine("Entrada Placa: {0}", carro.Placa);
                }
                else { Console.WriteLine("Placa: {0} com ticket ativo", carro.Placa); }
            }
        }
    }
}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
*/