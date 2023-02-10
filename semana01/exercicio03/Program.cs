List<float> listaDeNotas = new List<float>();

for (int iteradorEntradaNaListaDeNotas = 0; iteradorEntradaNaListaDeNotas < 3; iteradorEntradaNaListaDeNotas++)
{
    Console.WriteLine($"Nota {iteradorEntradaNaListaDeNotas + 1}:");
    listaDeNotas.Add(float.Parse(Console.ReadLine()));
}

float media = listaDeNotas.Sum() / 3;

if (media >= 6)
{
    Console.WriteLine($"Aluno aprovado com média: {media}");
}
else if (media >= 5)
{
    Console.WriteLine($"Aluno em recuperação com média: {media}");
}
else
{
    Console.WriteLine($"Aluno reprovado com média: {media}");
}
