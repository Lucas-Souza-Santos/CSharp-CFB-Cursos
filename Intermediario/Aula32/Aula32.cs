using System;

namespace Aula32
{
    class Aula32
    {
        static void Main()
        {
            Calculos soma = new Calculos(5, 6);

            int res = soma.Somar();
            Console.WriteLine(res);
        }
    }
}