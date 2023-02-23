using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }
        public Filme(string nomeFilme, string categoria)
        {
            this.NomeFilme = nomeFilme;
            this.Categoria = categoria;
        }
        public void ReturnFilme()
        {
            Console.WriteLine("Filme {0}, Categoria {1}", NomeFilme, Categoria);
        }
    }
}
