using System;

// Faça um Programa que pergunte em que turno você estuda. Peça para digitar M-matutino ou V-Vespertino ou N- Noturno.
//  Imprima a mensagem "Bom Dia!", "Boa Tarde!" ou "Boa Noite!" ou "Valor Inválido!", conforme o caso. 
namespace EstruturaDecisao
{
    class Ex010
    {
        static void Main()
        {
            Console.WriteLine("===== Turno =====");
            Console.WriteLine("... Qual turno você estuda ?");
            Console.WriteLine("... M-matutino\n... V-Vespertino\n... N-Noturno");

            Console.Write("... ");
            char l = char.Parse(Console.ReadLine().ToUpper());
            
            if(l == 'M')
            {
                Console.WriteLine("... Boa dia!");
            }
            if(l == 'V')
            {
                Console.WriteLine("... Boa tarde!");
            }
            if(l == 'N')
            {
                Console.WriteLine("... Boa Noite!");
            }
        }
    }
}