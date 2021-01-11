using System;
// Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.

class Exercicios
{
    static void Main()
    {
        Console.Write("Informe o lado do quadrado: ");
        double lado = double.Parse(Console.ReadLine());

        double area = Math.Pow(lado, 2);
        
        Console.WriteLine("Area = {0} dobro da area = {1}.", area.ToString("F"), (2 * area).ToString("F"));
    }
}
