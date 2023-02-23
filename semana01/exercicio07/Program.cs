Console.WriteLine("Aluno: ");
string NomeDoAluno = Console.ReadLine();

Console.WriteLine("Número de Notas: ");
int QuantidadeDeNotas = int.Parse(Console.ReadLine());

List<float> ListaDeNotas = new List<float>();

for (int i = 0; i < QuantidadeDeNotas; i++)
{
    Console.WriteLine("Nota {0}:", i + 1);
    ListaDeNotas.Add(float.Parse(Console.ReadLine()));
}

Console.WriteLine("Aluno: {0}", NomeDoAluno);

for (int i = 0; i < ListaDeNotas.Count; i++)
{
    Console.WriteLine("Nota {0}: {1}", (i + 1), ListaDeNotas[i]);
}

float Media = ListaDeNotas.Sum() / QuantidadeDeNotas;

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
