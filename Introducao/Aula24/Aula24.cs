using System;

namespace Aula24
{
    class Aula24
    {
        static void Main()
        {
            Console.Clear();
            for(int i = 0; i < 1; i++)
            {
                int somaValor = soma(4, 5);
                Console.Write(somaValor);
            }
        }
        
        // o nosso método precisa ser estatico, já que o metodo principal é estatico
        static int soma(int a, int b)
        {
             int soma = a + b;
             return soma;
        }
    }
}