using System;

namespace Aula44
{
    class Program
    {
        struct Carro
        {
            public string marca;
            public string modelo;
            public string cor; 
            public Carro(string marca, string modelo, string cor)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
            }
        }
        static void Main(string[] args)
        {
            Carro c1 = new Carro("VW", "Golf", "Branco");
            Console.Clear();
            Console.WriteLine($"Marca: {c1.marca} \nModelo: {c1.modelo} \nCor: {c1.cor} ");
        }
    }
}
