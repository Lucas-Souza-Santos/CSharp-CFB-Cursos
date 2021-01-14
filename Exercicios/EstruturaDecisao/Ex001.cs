using System;
/*
Faça um Programa que peça dois números e imprima o maior deles.
*/

namespace EstruturaDecisao
{
    class Ex001
    {
        static void Main()
        {
            //  Primeiro número:
            Console.Write("Digite um número: ");
            double num1 = double.Parse(Console.ReadLine());

            // Segundo número: 
            Console.Write("Digite outro número: ");
            double num2 = double.Parse(Console.ReadLine());

            double maior = num1 > num2 ? num1: num2;

            Console.WriteLine("Entre {0} e {1} o maior é {2}!", num1, num2, maior);
        }
    }
}
