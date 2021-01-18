using System;

namespace Aula22
{
    class Aula22
    {
        static void Main()
        {
            int[] num = new int[3]{11, 22, 33};

            for(int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine("\n-------------------");

            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }
    }
}