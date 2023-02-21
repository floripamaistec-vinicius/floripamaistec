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
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public int idade;
        public Pessoa(string Nome, DateTime DataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }
        private void CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
        }
        public void MostrarIdade()
        {
            CalcularIdade();

            Console.WriteLine($"{nome} tem a idade de {idade} anos.");
        }
    }
}
