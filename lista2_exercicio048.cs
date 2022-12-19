using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*48) Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma 
             * modelo que tenha idade entre 18 e 20 anos para participar de uma campanha publicitária
             * milionária de produtos de beleza. Foram inscritas 20 candidatas e, ao se inscreverem,
             * forneceram nome e idade. Tais informações foram armazenadas em 2 vetores distintos.
             * Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a concorrer
             * a uma vaga para a campanha milionária*/

            Console.WriteLine("====Modelo entre 18 e 20 anos====");
            Console.WriteLine("=================================");
            Console.WriteLine();

            decimal[] idade = new decimal[10];
            string[] nome = new string[10];
            int i;

            for (i = 0; i < 20; i++)
            {
                Console.Write("\nDigite o Nome da {0}° candidata: ", i);
                nome[i]= Console.ReadLine();
           
                Console.Write("Digite a idade da {0}° candidata: ", i);
                idade[i] = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEssas são as candidadas aptas: ");
            for (i = 0; i < 20; i++)
            {
                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    Console.Write(":"+ nome[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
