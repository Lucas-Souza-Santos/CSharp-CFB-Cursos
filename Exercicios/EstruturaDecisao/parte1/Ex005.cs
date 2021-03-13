using System;
/*
    Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular a média 
    alcançada por aluno e apresentar:

    A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
    A mensagem "Reprovado", se a média for menor do que sete;
    A mensagem "Aprovado com Distinção", se a média for igual a dez.
*/

namespace EstruturaDecisao
{
    class Ex005
    {
        static void Main()
        {
            Console.WriteLine("====== Média dos Alunos ======");

            Console.Write("Nota 1: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;

            if(media >= 7)
            {
                if(media == 10)
                {
                    Console.WriteLine("Aprovado com Distição");
                }
                else
                {
                    Console.WriteLine("Aprovado");
                }
            }
            else 
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}