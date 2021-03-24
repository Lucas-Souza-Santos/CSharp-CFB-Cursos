using System;

namespace Aula45
{
    struct Carro
        {
            public string cor; 
            public Carro(string cor)
            {
                this.cor = cor;
            }

            public void info(int n)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Cor do Carro {n}: {this.cor}");
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Carro[] carros = new Carro[5];
            carros[0].cor = "Azul";
            carros[1].cor = "Branco";
            carros[2].cor = "Vermelho";
            carros[3].cor = "Preto";
            carros[4].cor = "Prata";  

            for(int i = 0; i < carros.Length; i++)
            {
                carros[i].info(i);
            }  
            Console.WriteLine("-------------------------");       
        }
    }
}
