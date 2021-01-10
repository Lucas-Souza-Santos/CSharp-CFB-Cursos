using System;
/*
* Aula 06 - Curso de Programação usando C#
* Canal do Youtube: CFB-Cursos-Professor-Bruno
* Assunto da Aula: Formatando a saída no console           
*/ 

class Aula06{

    static void Main(){
        int n1, n2, n3;
        

        n1 = 10; n2 = 20; n3 = 30;

        // Maneiras de imprimir dados no C# 
        // Primeira maneira:
        Console.WriteLine("n1 = " + n1 + " n2 = " + n2 + " n3 = " + n3);
        // Segunda maneira:
        Console.WriteLine("n1 ={0} n2 = {1} n3 = {2} ", n1, n2, n3);
        
        // formatação em forma monetária, porcentagem 
        // variáveis que serão formatada da maneira descrita a cima
        double valorCompra = 5.50, valorVenda, lucro = 0.1;
        // string opcional
        string Produto = "pastel";

        // calculo do valor de vendas, destaco que não é a maneira de calcular, mas é só um exemplo
        valorVenda = valorCompra + (valorCompra * lucro);
        // para pular um número de espaços em branco, no exemplo 15, dentro da chave colocamos 0,
        // e o valor do espaço que será pulado
        Console.WriteLine("Produto......:{0,15}", Produto);
        // imprimindo na formatação monetária do tipo R$, o :c é importante, é ele que diz para o compilador o tipo de
        // formatação que deve ser imprimido
        Console.WriteLine("Val.Compra...:{0,15:c}", valorCompra);
        // imprimindo na formatação de porcentagem, o :p é importante
        Console.WriteLine("Lucro........:{0,15:p}", lucro);
        // aqui segue a mesma idéia do exemplo a cima
        Console.WriteLine("Val.Venda....:{0,15:c}", valorVenda);

        // csc nome_programa para compilar 
        // .\nome_programa.exe para mostrar na tela

        }
}
