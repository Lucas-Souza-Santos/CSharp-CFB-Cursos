using System;

namespace Aula17
{
    class Aula17
    {
        static void Main()
        {
            Console.Clear();
            // declaração de um Array
            int[] n = new int[5];
            // dessa forma o array é declarado e inicializado ao mesmo tempo
            int[] o = new int[5]{22, 33, 44, 55, 66};
            int[] m = {22, 33, 44, 55, 66, 77}; 
            string[] veiculos = new string[3];
            
            
            // preechendo as posições do vetor n
            n[0] = 1; n[1] = 2; n[2] = 3; n[3] = 4; n[4] = 5;
            veiculos[0] = "carro"; veiculos[1] = "Avião"; veiculos[2] = "navio";

            // imprimindo os valores do array n
            Console.Write(n[0] + "-");
            Console.Write(n[1] + "-");
            Console.Write(n[2] + "-");
            Console.Write(n[3] + "-");
            Console.Write(n[4] + "\n");

            Console.Write("{0} - {1} - {2}",veiculos[0],veiculos[1],veiculos[2]);
        }
    }
}