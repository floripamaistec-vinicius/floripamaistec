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
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public bool menorIdade { get; set; }
        public FichaInscricao(int id, string Nome, DateTime DataNascimento, bool MenorIdade)
        {
            this._id = id;
            this.nome = Nome;
            this.dataNascimento = DataNascimento;
            this.menorIdade = MenorIdade;
        }
        public void ImprimeInscricao()
        {
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Data de Nascimento: {0}", dataNascimento);
            if (menorIdade == true) { Console.WriteLine("Maior de Idade"); }
            else Console.WriteLine("Menor de Idade.");
        }
    }
}
