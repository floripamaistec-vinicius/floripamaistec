Console.WriteLine("Salário bruto: ");
double SalarioBruto = double.Parse(Console.ReadLine());

if (SalarioBruto <= 900)
{
    Console.WriteLine("Sem Imposto");
}
else if (SalarioBruto <= 1500)
{
    Console.WriteLine($"Salário: R$ {SalarioBruto}. Imposto: R$ {SalarioBruto * 0.05}");
}
else if (SalarioBruto <= 2500)
{
    Console.WriteLine($"Salário: R$ {SalarioBruto}. Imposto: R$ {SalarioBruto * 0.1}");
}
else
{
    Console.WriteLine($"Salário: R$ {SalarioBruto}. Imposto: R$ {SalarioBruto * 0.2}");
}
