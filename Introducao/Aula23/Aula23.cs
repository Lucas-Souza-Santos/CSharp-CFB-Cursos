using System;

namespace Aula23
{
    class Aula23
    {
        static void Main()
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5]{{11, 22, 33, 44, 55}, {66, 77, 88, 99, 00}};

            Random random = new Random();
            for(int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(50, 100);
            }

            Console.WriteLine("Elementos do vetor 1");
            foreach (var item in vetor1)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");

            // public static int BinarySearch(array, valor);
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int pos = Array.BinarySearch(vetor1, procurado);
            if(pos == -1)
            {
                Console.WriteLine("O valor {0} não foi encontrado!", procurado);
            }
            else
            {                
                Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
            }
            Console.WriteLine("---------------------------------------------");

            //public static void copy(Ar_origem, Ar_destino, qtde_elementos);
            Console.WriteLine("");
        
        
        }
    }
}