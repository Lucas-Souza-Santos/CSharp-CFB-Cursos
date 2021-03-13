using System;
// Faça um Programa que leia três números e mostre-os em ordem decrescente
namespace EstruturaDecisao
{
    class Ex009
    {
        static void Main()
        {
            Console.WriteLine("===== Order decrescente ====");
            Console.WriteLine("... Informe três números");
            Console.Write("... ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("... ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("... ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;
            int meio  = num2;
            int menor = num3;

            if(num1 > num2 && num1 > num3)
            {
                if(num3 > num2)
                {
                    meio = num3;
                    menor = num2;
                }
                if(num2 > num3)
                {
                    meio = num2;
                    menor = num3;
                }
                
            }

            if(num2 > num1 && num2 > num3)
            {
                maior = num2;
                if(num3 > num1)
                {
                    meio = num3;
                    menor = num1;
                }
                if(num1 > num3)
                {
                    meio = num1;
                    menor = num3;
                }
            }
            if(num3 > num1 && num3 > num2)
            {
                maior = num3;
                if(num2 > num1)
                {
                    meio = num2;
                    menor = num1;
                }
                if(num1 > num2)
                {
                    meio = num1;
                    menor = num2;
                }
            }

            Console.WriteLine("{0} << {1} << {2}", maior, meio, menor);

        }
    }
}