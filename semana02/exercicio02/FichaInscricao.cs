using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    public class FichaInscricao
    {
        private int _id;
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }
        public FichaInscricao(int id, string nome, DateTime dataNascimento, bool menorIdade)
        {
            this._id = id;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.MenorIdade = menorIdade;
        }
        public void ImprimeInscricao()
        {
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("Data de Nascimento: {0}", DataNascimento);
            if (MenorIdade == true) { Console.WriteLine("Maior de Idade"); }
            else Console.WriteLine("Menor de Idade.");
        }
    }
}
