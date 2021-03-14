using System;

namespace Aula25
{
    class Aula25
    {
        static void Main()
        {
            Console.Clear();
            int num = 10;
            dobrar(ref num);
            Console.WriteLine("Dentro da Main {0}.", num);
            
        }

        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}