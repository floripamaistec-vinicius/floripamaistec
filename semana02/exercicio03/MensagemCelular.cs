using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    public class MensagemCelular
    {
        public int telefone { get; set; }
        public string mensagem { get; set; }
        public MensagemCelular(int Telefone, string Mensagem)
        {
            this.telefone = Telefone;
            this.mensagem = Mensagem;
        }
        public void Executar()
        {
            Console.WriteLine("Método Executao pelo Console");
            EnviarMensagemAoTelefone();
        }
        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine("Telefone: {0}, Mensagem: {1}", telefone, mensagem);
        }
    }
}
