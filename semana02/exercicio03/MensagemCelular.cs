using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    public class MensagemCelular
    {
        public int _telefone { get; set; }
        public string _mensagem { get; set; }
        public MensagemCelular(int Telefone, string Mensagem)
        {
            this._telefone = Telefone;
            this._mensagem = Mensagem;
        }
        public void Executar()
        {
            Console.WriteLine("Método Executao pelo Console");
            EnviarMensagemAoTelefone();
        }
        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine("Telefone: {0}, Mensagem: {1}", _telefone, _mensagem);
        }
    }
}
