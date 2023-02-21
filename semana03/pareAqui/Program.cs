using pareAqui;
using System.Globalization;
using System.Net.Sockets;
// Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

List<Carro> listCarro = new List<Carro>();

int opcao;
do
{
    Console.WriteLine("Bem vindo ao pareAqui, escolha uma opção:");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Marcar Entrada");
    Console.WriteLine("3 - Marcar Saída");
    Console.WriteLine("4 - Consultar Histórico");
    Console.WriteLine("5 - Sair");
    opcao = int.Parse(Console.ReadLine());
    if (opcao == 1) { CadastrarCarro(); }
    else if (opcao == 2) { MarcarEntrada(); }
    else if (opcao == 3) { FecharTicket(); }
    else if (opcao == 4) { Historico(); }
    else { Console.WriteLine("Opção inexistente. Digite novamente."); }
} while (opcao != 5);

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
    listCarro.Add(carro);
}

void MarcarEntrada()
{
    bool entrada = true;
    Carro carroCadastrado = ObterCarro();
    verificarTicketAtivo(carroCadastrado, entrada);
}

void FecharTicket()
{
    bool entrada = false;
    Carro carroCadastrado = ObterCarro();
    verificarTicketAtivo(carroCadastrado, entrada);
}

void Historico()
{
    Carro carroCadastrado = ObterCarro();
    foreach (Ticket ticket in carroCadastrado.listTicket) {
        Console.WriteLine(String.Format("Entrada: {0} --- Saída: {1} --- Valores: {2:C}", ticket.entrada, ticket.saida, Convert.ToInt32(ticket.CalcularValor())));
    }

}


Carro ObterCarro()
{
    Console.WriteLine("Placa:");
    string buscarPlaca = Console.ReadLine();
    foreach (Carro carro in listCarro)
    {
        if(carro.placa == buscarPlaca)
        {
            return carro;
        } else {
            Console.WriteLine("Veículo não cadastrado.");
            CadastrarCarro();
        }
    }
    return null;
}

void verificarTicketAtivo(Carro carroCadastrado, bool entrada)
{
    foreach (Ticket ticket in carroCadastrado.listTicket)
    {
        if (entrada == true)
        {
            if (ticket.ativo == false)
            {
                gerarTicket(carroCadastrado, entrada, ticket);
            }
            else
            {
                Console.WriteLine("O veículo com placa {0} já possui ticket ativo.", carroCadastrado.placa);
            }
        } else
        {
            if (ticket.ativo == false)
            {
                Console.WriteLine("O veículo com placa {0} não possui ticket ativo.", carroCadastrado.placa);
            }
            else
            {
                gerarTicket(carroCadastrado, entrada, ticket);
            }
        }
    }
}

void gerarTicket(Carro carroCadastrado, bool entrada, Ticket ticket)
{
    if (entrada == true)
    {
        Ticket cadastrarTicket = new Ticket();
        cadastrarTicket.entrada = DateTime.Now;
        cadastrarTicket.ativo = true;
        carroCadastrado.listTicket.Add(ticket);
        Console.WriteLine("Ticket {0}/{1} criado.", carroCadastrado.placa, carroCadastrado.listTicket.Count);
    } else
    {
        ticket.saida = DateTime.Now;
        carroCadastrado.listTicket.Add(ticket);
        Console.WriteLine("Tempo no Estacionamento: {0}", ticket.CalcularTempo());
        Console.WriteLine("Valor no Estacionamento: {0}", ticket.CalcularValor());
    }
    
}
