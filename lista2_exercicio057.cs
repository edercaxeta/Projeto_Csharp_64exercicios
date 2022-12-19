using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*57) Fazer um programa que leia uma frase e imprima somente as vogais. */

            Console.WriteLine("====Imprima somente as vogais====");
            Console.WriteLine("=================================");
            Console.WriteLine();

            string frase;
            string vogais = "aeiouAEIOU";
            string soVogais = " ";

            Console.WriteLine ("Digite uma frase: ");
            frase = Console.ReadLine();

            char[] vetor = frase.ToCharArray();

            for (int x = 0; x < vetor.Length; x++)
            {
                if (vogais.Contains("" + vetor[x]))
                { 
                    soVogais += vetor[x];
                }
            }

            Console.WriteLine ("As vogais são: {0} " , soVogais);
            Console.ReadLine();
        }
    }
}
