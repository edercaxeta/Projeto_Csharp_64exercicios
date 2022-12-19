using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*51) Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N alunos 
             * e calcular a média aritmética das notas. Contar quantos alunos estão com a nota acima de 7.0.
             * Obs.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem: Não há nenhum aluno com 
             * nota acima de 5. */

            Console.WriteLine("==Calcular media Aritimetica das Notas==");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.Write("Digite a quantidade de alunos: ");
            int numeroN = int.Parse(Console.ReadLine());
            Console.WriteLine();

            decimal[] nota = new decimal[numeroN];
            decimal soma = 0;
            int i;
            int contaMenor = 0, contaMaior = 0;
            for (i = 0; i < numeroN; i++)
            {
                Console.Write("Digite a nota do {0}° aluno: ", i + 1);
                nota[i] = decimal.Parse(Console.ReadLine());
                if (nota[i] >= 7)
                    contaMaior++;

                if (nota[i] < 5)
                    contaMenor++;
                if (contaMenor == numeroN)
                    Console.WriteLine("\nNão há nenhum aluno com nota acima de 5.");

                soma = soma + nota[i];
            }
            Console.WriteLine("\nUm total de {0} estão com a nota acima de 7.", contaMaior);
            decimal media = soma / numeroN;
            Console.WriteLine("\nA media das notas é: {0} ", media.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
