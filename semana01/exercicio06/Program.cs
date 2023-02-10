Console.WriteLine("Digite o número que será tabuado:");
int numeroQueSeraTabuado = int.Parse(Console.ReadLine());

for (int iterador = 0; iterador <= 10; iterador++)
{
    Console.WriteLine($"{numeroQueSeraTabuado} x {iterador} = {numeroQueSeraTabuado * iterador}");
}
