List<string> listaDePerguntas = new List<string>();
List<string> listaDeRespostas = new List<string>();

listaDePerguntas.Add("Nome: ");
listaDePerguntas.Add("Sobrenome: ");
listaDePerguntas.Add("Idade: ");
listaDePerguntas.Add("Cor Favorita: ");

foreach (String pergunta in listaDePerguntas)
{
    Console.WriteLine(pergunta);
    listaDeRespostas.Add(Console.ReadLine());
}

for (int indexListaDeResposta = 0; indexListaDeResposta < listaDeRespostas.Count; indexListaDeResposta++)
{
    Console.WriteLine(listaDePerguntas[indexListaDeResposta] + listaDeRespostas[indexListaDeResposta]);
}
