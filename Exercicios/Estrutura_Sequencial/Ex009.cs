using System;
// Faça um Programa que peça a temperatura em graus Fahrenheit, transforme e mostre a temperatura em graus Celsius.
//C = 5 * ((F-32) / 9). 

class Ex009
{
    static void Main()
    {
        Console.Write("Informe a temperatura em Fahrenheit: ");
        double temperatura_fahrenheit = double.Parse(Console.ReadLine());

        double temperatura_celsius = (5 * (temperatura_fahrenheit - 32)) / 9;

        Console.WriteLine("Temperatura Fahrenheit: {0} - Temperatura Celsius: {1}"
        , temperatura_fahrenheit, temperatura_celsius);
    }
}
