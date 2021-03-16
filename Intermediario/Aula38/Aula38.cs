using System;

namespace Aula38
{
    class Aula38
    {
            // Métodos virtuais, são métodos que tem o mesmo nome em classes diferentes
        static void Main()
        {
            Console.Clear();
            Base Ref;
            Derivada1 d1 = new Derivada1();
            Derivada2 d2 = new Derivada2();
            Console.WriteLine("------------");

            // d2.Info();

            Ref = d1;
            Ref.Info();
        }
    }

    class Base
    {
        public Base()
        {
            Console.WriteLine("Classe Base");
        }
        virtual public void Info()
        {
            Console.WriteLine("Base");
        }
    }

    class Derivada1: Base
    {
        public Derivada1()
        {
            Console.WriteLine("Derivada 1");
        }
        // coloquei numa classe derivada o mesmo nome em método da classe base
        public override void Info()
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
        public override void Info()
        {
            Console.WriteLine("Derivada 2");
        }
    
    }
}