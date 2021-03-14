using System;

namespace Aula28
{
    class Jogador{
        public int energia;
        public bool vivo;

        public Jogador(int e, bool v)
        {
            this.energia = e;
            this.vivo = v;
            Console.WriteLine("Jogador Criado");
        }
        public Jogador()
        {
            Console.WriteLine("Jogador Criado");
        }
        
    }
    class Aula28
    {
        static void Main()
        {
            Jogador Lucas = new Jogador();
           
        }
    }

}
