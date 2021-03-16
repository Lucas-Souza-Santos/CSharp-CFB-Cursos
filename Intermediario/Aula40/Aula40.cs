using System;

namespace Aula40
{
    class Aula40
    {
        static void Main()
        {

        }

        sealed class Veiculo
        {
            public Veiculo()
            {
                Console.WriteLine("Veiculo");
            }
        }

        class Carro : Veiculo
        {
            public Carro()
            {
                Console.WriteLine("Carro");
            }
        }
    }
}