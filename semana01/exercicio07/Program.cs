Console.WriteLine("Aluno: ");
string NomeDoAluno = Console.ReadLine();

Console.WriteLine("Número de Notas: ");
int QuantidadeDeNotas = int.Parse(Console.ReadLine());

List<float> ListaDeNotas = new List<float>();

for (int iteradorListaDeNotas = 0; iteradorListaDeNotas < QuantidadeDeNotas; iteradorListaDeNotas++)
{
    Console.WriteLine("Nota {0}:", iteradorListaDeNotas + 1);
    ListaDeNotas.Add(float.Parse(Console.ReadLine()));
}

Console.WriteLine("Aluno: {0}", NomeDoAluno);

for (int iteradorListaDeNotas = 0; iteradorListaDeNotas < ListaDeNotas.Count; iteradorListaDeNotas++)
{
    Console.WriteLine("Nota {0}: {1}", (iteradorListaDeNotas + 1), ListaDeNotas[iteradorListaDeNotas]);
}

float media = ListaDeNotas.Sum() / QuantidadeDeNotas;

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
