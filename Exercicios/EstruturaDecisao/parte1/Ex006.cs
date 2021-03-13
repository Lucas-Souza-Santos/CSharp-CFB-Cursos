using System; 

// Faça um Programa que leia três números e mostre o maior deles. 

namespace EstruturaDecisao
{
    class  Ex006
    {
        static void Main()
        {
            Console.WriteLine("===== Quem é o MAIOR ? =====");
            
            Console.Write("NUM 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("NUM 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("NUM 3: ");
            int num3 = int.Parse(Console.ReadLine());
        
            int maior = num1;

            if(num2 > num1 && num2 > num3)
            {
                maior = num2;
            }
            if(num3 > num1 && num3 > num2)
            {
                maior = num3;
            }

            Console.WriteLine("O maior valor é " + maior);
        }
    }
}