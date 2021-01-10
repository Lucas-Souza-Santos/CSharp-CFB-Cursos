using System;
// Faça um Programa que converta metros para centímetros.

class Exercicios
{
    static void Main()
    {   
        // Pedindo pro usuário digitar o metro e pegando o valor e armazenando na variavel metro
        Console.Write("Informe o metro para ser convertido: ".ToUpper());

        float metro = float.Parse(Console.ReadLine());

        float centimetro = (metro * 100);

        Console.WriteLine("{0}m = {1}cm", metro, centimetro); 
    }
}
