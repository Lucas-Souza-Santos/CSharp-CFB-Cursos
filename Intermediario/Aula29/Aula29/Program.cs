using System;

namespace Aula29
{
    public class Jogador
    {
        public int energia;
        public bool vivo;

    // método construtor
        public Jogador()
        {
            this.energia = 100;
            this.vivo = true;
        }
    // método destrutor
        	~Jogador()
            {
                Console.WriteLine("Jogador foi destruido");
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Jogador Lucas = new Jogador();

            Console.Write(Lucas.energia);
        }
    }
}
