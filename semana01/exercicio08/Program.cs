static int CalculaSequenciaFibonacciRecursivamente(int EnesimoTermo)
{
    if (EnesimoTermo == 0 || EnesimoTermo == 1)
    {
        return EnesimoTermo;
    }
    else
    {
        return CalculaSequenciaFibonacciRecursivamente(EnesimoTermo - 1) + CalculaSequenciaFibonacciRecursivamente(EnesimoTermo - 2);
    }
}

int informaValorDoParametroNoMetodo()
{
    Console.WriteLine("Calcular a sequência de Fibonacci até:");
    return int.Parse(Console.ReadLine());
}

for (int i = informaValorDoParametroNoMetodo(); i > 0; i--)
{
    Console.WriteLine("{0}º Termo: {1}", i, CalculaSequenciaFibonacciRecursivamente(i - 1));
}
