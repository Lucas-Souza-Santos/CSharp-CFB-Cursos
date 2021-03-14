using System;

namespace Aula31
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Lucas = new Pessoa();
            Lucas.nome = "Lucas";

            Console.WriteLine("Nome: " + Lucas.nome);
        }
    }
}
