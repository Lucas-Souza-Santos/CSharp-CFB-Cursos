using System;

namespace Aula13
{
    class aula13
    {
        static void Main()
        {
            // Digitando a nota 1
            Console.Write("Informe a nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            // Digitando a nota 2 
            Console.Write("Informe a nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            // Digitando a nota 3 
            Console.Write("Informe a nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            // Digitando a nota 4
            Console.Write("Informe a nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4; 

            if(media >= 7)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else if(media >= 5)
            {
                Console.WriteLine("Aluno Em Recuperação!");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
            }


        }
    }
}