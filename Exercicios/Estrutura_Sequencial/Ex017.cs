using System;
/*
Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada.
Considere que a cobertura da tinta é de 1 litro para cada 6 metros quadrados e que a tinta é vendida em latas de 18 
litros, que custam R$ 80,00 ou em galões de 3,6 litros, que custam R$ 25,00.
    Informe ao usuário as quantidades de tinta a serem compradas e os respectivos preços em 3 situações:
    - comprar apenas latas de 18 litros;
    - comprar apenas galões de 3,6 litros;
    - misturar latas e galões, de forma que o desperdício de tinta seja menor. 
    Acrescente 10% de folga e sempre arredonde os valores para cima, isto é, considere latas cheias. 
*/
namespace Estrutura_Sequencial
{
    class Ex017
    {
        static void Main()
        {
            Console.Write("Área da Parede: ");
            double area = double.Parse(Console.ReadLine());

            double num_lata  = Math.Ceiling(area / (6 * 18));
            double num_galao = Math.Ceiling(area / (6 * 3.6));

            double custo_lata = num_lata * 80;
            double custo_galao = num_galao * 25;

            Console.WriteLine("Quantidade Latas:........ {0}\nPreço:...... {1}",num_lata, custo_lata.ToString("F"));
            Console.WriteLine("Quantidade Galões:....... {0}\nPreço:...... {1}",num_galao, custo_galao.ToString("F"));
            //Console.WriteLine("Quantidade Latas:  {0} - Preço: {1}",num_lata, custo.ToString("F"));

        }
    }
}