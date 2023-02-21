using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    public class Filme
    {
        public string nomeFilme { get; set; }
        public string categoria { get; set; }
        public Filme(string NomeFilme, string Categoria)
        {
            this.nomeFilme = NomeFilme;
            this.categoria = Categoria;
        }
        public void ReturnFilme()
        {
            Console.WriteLine("Filme {0}, Categoria {1}", nomeFilme, categoria);
        }
    }
}
