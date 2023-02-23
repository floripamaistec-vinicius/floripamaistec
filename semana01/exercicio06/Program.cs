Console.WriteLine("Digite o número que será tabuado:");
int NumeroQueSeraTabuado = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{NumeroQueSeraTabuado} x {i} = {NumeroQueSeraTabuado * i}");
}
