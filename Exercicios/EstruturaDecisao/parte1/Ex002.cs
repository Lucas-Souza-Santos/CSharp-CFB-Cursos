using System;
// Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.

namespace EstruturaDecisao
{
    class Ex002
    {
        static void Main()
        {
            Console.Write("Informe um número: ");
            double num = double.Parse(Console.ReadLine());

            string resposta = (num >= 0) ? "Positivo": "Negativo";

            Console.WriteLine("O número informado é " + resposta + "."); 
        }
    }
}

