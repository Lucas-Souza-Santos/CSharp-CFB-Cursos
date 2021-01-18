using System;

namespace Aula19
{
    class Aula19
    {
        static void Main()
        {
            Console.Clear();
            int[] num = new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            for(int i = 0; i < 10; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            
            foreach (var item in num)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine();

            for(int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}