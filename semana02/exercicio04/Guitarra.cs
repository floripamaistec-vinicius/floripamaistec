using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    public class Guitarra
    {
        private static string _afinacao { get; set; }
        static Guitarra()
        {
            _afinacao = "sol";
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
            _afinacao = AfinacaoAtual;
            TomAfinado();
        }
    }
}
