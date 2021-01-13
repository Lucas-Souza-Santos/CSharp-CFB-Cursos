using System;
/*
    Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal,
    utilizando as seguintes fórmulas:
    Para homens: (72.7*h) - 58
    Para mulheres: (62.1*h) - 44.7
*/

namespace Estrutura_Sequencial
{
    class Ex013
    {
        static void Main()
        {
            Console.Write("Informe o sexo[M/F]: ");
            string sexo = Console.ReadLine();

            Console.Write("Agora informe a altura: ");
            double h = double.Parse(Console.ReadLine());
            double peso;

            if(sexo[0] == 'M' || sexo[0] == 'm')
            {
                Console.WriteLine("Peso ideal para um homem ");
                peso = (72.7 * h) - 58;

            }
            else
            {
                Console.WriteLine("Peso ideal para uma mulher ");
                peso = (62.1 * h) - 44.7;
            }

            Console.WriteLine("Peso ideal: {0} Kg", peso.ToString("F"));

        }
    }
}