namespace pareAqui
{
    public class CadastroTicket
    {
        public static void CadastrarEntrada()
        {
            try
            {
                Carro carro = CadastroCarro.ConsultarPlacaNoCadastroDeCarros();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public static void CadastrarSaida()
        {
            Console.WriteLine();
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