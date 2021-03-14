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
                vetor1[i] = random.Next(50);
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
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);
            foreach (var item in vetor2)
            {
                Console.Write(item);
            }
            Console.WriteLine("---------------------------------------------");

            // public void CopyTo(Ar_destino, a_partir_desta_pos);
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);
            foreach (var item in vetor3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n---------------------------------------------");

            // public long GetLongLength(dimensão)
            Console.WriteLine("GetLongLength");
            long qtdeElementosVetor1 = vetor1.GetLongLength(0);
            Console.WriteLine("\n---------------------------------------------");

            //public int GetLowerBound(dimensão)
            Console.WriteLine("GetLowerBound");
            int MenorIndiceVetor = vetor1.GetLowerBound(0);
            int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
            Console.WriteLine("Menor indice do valor1 {0}", MenorIndiceVetor);
            Console.WriteLine("\n---------------------------------------------");

            //public int GetUpperBound(dimensão)
            Console.WriteLine("GetUpperBound");
            int MaiorIndiceVetor = vetor1.GetUpperBound(0);
            int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
            Console.WriteLine("Maior indice do vetor1 {0}", MaiorIndiceVetor);
            Console.WriteLine("\n---------------------------------------------");

            //public object GetValue(long indice)
            Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
            Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
            Console.WriteLine("---------------------------------------------");
            
            //public static int IndexOf(array, valor);
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1, 3);
            Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
            Console.WriteLine("---------------------------------------------");

            //public static int LastIndexOf(array, valor);
            Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(vetor1, 3);
            Console.WriteLine("Indice do último valor 33:{0}", indice1);
            Console.WriteLine("---------------------------------------------");

            //public static void Reverse(array);
            Array.Reverse(vetor1);
            foreach (var item in vetor1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n---------------------------------------------");

            //public void SetValue(object valor, long pos);
            vetor2.SetValue(99, 0);
            for(int i = 0; i < vetor2.Length; i++)
            {
                vetor2.SetValue(0, i);
            }
            Console.WriteLine("Vetor 2");
            foreach (var item in vetor2)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n---------------------------------------------");

            // public static void Sort(array);
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("Vetor1");
            foreach (var item in vetor1)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n---------------------------------------------");
        }
    }
}