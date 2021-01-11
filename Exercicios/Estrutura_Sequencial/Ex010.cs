using System;
// Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Fahrenheit. 
class Ex010
{
    static void Main()
    {
        Console.Write("Informe a temperatura em Celsius: ");
        double temperatura_celsius = double.Parse(Console.ReadLine());

        double temperatura_fahrenheit = (9 * (temperatura_celsius) / 5) + 32;

        Console.WriteLine("Temperatura Fahrenheit: {1} - Temperatura Celsius: {0}"
        , temperatura_fahrenheit, temperatura_celsius);
    }
}