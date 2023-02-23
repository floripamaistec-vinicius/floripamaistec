List<string> listaDePerguntas = new List<string>();
List<string> listaDeRespostas = new List<string>();

listaDePerguntas.Add("Nome: ");
listaDePerguntas.Add("Sobrenome: ");
listaDePerguntas.Add("Idade: ");
listaDePerguntas.Add("Cor Favorita: ");

foreach(string pergunta in listaDePerguntas)
{
    Console.WriteLine(pergunta);
    listaDeRespostas.Add(Console.ReadLine());
}

for (int i = 0; i < listaDeRespostas.Count; i++)
{
    Console.WriteLine(listaDePerguntas[i] + listaDeRespostas[i]);
}
