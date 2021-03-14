using System;

namespace Aula27
{
    class Aula27
    {
        static void Main()
        {
            Console.Clear();
            soma();
            soma(1);
            soma(1, 2, 3, 4, 5, 6, 7);
        }

        static void soma(params int[] vetor)
        {
            int res = 0;

            if(vetor.Length == 0)
            {
                Console.WriteLine("Soma sem valores {0}", res);
            }
            if(vetor.Length == 1)
            {
                Console.WriteLine("Valor soma de um número {0}", vetor[0]);
            }
            if(vetor.Length >= 2)
            {
                for(int i = 0; i < vetor.Length; i++)
                {
                    res += vetor[i];                    
                }
                Console.WriteLine("Somando {0} valores é = {1}", vetor.Length, res);
            }
        }
    }
}