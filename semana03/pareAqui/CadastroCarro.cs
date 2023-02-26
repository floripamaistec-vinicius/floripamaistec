using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pareAqui
{
    public class CadastroCarro
    {
        static List<Carro> ListaDeCarros = new List<Carro>();
        public void CadastrarCarro()
        {
            string Placa = InformarPlaca();
            for (int index = 0; index < ListaDeCarros.Count; index++)
            {

            }
        }
        private string InformarPlaca()
        {
            Console.WriteLine("Placa:");
            return Console.ReadLine();
        }
    }
}
