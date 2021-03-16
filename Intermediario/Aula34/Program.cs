using System;

namespace Aula34
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo(120, true);

            Console.WriteLine(v.getLigado());
            v.setVelMax(400);
            Console.WriteLine(v.getVelMax());

            Carro c = new Carro(200, false);

            Console.WriteLine("Carro");
            Console.WriteLine(c.getLigado());

        }
    }
}
