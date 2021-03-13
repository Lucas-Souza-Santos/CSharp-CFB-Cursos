using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            double nota1 = double.Parse(Console.ReadLine());
            while ((nota1 < 0) || (nota1 > 10))
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine());
            }

            double nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine());
            }

            double media = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + media.ToString("N2"));

            int opcao;
            
            while(true)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
                if(opcao == 1 || opcao == 2)
                {
                    break;
                }
            }
            if(opcao == 2)
            {
                break;
            }
        }
    }
}
/**
    N -> número de figurinhas 
    M -> número de figurinhas compradas 
    X -> uma figurinha já comprada

*/