using System;

namespace Aula18
{
    class Aula18
    {
        static void Main()
        {
            Console.Clear();
            int[,] n = new int[2, 3];
            int[,] num = new int[2, 2]{{1, 2}, {3, 4}};

            n[0, 0] = 1;    n[0, 1] = 2;    n[0, 2] = 3;
            n[1, 0] = 1;    n[1, 1] = 2;    n[1, 2] = 3;

            Console.Write(n[0, 0] + " - " + n[0, 1] + " - " + n[0, 2] + "\n");
            Console.Write(n[1, 0] + " - " + n[1, 1] + " - " + n[1, 2] + "\n");

        }
    }
}