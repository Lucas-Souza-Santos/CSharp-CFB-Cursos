using System;
// Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e 
// mostre o total do seu salário no referido mês.

class Ex008
{
    static void Main()
    {
        // ganho por hora
        Console.Write("Valor ganho por hora: ");
        double quantia_por_hora = double.Parse(Console.ReadLine());

        // tempo trabalhado por mês
        Console.Write("Numero de horas por mês: ");
        int dias_trabalhado = int.Parse(Console.ReadLine());

        double salario = quantia_por_hora * dias_trabalhado; 

        Console.WriteLine("Salario Por Hora: {0} R$\nTempo por Mês: {1} dias \nSalario: {2} R$", quantia_por_hora, 
        dias_trabalhado, salario.ToString("F"));
    }
}