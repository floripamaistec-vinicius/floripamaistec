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
        public string _nome { get; set; }
        public DateTime _dataNascimento { get; set; }
        public bool _menorIdade { get; set; }
        public FichaInscricao(int id, string Nome, DateTime DataNascimento, bool MenorIdade)
        {
            this._id = id;
            this._nome = Nome;
            this._dataNascimento = DataNascimento;
            this._menorIdade = MenorIdade;
        }
        public void ImprimeInscricao()
        {
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine("Nome: {0}", _nome);
            Console.WriteLine("Data de Nascimento: {0}", _dataNascimento);
            if (_menorIdade == true) { Console.WriteLine("Maior de Idade"); }
            else Console.WriteLine("Menor de Idade.");
        }
    }
}
