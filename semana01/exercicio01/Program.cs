List<string> ListaDePerguntas = new List<string>();
List<string> ListaDeRespostas = new List<string>();

ListaDePerguntas.Add("Nome: ");
ListaDePerguntas.Add("Sobrenome: ");
ListaDePerguntas.Add("Idade: ");
ListaDePerguntas.Add("Cor Favorita: ");

foreach(string pergunta in ListaDePerguntas)
{
    Console.WriteLine(pergunta);
    ListaDeRespostas.Add(Console.ReadLine());
}

for (int i = 0; i < ListaDeRespostas.Count; i++)
{
    Console.WriteLine(ListaDeRespostas[i] + ListaDeRespostas[i]);
}
