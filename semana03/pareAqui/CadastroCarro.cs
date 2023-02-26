
using System.Numerics;

namespace pareAqui
{
    public class CadastroCarro
    {
        static List<Carro> ListaDeCarros = new List<Carro>();
        public void CadastrarCarro()
        {
            string Placa = InformarPlaca();
            if (VerificarPlaca(Placa) == null)
            {
                PreencherFormularioVeiculo(Placa);
            }
            else
            {
                Console.WriteLine("Placa: {0}", Placa);
                Console.WriteLine("Cadastro criado anteriormente.");
            }
        }
        private string InformarPlaca()
        {
            Console.WriteLine("Placa:");
            return Console.ReadLine();
        }
        private Carro VerificarPlaca(string Placa)
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
        private void PreencherFormularioVeiculo(string Placa)
        {
            Carro carro = new Carro();
            carro.Placa = Placa;
            carro.Ativo = true;
            ListaDeCarros.Add(carro);
        }
    }
}
