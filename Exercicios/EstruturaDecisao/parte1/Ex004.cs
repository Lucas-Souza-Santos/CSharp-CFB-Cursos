using System;
// Faça um Programa que verifique se uma letra digitada é vogal ou consoante.

namespace EstruturaDecisao
{
    class Ex004
    {
        static void Main()
        {
           Console.WriteLine("Verifica se a letra é vogal ou consoante");
           Console.Write("Informe a letra: ");
           String letra = Console.ReadLine().ToUpper();
           char l = Char.Parse(letra);

            if(l == 'A' || l == 'E' || l == 'I' || l == 'O' || l == 'U')
            {
                Console.WriteLine("A letra informada é uma VOGAL!!!");
            }
            else 
            {
                Console.WriteLine("A letra informada é uma CONSOANTE!!!");
            }
        }
    }
}