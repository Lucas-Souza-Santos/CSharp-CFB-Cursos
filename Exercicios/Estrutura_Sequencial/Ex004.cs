using System;
// Faça um Programa que peça as 4 notas bimestrais e mostre a média.
class Aula04
{
    static void Main()
    {
        Console.WriteLine("Informe as notas do alunos...");
        // Primeira nota 
        Console.Write("Nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        // Segunda nota
        Console.Write("Nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        // Terceira nota 
        Console.Write("Nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        // Quarta nota 
        Console.Write("Nota 4: ");
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine("A média do aluno é: "+ media + ".");
    }
}