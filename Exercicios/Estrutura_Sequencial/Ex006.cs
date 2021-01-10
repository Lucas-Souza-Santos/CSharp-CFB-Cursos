using System;
// Faça um Programa que peça o raio de um círculo, calcule e mostre sua área

class Exercicios
{
    static void Main()
    {
        Console.WriteLine("Informe o Raio do Circulo: ");
        double raio = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine("A área do circulo de raio de {0} u é {1} u^2.", raio, area.ToString("F")); 
    }
}