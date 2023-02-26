namespace pareAqui
{
    public class Menu
    {
        CadastroCarro cadastroCarro = new CadastroCarro();
        public void MenuPrincipal()
        {
            ExecutarOpcaoEscolhida();
        }
        private string EscreverTextoDoMenuPrincipal()
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
        private void ExecutarOpcaoEscolhida()
        {
            string Opcao;
            do
            {
                Opcao = EscreverTextoDoMenuPrincipal();
                switch (Opcao)
                {
                    case "1":
                        cadastroCarro.CadastrarCarro(); break;
                    case "2":
                        cadastroCarro.CadastrarCarro(); break;
                    case "3":
                        cadastroCarro.CadastrarCarro(); break;
                    case "4":
                        cadastroCarro.CadastrarCarro(); break;
                    case "5":
                        break;
                }
            }
            while (Opcao != "5");
        }
    }
}
