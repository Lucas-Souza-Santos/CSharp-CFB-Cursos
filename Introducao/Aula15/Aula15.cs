using System;

namespace Aula15
{
    class Aula14
    {
        static void Main()
        {
            Console.WriteLine("Belo Horizonte/MG e Vitória/ES");
            Console.WriteLine("Escolha o transporte:\n[a] - Avião\n[c] - Carro\n[o] - Ônibus\n");

            int tempo = 0;
            Console.Write(": ");
            char escolha = char.Parse(Console.ReadLine());

            switch(escolha)
            {

                case 'a':
                    tempo = 50;
                    Console.Write("Viagem de Avião!\nTempo estimado: " + tempo + "min!");
                    break;
                case 'c':
                    tempo = 480;
                    Console.Write("Viagem de Carro!\nTempo estimado: " + tempo + "min!");
                    break;
                case 'o':
                    tempo = 660;
                    Console.Write("Viagem de ônibus!\nTempo estimado: " + tempo + "min!");
                    break;
                default:
                    Console.Write("Opção Inválida!\nTransporte Indisponivel.");
                    break;
            }

        }
    }
}