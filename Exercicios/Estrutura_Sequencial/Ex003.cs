using System;

class Exercicios
{
    static void Main()
    {
        Console.WriteLine("Informe o Primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o Segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("A soma de " + num1 + " mais " + num2 + " é " + (num1 + num2));
    }
}
