using System;

namespace Aula29
{
    public class Jogador
    {
        public int energia;
        public bool vivo;

        public Jogador()
        {
            this.energia = 100;
            this.vivo = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jogador Lucas = new Jogador();

            Console.Write(Lucas.energia);
        }
    }
}
