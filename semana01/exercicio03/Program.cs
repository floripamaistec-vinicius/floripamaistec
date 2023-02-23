List<double> ListaDeNotas = new List<double>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Nota {i + 1}:");
    ListaDeNotas.Add(double.Parse(Console.ReadLine()));
}

double Media = ListaDeNotas.Sum()/3;

if (Media >= 6)
{
    Console.WriteLine($"Aluno aprovado com média: {Media}");
}
else if (Media >= 5)
{
    Console.WriteLine($"Aluno em recuperação com média: {Media}");
}
else
{
    Console.WriteLine($"Aluno reprovado com média: {Media}");
}
