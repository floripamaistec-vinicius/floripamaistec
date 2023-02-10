List<float> ListaDeTransacoes = new List<float>();

Console.WriteLine("Bem vindo ao Banco, por favor selecione uma opção para continuar: ");

static void MenuDoBanco()
{
    Console.WriteLine("1 - Adicionar Transação");
    Console.WriteLine("2 - Consultar Extrato");
    Console.WriteLine("3 - Sair");
}

int OpcaoDoMenuSelecionada()
{
    return int.Parse(Console.ReadLine());
}
void Transacao()
{
    Console.WriteLine("Qual o valor? ");
    ListaDeTransacoes.Add(float.Parse(Console.ReadLine()));
}

void Extrato()
{
    foreach (float Transacao in ListaDeTransacoes)
    {
        Console.WriteLine("Valor da Transação Efetuada: {0}", Transacao);
    }
    Console.WriteLine("Valor Total: {0}", ListaDeTransacoes.Sum());
}


MenuDoBanco();
int opcacaoSelecionada = OpcaoDoMenuSelecionada();

do
{
    switch (opcacaoSelecionada)
    {
        case 1: Transacao(); break;
        case 2: Extrato(); break;
        default: Console.WriteLine("Opção Inexistente"); break;
    }
    MenuDoBanco();
    opcacaoSelecionada = OpcaoDoMenuSelecionada();
} while (opcacaoSelecionada != 3);
