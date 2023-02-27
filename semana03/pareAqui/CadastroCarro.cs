namespace pareAqui
{
    public class CadastroCarro
    {
        public static List<Carro> ListaDeCarros = new List<Carro>();
        public static void CadastrarCarro()
        {
            string Placa = InformarPlaca();
            if (VerificarPlaca(Placa) == null)
            {
                PreencherFormularioDeVeiculo(Placa);
                Console.WriteLine("Placa: {0}", ListaDeCarros.Last().Placa);
                Console.WriteLine("Cadastro efetuado.");
            }
            else
            {
                Console.WriteLine("Placa: {0}", Placa);
                Console.WriteLine("Cadastro efetuado anteriormente.");
            }
        }
        private static string InformarPlaca()
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
            ListaDeCarros.Add(carro);
        }

        public static Carro ConsultarPlacaNoCadastroDeCarros()
        {
            return VerificarPlaca(InformarPlaca());
        }
    }
}
