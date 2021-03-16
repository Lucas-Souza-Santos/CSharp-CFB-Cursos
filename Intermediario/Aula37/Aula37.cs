using System;

namespace Aula37
{
    class Aula37
    {
        static void Main()
        {
            Console.Clear();
            Derivada2 d2 = new Derivada2();
        }
    }

    class Base
    {
        public Base()
        {
            Console.WriteLine("Classe Base");
        }
    }

    class Derivada1: Base
    {
        public Derivada1()
        {
            Console.WriteLine("Derivada 1");
        }
    }

    class Derivada2: Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Derivada 2");
        }
    }
}