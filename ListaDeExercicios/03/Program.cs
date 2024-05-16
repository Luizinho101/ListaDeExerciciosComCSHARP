
using System;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        decimal salario;

        Console.WriteLine("Informe seu nome!");
        nome = Console.ReadLine();

        Console.WriteLine("Informe o seu salário!");
        salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Nome do funcionário: {nome}");
        Console.WriteLine($"Salário : {salario.ToString("C2")}");
    }
        
}
