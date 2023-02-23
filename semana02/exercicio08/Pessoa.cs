using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace exercicio08
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade;
        public Pessoa(string nome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
        }
        private void CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            Idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-Idade))
            {
                Idade--;
            }
        }
        public void MostrarIdade()
        {
            CalcularIdade();

            Console.WriteLine($"{Nome} tem a idade de {Idade} anos.");
        }
    }
}
