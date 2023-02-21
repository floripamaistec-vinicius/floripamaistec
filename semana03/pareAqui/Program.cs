using pareAqui;
using System.Globalization;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
// Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

List<Carro> listaDeCarros = new List<Carro>();

string opcao;
do
{
    Console.WriteLine("Bem vindo ao pareAqui, escolha uma opção:");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Marcar Entrada");
    Console.WriteLine("3 - Marcar Saída");
    Console.WriteLine("4 - Consultar Histórico");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();
    if (opcao == "1") { CadastrarCarro(); }
    else if (opcao == "2") { GerarTicket(); }
    else if (opcao == "3") { FecharTicket(); }
    else if (opcao == "4") { Historico(); }
    else if (opcao == "5") { break; }
    else { Console.WriteLine("Opção inexistente. Digite novamente."); }
} while (opcao != "5");

void CadastrarCarro() {
    Carro carro = new Carro();
    Console.WriteLine("Placa:");
    carro.placa = Console.ReadLine();
    Console.WriteLine("Modelo:");
    carro.modelo = Console.ReadLine();
    Console.WriteLine("Cor:");
    carro.cor = Console.ReadLine();
    Console.WriteLine("Marca:");
    carro.marca = Console.ReadLine();
    listaDeCarros.Add(carro);
}

Carro ObterCarro()
{
    Console.WriteLine("Placa:");
    string buscarPlaca = Console.ReadLine();
    foreach (Carro carro in listaDeCarros)
    {
        if (buscarPlaca == carro.placa)
        {
            return carro;
        }
        else { Console.WriteLine("Veículo não cadastrado"); }
    }
    return null;
}

void GerarTicket()
{
    Carro carro = ObterCarro();
    if (carro.listaDeTickets.Count == 0)
    {
        Ticket novoTicket = new Ticket();
        novoTicket.entrada = DateTime.Now;
        novoTicket.ativo = true;
        carro.listaDeTickets.Add(novoTicket);
    }
    else
    {
        foreach (Ticket ticket in carro.listaDeTickets)
        {
            if (ticket.ativo = false)
            {
                Ticket novoTicket = new Ticket();
                novoTicket.entrada = DateTime.Now;
                novoTicket.ativo = true;
                carro.listaDeTickets.Add(novoTicket);
                Console.WriteLine("Entrada Placa: {0}", carro.placa);
            }
            else { Console.WriteLine("Ticket Ativo == True"); }
        }
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
        Console.WriteLine(String.Format("Entrada: {0} --- Saida: {1} --- Valores Pagos: {2:C}", ticket.entrada, ticket.saida, Convert.ToInt32(ticket.CalcularValor())));
    }
}

void FecharTicket()
{
    Carro carro = ObterCarro();
    if (carro.listaDeTickets.Count == 0)
    {
        Console.WriteLine("Veículo sem ticket cadastrado.");
        return;
    }
    foreach (Ticket ticket in carro.listaDeTickets)
    {
        if (ticket.ativo == true)
        {
            ticket.saida = DateTime.Now;
            ticket.ativo = false;
            Console.WriteLine("Saída Placa: {0}", carro.placa);
        }
    }
}
