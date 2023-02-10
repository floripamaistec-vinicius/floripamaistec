Console.WriteLine("Salário bruto: ");
float salarioBruto = float.Parse(Console.ReadLine());

if (salarioBruto <= 900)
{
    Console.WriteLine("Imposto ZERO.");
}
else if (salarioBruto <= 1500)
{
    Console.WriteLine($"Salário: R$ {salarioBruto}. Imposto: R$ {salarioBruto * 0.05}");
}
else if (salarioBruto <= 2500)
{
    Console.WriteLine($"Salário: R$ {salarioBruto}. Imposto: R$ {salarioBruto * 0.1}");
}
else
{
    Console.WriteLine($"Salário: R$ {salarioBruto}. Imposto: R$ {salarioBruto * 0.2}");
}
