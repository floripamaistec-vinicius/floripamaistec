using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    public class Guitarra
    {
        private static string afinacao { get; set; }
        static Guitarra()
        {
            afinacao = "sol";
        }
        private static void TomAfinado()
        {
            Console.WriteLine("{0}", _afinacao);
        }
        public void Tocar()
        {
            TomAfinado();
        }
        public void Tocar(string AfinacaoAtual)
        {
            afinacao = AfinacaoAtual;
            TomAfinado();
        }
    }
}
