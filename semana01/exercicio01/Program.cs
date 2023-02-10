List<string> listaDePerguntas = new List<string>();
List<string> listaDeRespostas = new List<string>();

listaDePerguntas.Add("Nome: ");
listaDePerguntas.Add("Sobrenome: ");
listaDePerguntas.Add("Idade: ");
listaDePerguntas.Add("Cor Favorita: ");

for (int i = 0; i < listaDePerguntas.Count; i++)
{
    Console.WriteLine(listaDePerguntas[i]);
    listaDeRespostas.Add(Console.ReadLine());
}

for (int i = 0; i < listaDeRespostas.Count; i++)
{
    Console.WriteLine(listaDePerguntas[i] + listaDeRespostas[i]);
}
