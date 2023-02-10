List<string> listaDePerguntas = new List<string>();
List<string> listaDeRespostas = new List<string>();

listaDePerguntas.Add("Nome: ");
listaDePerguntas.Add("Sobrenome: ");
listaDePerguntas.Add("Idade: ");
listaDePerguntas.Add("Cor Favorita: ");

for (int iteradorEntrada = 0; iteradorEntrada < listaDePerguntas.Count; iteradorEntrada++)
{
    Console.WriteLine(listaDePerguntas[iteradorEntrada]);
    listaDeRespostas.Add(Console.ReadLine());
}

for (int iteradorSaida = 0; iteradorSaida < listaDeRespostas.Count; iteradorSaida++)
{
    Console.WriteLine(listaDePerguntas[iteradorSaida] + listaDeRespostas[iteradorSaida]);
}
