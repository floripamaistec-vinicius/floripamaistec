using pareAqui;
using System.Globalization;
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
    Carro carroCadastrado = ObterCarro();
    verificarTicketAtivo(carroCadastrado);
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

void verificarTicketAtivo(Carro carroCadastrado)
{
    int ticketAtual = carroCadastrado.listTicket.Count - 1;
    if (carroCadastrado.listTicket[ticketAtual].ativo == false)
    {
        criarTicket(ticketAtual, carroCadastrado);
    }
}

void criarTicket(int ticketAtual, Carro carroCadastrado)
{
    carroCadastrado.listTicket[ticketAtual].entrada = DateTime.Now;
    carroCadastrado.listTicket[ticketAtual].ativo = true;
}
