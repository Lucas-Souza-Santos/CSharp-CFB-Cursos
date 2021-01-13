using System;
/*
Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. 
Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda,
 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:

    salário bruto.
    quanto pagou ao INSS.
    quanto pagou ao sindicato.
    o salário líquido.
    calcule os descontos e o salário líquido, conforme a tabela abaixo:

    + Salário Bruto : R$
    - IR (11%) : R$
    - INSS (8%) : R$
    - Sindicato ( 5%) : R$
    = Salário Liquido : R$

    Obs.: Salário Bruto - Descontos = Salário Líquido. 
*/

namespace Estrutura_Sequencial
{
    class Ex015
    {
        static void Main()
        {
            Console.Write("Salário por hora: ");
            double salarioPH = double.Parse(Console.ReadLine());

            Console.Write("Tempo trabalhado por mês: ");
            double TempoTM = int.Parse(Console.ReadLine());

            double salario = salarioPH * TempoTM;
            double desconto = salario * (0.11 + 0.08 + 0.05);

            Console.WriteLine("+ Salário Bruto : {0} R$ ", salario);
            Console.WriteLine("- IR (11%) : {0} R$", (salario * 0.11).ToString("F"));
            Console.WriteLine("- INSS (8%) : {0} R$", (salario * 0.08).ToString("F"));
            Console.WriteLine("- Sindicato ( 5%) : {0} R$", (salario * 0.05).ToString("F"));
            Console.WriteLine("= Salário Liquido : {0} R$", (salario - desconto).ToString("F"));
        }
    }
}