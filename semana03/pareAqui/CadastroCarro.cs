namespace pareAqui
{
    public class CadastroCarro
    {
        public static List<Carro> ListaDeCarros = new List<Carro>();
        public static void CadastrarCarro(string Placa)
        {
            if (VerificarPlaca(Placa) == null)
            {
                PreencherFormularioDeVeiculo(Placa);
            }
            else
            {
                Console.WriteLine("Cadastro efetuado anteriormente.");
            }
        }
        public static void ConsultarHistorico(Carro carro)
        {
            if (carro.Placa == null)
            {
                Console.WriteLine("Cadastro inexistente.");
            }
            else
            {
                CadastroTicket.ListarTickets(carro);
            }
        }
        public static string InformarPlaca()
        {
            Console.WriteLine("Placa:");
            return Console.ReadLine();
        }
        private static Carro VerificarPlaca(string Placa)
        {
            for (int index = 0; index < ListaDeCarros.Count(); index++)
            {
                if (Placa == ListaDeCarros[index].Placa)
                {
                    return ListaDeCarros[index];
                }
            }
            return null;
        }
        private static void PreencherFormularioDeVeiculo(string Placa)
        {
            Carro carro = new Carro();
            carro.Placa = Placa;
            carro.Ativo = true;
            CompletarFormulario(carro);
            ListaDeCarros.Add(carro);
        }
        private static void CompletarFormulario(Carro carro)
        {
            Console.WriteLine("Modelo:");
            carro.Modelo = Console.ReadLine();
            Console.WriteLine("Cor:");
            carro.Cor = Console.ReadLine();
            Console.WriteLine("Marca:");
            carro.Marca = Console.ReadLine();
        }

        public static Carro ConsultarPlacaNoCadastroDeCarros()
        {
            return VerificarPlaca(InformarPlaca());
        }
    }
}
