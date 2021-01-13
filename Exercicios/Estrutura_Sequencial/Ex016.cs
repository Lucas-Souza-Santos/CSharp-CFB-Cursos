using System;
/*
Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada.
 Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 
 litros, que custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total. 
*/
namespace Estrutura_Sequencial
{
    class Ex016
    {
        static void Main()
        {
            Console.Write("Área da parede: ");
            double area = double.Parse(Console.ReadLine());

            double num_lata = Math.Ceiling(area / 18);

            double custo = num_lata * 80;

            Console.WriteLine("Quantidade Latas: {0} - Preço: {1}",num_lata, custo.ToString("F"));
        }
    }
}
