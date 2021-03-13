using System;
// Faça um Programa que leia três números e mostre o maior e o menor deles. 

namespace EstruturaDecisao
{
    class Ex007
    {
        static void Main()
        {
            Console.WriteLine("===== Maior e Menor ? =====");
            Console.WriteLine("-> Informe Três números: ");
            Console.Write("-> ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("-> ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("-> ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;
            int menor = num1;
            if(num2 > num1 && num2 > num3)
            {
                maior = num2;
            }
            if(num3 > num1 && num3 > num2)
            {
                maior = num3;
            }
            if(num2 < num1 && num2 < num3)
            {
                menor = num2;
            }
            if(num3 < num1 && num3 < num2)
            {
                menor = num3;
            }
        
            Console.WriteLine("     Maior  " + maior);
            Console.WriteLine("     Menor  " + menor);
        }

    }
}
