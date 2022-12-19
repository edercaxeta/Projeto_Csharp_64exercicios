using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*54) Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C que imprima
             * todos os elementos comuns aos dois vetores.*/

            Console.WriteLine("====Imprima os Elementos Comuns====");
            Console.WriteLine("===================================");
            Console.WriteLine();
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[8];
            int i,c;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite {0}° numero do vetor1: ", i + 1);
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (i = 0; i < 8; i++)
            {
                Console.Write("Digite {0}° numero do vetor2: ", i + 1);
                vetor2[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("Esses são os elementos comuns aos dois vetores: ");
            for (i = 0; i < 5; i++)
                for ( c = 0; c< 8; c++)
                    if (vetor1[i] == vetor2[c])
                    {
                        Console.Write(" "+ vetor2[c]);
                    }

            Console.ReadLine();
        }
    }
}
