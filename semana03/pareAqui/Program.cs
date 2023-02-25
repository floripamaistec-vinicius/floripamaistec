﻿using pareAqui;
using System.Globalization;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
// Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

List<Carro> ListaDeCarros = new List<Carro>();

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
    if (Opcao == "1") { CadastrarCarro(); }
    else if (Opcao == "2") { GerarTicket(); }
    else if (Opcao == "3") { FecharTicket(); }
    else if (Opcao == "4") { Historico(); }
    else if (Opcao == "5") { break; }
    else { Console.WriteLine("Opção inexistente. Digite novamente."); }
} while (Opcao != "5");

void CadastrarCarro() {
    Carro carro = new Carro();
    Console.WriteLine("Placa:");
    carro.Placa = Console.ReadLine();
    Console.WriteLine("Modelo:");
    carro.Modelo = Console.ReadLine();
    Console.WriteLine("Cor:");
    carro.Cor = Console.ReadLine();
    Console.WriteLine("Marca:");
    carro.Marca = Console.ReadLine();
    ListaDeCarros.Add(carro);
}

Carro ObterCarro()
{
    Console.WriteLine("Placa:");
    string buscarPlaca = Console.ReadLine();
    foreach (Carro carro in ListaDeCarros)
    {
        if (buscarPlaca == carro.Placa)
        {
            return carro;
        }
        else { Console.WriteLine("Veículo não cadastrado"); }
    }
    return null;
}

void GerarTicket()
{
    try
    {
        Carro carro = ObterCarro();
        if (carro is null)
        {
            throw new ArgumentNullException("Veículo não cadastrado");
        }
        else
        {
            if (carro.listaDeTickets.Count == 0)
            {
                Ticket novoTicket = new Ticket();
                novoTicket.Entrada = DateTime.Now;
                novoTicket.Ativo = true;
                carro.listaDeTickets.Add(novoTicket);
            }
            else
            {
                foreach (Ticket ticket in carro.listaDeTickets)
                {
                    if (ticket.Ativo = false)
                    {
                        Ticket novoTicket = new Ticket();
                        novoTicket.Entrada = DateTime.Now;
                        novoTicket.Ativo = true;
                        carro.listaDeTickets.Add(novoTicket);
                        Console.WriteLine("Entrada Placa: {0}", carro.Placa);
                    }
                    else { Console.WriteLine("Ticket Ativo == True"); }
                }
            }
        }
    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine(e.Message);
    }
}

void Historico()
{
    Carro carro = ObterCarro();
    if (carro.listaDeTickets.Count == 0)
    {
        Console.WriteLine("Veículo sem ticket cadastrado.");
        return;
    }
    foreach (Ticket ticket in carro.listaDeTickets)
    {
        Console.WriteLine(String.Format("Entrada: {0} --- Saida: {1} --- Valores Pagos: {2:C}", ticket.Entrada, ticket.Saida, Convert.ToInt32(ticket.CalcularValor())));
    }
}

void FecharTicket()
{
    try
    {
        Carro carro = ObterCarro();
        if (carro is null)
        {
            throw new ArgumentNullException("Veículo não cadastrado");
        }
        else
        {
            if (carro.listaDeTickets.Count == 0)
            {
                Console.WriteLine("Veículo sem ticket cadastrado.");
                return;
            }
            foreach (Ticket ticket in carro.listaDeTickets)
            {
                if (ticket.Ativo == true)
                {
                    ticket.Saida = DateTime.Now;
                    ticket.Ativo = false;
                    Console.WriteLine("Saída Placa: {0}", carro.Placa);
                }
            }
        }
    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine(e.Message);
    }
}
