namespace pareAqui
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            ExecutarOpcaoEscolhida();
        }
        private static string EscreverTextoDoMenuPrincipal()
        {
            Console.WriteLine("Estacionamento pareAqui.");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Veículo: Cadastrar");
            Console.WriteLine("2 - Veículo: Histórico");
            Console.WriteLine("3 - Ticket: Entrada");
            Console.WriteLine("4 - Ticket: Saída");
            Console.WriteLine("5 - Sair");
            return Console.ReadLine();
        }
        private static void ExecutarOpcaoEscolhida()
        {
            string Opcao;
            do
            {
                Opcao = EscreverTextoDoMenuPrincipal();
                switch (Opcao)
                {
                    case "1":
                        CadastroCarro.CadastrarCarro(); break;
                    case "2":
                        CadastroCarro.CadastrarCarro(); break;
                    case "3":
                        CadastroTicket.TryCatchCarro(Opcao); break;
                    case "4":
                        CadastroTicket.TryCatchCarro(Opcao); break;
                    case "5":
                        break;
                    default: Console.WriteLine("Opção inexistente."); break;
                }
            }
            while (Opcao != "5");
        }
    }
}
