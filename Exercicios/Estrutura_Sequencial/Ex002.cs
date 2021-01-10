using System;
    // Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número] 
class Exercicios{
    static void Main(){
        Console.WriteLine("Informe um número: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("O numero informado foi [" + num + "]");
    }
}