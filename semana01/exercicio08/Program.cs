static int CalculaSequenciaFibonacciRecursivamente(int enesimoTermo)
{
    if (enesimoTermo == 0 || enesimoTermo == 1)
    {
        return enesimoTermo;
    }
    else
    {
        return CalculaSequenciaFibonacciRecursivamente(enesimoTermo - 1) + CalculaSequenciaFibonacciRecursivamente(enesimoTermo - 2);
    }
}

int informaValorDoParametroNoMetodo()
{
    Console.WriteLine("Calcular a sequência de Fibonacci até:");
    return int.Parse(Console.ReadLine());
}

for (int iterador = informaValorDoParametroNoMetodo(); iterador > 0; iterador--)
{
    Console.WriteLine("{0}º Termo: {1}", iterador, CalculaSequenciaFibonacciRecursivamente(iterador - 1));
}
