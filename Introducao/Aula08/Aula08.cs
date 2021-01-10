using System;
/*
* Aula 08 - Curso de Programação usando C#
* Canal do Youtube: CFB-Cursos-Professor-Bruno
* Assunto da Aula: Ler valores lidos do teclado e passar para dentro de uma variável            
*/ 
    class Aula08{

        static void Main(){
            // o usuário vai digitar os valores de v1 e v2 do teclado que serão somados e jogada dentro de soma
            int v1, v2, soma;
            // a mesma coisa vai acontecer com a variável nome
            string nome;

            // aqui vai ser pedido para o usuário digitar o nome 
            Console.WriteLine("Digite seu nome: ");
            // console.readline vai retornar o valor digitado pelo teclado e será armazenado dentro de nome
            nome = Console.ReadLine();
            // vai ser imprimido o nome do usuário junto com um texto
            Console.WriteLine("Nome digitado foi {0}", nome);

            // o retorno de readline é uma string logo precisando converter os valores para os tipos apropriados
            Console.WriteLine("Digite o Primeiro valor: ");
            // primeira maneira de converter uma string em inteiro
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            // segunda maneira de converter uma string em inteiro
            v2 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2;

            Console.WriteLine("A soma de {0} + {1} é {2}.", v1, v2, soma);
            
        }
}