using System;
// Faça um Programa que verifique se uma letra digitada é 
// "F" ou "M". Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido. 

namespace EstruturaDecisao
{
    class Ex003
    {
        static void Main()
        {
            Console.Write("Informe o seu Sexo: ");
            char sexo = char.Parse(Console.ReadLine());

            if(sexo == 'M' || sexo == 'm')
            {
                Console.WriteLine("M - Masculino");
            }else if(sexo == 'F' || sexo == 'f')
            {
                Console.WriteLine("F - Feminino");
            }
            else
            {
                Console.WriteLine("Sexo Invalido");
            }

        }
    }
}