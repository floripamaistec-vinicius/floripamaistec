using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    public static class Animacao
    {
        public static void animacao()
        {
            Console.WriteLine("Animação Frozen");
        }
        public static void animacao(string tipo)
        {
            Console.WriteLine("Animação {0}",tipo);
        }
    }
}
