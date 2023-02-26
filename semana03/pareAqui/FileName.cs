
/*
using pareAqui;

Carro ObterCarro()
{
    Console.WriteLine("Placa:");
    string buscarPlaca = Console.ReadLine();
    foreach (Carro carro in ListaDeCarros)
    {
        if (buscarPlaca == carro.Placa)
        {
            return carro;
        }
        else { Console.WriteLine("Veículo não cadastrado"); }
    }
    return null;
}
void GerarTicket()
{
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
}
void Historico()
{
    Carro carro = ObterCarro();
    if (carro.listaDeTickets.Count == 0)
    {
        Console.WriteLine("Veículo sem ticket cadastrado.");
        return;
    }
    foreach (Ticket ticket in carro.listaDeTickets)
    {
        if (ticket.Ativo)
        {
            Console.WriteLine("Placa: {0} --- Entrada: {0}", carro.Placa, ticket.Entrada);
        }
        else
        {
            Console.WriteLine(String.Format("Entrada: {0} --- Saida: {1} --- Valores Pagos: {2:C}", ticket.Entrada, ticket.Saida, Convert.ToInt32(ticket.CalcularValor())));
        }
    }
}
void FecharTicket()
{
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
                Console.WriteLine("Veículo sem ticket cadastrado.");
                return;
            }
            foreach (Ticket ticket in carro.listaDeTickets)
            {
                if (ticket.Ativo == true)
                {
                    ticket.Saida = DateTime.Now;
                    ticket.Ativo = false;
                    Console.WriteLine("Saída Placa: {0}", carro.Placa);
                }
                else
                {
                    Console.WriteLine("Placa: {0} sem ticket ativo", carro.Placa);
                }
            }
        }
    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine(e.Message);
    }
}
*/