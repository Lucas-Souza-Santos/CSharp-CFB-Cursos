using System;

namespace Aula30
{
    class Jogador
    {
        private const string Value = "... Atleta Confirmado";
        String nome;
        String esporte; 
        String equipe;
        String categoria;
        int idade;

        public Jogador() => Console.WriteLine(value: Value);
        public Jogador(String nome, String esporte, String equipe, String categoria, int idade)
        {
            this.nome = nome;
            this.esporte = esporte;
            this.equipe = equipe;
            this.categoria = categoria;
            this.idade = idade;
            Console.WriteLine(value: Value);
        }

        public void Info()
        {
            Console.WriteLine("========== ATLETA DO CLUBE ===============");
            Console.WriteLine($"... {this.nome}");
            Console.WriteLine($"... {this.categoria}");
            Console.WriteLine($"... {this.idade} Anos");
            Console.WriteLine($"... {this.equipe}");
            Console.WriteLine($"... {this.esporte}");
            Console.WriteLine("==========================================");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Jogador Lucas = new Jogador();
            Jogador Fernando = new Jogador("Fernando", "Futebol", "Santa Cruz F.C", "Junior", 16);

            Fernando.Info();

            Jogador Marcelo = new Jogador("Marcelo", "Baskete", "Flamengo", "Profissional", 30);
            Marcelo.Info();
            
        }
    }
}
