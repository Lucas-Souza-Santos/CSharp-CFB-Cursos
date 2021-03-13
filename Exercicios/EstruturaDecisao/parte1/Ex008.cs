using System;
// Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, 
// sabendo que a decisão é sempre pelo mais barato.

namespace EstruturaDecisao
{
    class Ex008
    {
        static void Main()
        {
            Console.WriteLine("===== Preço Mais Barato =====");
            Console.WriteLine("... Informe os preços dos Produtos ");


            Console.Write("... Produto: ");
            String prod1 = Console.ReadLine();            
            Console.Write("... Preço: ");
            float preco1 = float.Parse(Console.ReadLine());
            
            Console.Write("... Produto: ");
            String prod2 = Console.ReadLine();
            Console.Write("... Preço: ");
            float preco2 = float.Parse(Console.ReadLine());
            
            Console.Write("... Produto: ");
            String prod3 = Console.ReadLine();
            Console.Write("... Preço: ");
            float preco3 = float.Parse(Console.ReadLine());

            float menor = preco1;
            string produto = prod1;
            
            if(preco2 < preco1 && preco2 < preco3)
            {
                menor = preco2;
                produto = prod2;
            }
            if(preco3 < preco1 && preco3 < preco2)
            {
                menor = preco3;
                produto = prod3;
            }
            
            Console.WriteLine("     Produto: {0}, Preço: {1}.", produto, menor);

        }
    }
}