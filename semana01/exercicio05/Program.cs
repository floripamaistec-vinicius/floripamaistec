List<float> ladosDoTriangulo = new List<float>();

for (int iterador = 0; iterador < 3; iterador++)
{
    Console.WriteLine($"Valor do {iterador + 1}º lado:");
    ladosDoTriangulo.Add(float.Parse(Console.ReadLine()));
}

if (ladosDoTriangulo[0] < (ladosDoTriangulo[1] + ladosDoTriangulo[2]) || ladosDoTriangulo[1] < (ladosDoTriangulo[0] + ladosDoTriangulo[2]) || ladosDoTriangulo[2] < (ladosDoTriangulo[0] + ladosDoTriangulo[2]))
{
    if (ladosDoTriangulo[0] == ladosDoTriangulo[1] && ladosDoTriangulo[0] == ladosDoTriangulo[2])
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (ladosDoTriangulo[0] != ladosDoTriangulo[1] && ladosDoTriangulo[0] != ladosDoTriangulo[2] && ladosDoTriangulo[1] != ladosDoTriangulo[2])
    {
        Console.WriteLine("Triângulo Escaleno");
    }
    else
    {
        Console.WriteLine("Triângulo Isóceles");
    }
}
else
{
    Console.WriteLine("Não é um Triangulo.");
}
