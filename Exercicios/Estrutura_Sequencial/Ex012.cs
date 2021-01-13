using System;
/*
    Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal,
    usando a seguinte fórmula: (72.7*altura) - 58 
    
*/

namespace Estrutura_Sequencial
{
    class Ex012
    {
        static void Main()
        {
            double peso;

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            peso = (72.7*altura) - 58;

            Console.WriteLine("O peso ideal para uma pessoa de {0}m é {1}Kg", altura, peso);
            


        }
    }
}