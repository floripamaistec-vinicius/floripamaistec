List<double> LadosDoTriangulo = new List<double>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Valor do {i + 1}º lado:");
    LadosDoTriangulo.Add(double.Parse(Console.ReadLine()));
}

if (LadosDoTriangulo[0] < (LadosDoTriangulo[1] + LadosDoTriangulo[2]) || LadosDoTriangulo[1] < (LadosDoTriangulo[0] + LadosDoTriangulo[2]) || LadosDoTriangulo[2] < (LadosDoTriangulo[0] + LadosDoTriangulo[2]))
{
    if (LadosDoTriangulo[0] == LadosDoTriangulo[1] && LadosDoTriangulo[0] == LadosDoTriangulo[2])
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (LadosDoTriangulo[0] != LadosDoTriangulo[1] && LadosDoTriangulo[0] != LadosDoTriangulo[2] && LadosDoTriangulo[1] != LadosDoTriangulo[2])
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
