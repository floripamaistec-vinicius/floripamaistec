List<double> ListaDeTransacoes = new List<double>();

Console.WriteLine("Bem vindo ao Banco, por favor selecione uma opção para continuar: ");

static void MenuDoBanco()
{
    Console.WriteLine("1 - Adicionar Transação");
    Console.WriteLine("2 - Consultar Extrato");
    Console.WriteLine("3 - Sair");
}

string OpcaoDoMenuSelecionada()
{
    return Console.ReadLine();
}
void Transacao()
{
    Console.WriteLine("Qual o valor? ");
    ListaDeTransacoes.Add(double.Parse(Console.ReadLine()));
}

void Extrato()
{
    foreach (double Transacao in ListaDeTransacoes)
    {
        Console.WriteLine("Valor da Transação Efetuada: {0}", Transacao);
    }
    Console.WriteLine("Valor Total: {0}", ListaDeTransacoes.Sum());
}


MenuDoBanco();
string OpcacaoSelecionada = OpcaoDoMenuSelecionada();

do
{
    switch (OpcacaoSelecionada)
    {
        case "1": Transacao(); break;
        case "2": Extrato(); break;
        default: Console.WriteLine("Opção Inexistente"); break;
    }
    MenuDoBanco();
    OpcacaoSelecionada = OpcaoDoMenuSelecionada();
} while (OpcacaoSelecionada != "3");
