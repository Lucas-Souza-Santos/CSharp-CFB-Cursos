using System;

namespace aula03{

    class Aula03{

        static void Main(string[] args){

            // o C# é uma linguagem fortemente tipada
            // byte n1 = 10;
            // esse tipo armazena valores de até 8 bits
            // int num = -10;
            // esse tipo armazena valores inteiros de até 32 bits
            // float valor = 5.3f;
            // valores do tipo float
            // os compiladores já inicia as variáveis do tipo numericos com o valor zero 
            // char letra = "L";
            // armazena caracteres
            // string nome = "Lucas";
            // armazena qualquer texto

            var aux = "CFB Cursos";
            // aux vai ser uma variável que quando compilada ela vai receber o tipo string

            int num1 = 10, num2 = 12;

            Console.Write(aux);
            Console.Write("A multiplicação de " + num1 + " mais " + num2 + " é igual a: " + num1);

        }
    }

}
