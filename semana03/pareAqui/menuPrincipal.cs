using pareAqui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pareAqui;

namespace pareAqui
{
    public class menuPrincipal
    {
        public void Iniciar()
        {
            string Opcao;
            do
            {
                Console.WriteLine("Bem vindo ao pareAqui, escolha uma opção:");
                Console.WriteLine("1 - Cadastrar Carro");
                Console.WriteLine("2 - Marcar Entrada");
                Console.WriteLine("3 - Marcar Saída");
                Console.WriteLine("4 - Consultar Histórico");
                Console.WriteLine("5 - Sair");
                Opcao = Console.ReadLine();
                if (Opcao == "1")
                {
                    CadastrarCarro();
                }
                else if (Opcao == "2")
                {
                    GerarTicket();
                }
                else if (Opcao == "3") { FecharTicket(); }
                else if (Opcao == "4") { Historico(); }
                else if (Opcao == "5") { break; }
                else { Console.WriteLine("Opção inexistente. Digite novamente."); }
            } while (Opcao != "5");
        }
    }
}
