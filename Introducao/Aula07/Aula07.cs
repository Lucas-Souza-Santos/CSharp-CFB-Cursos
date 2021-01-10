using System;
/*
* Aula 07 - Curso de Programação usando C#
* Canal do Youtube: CFB-Cursos-Professor-Bruno
* Assunto da Aula: Constantes
* Diferente das declarações de variáveis, as constantes não podem mudar de valor durante o andamento do código          
*/ 
    class Aula07{

        static void Main(){
            const string canal = "CFB Cursos";
            const double pi = 3.1415;

            Console.WriteLine("constantes {0} e {1}",canal, pi);
            
        }
}