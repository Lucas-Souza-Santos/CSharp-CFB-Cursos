using System;
/*
    1- Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:

    a.    o produto do dobro do primeiro com metade do segundo .
    b.    a soma do triplo do primeiro com o terceiro.
    c.    o terceiro elevado ao cubo.
*/
class Ex011
{
    static void Main()
    {
        // primeiro numero inteiro 
        Console.Write("Digite um número inteiro: ");
        int num1 = int.Parse(Console.ReadLine());

        // Segundo numero inteiro
        Console.Write("Digite um número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        // Primeiro número real
        Console.Write("Digite um número Real: ");
        double numR = double.Parse(Console.ReadLine());

        // Saídas
        Console.WriteLine("Dobro do Primeiro {0} - Metade do Segundo: {1}", num1 * 2, (double)num2 / 2);
        Console.WriteLine("Soma do Triplo do Primeiro com o Terceiro: {0} ", (3 * (double)num1 + numR).ToString("F"));
        Console.WriteLine("Terceiro elevado ao cubo: {0}", Math.Pow(numR, 3).ToString("F"));    
    }
}