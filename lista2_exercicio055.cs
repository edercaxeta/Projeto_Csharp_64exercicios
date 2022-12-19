using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*55) Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os
             * espaços em branco. Imprimir também a quantidade de espaços em branco da frase. */

            Console.WriteLine("=========Imprima o Texto=========");
            Console.WriteLine("=================================");
            Console.WriteLine();

            String frase;
            String novaFrase = " ";
            int i;
            int espaco = 0;

            do
            {
                Console.WriteLine("Digite uma frase de até 50 characteres:");
                frase = Console.ReadLine();
            } while (frase.Length > 50);

            char[] vetor = frase.ToCharArray();

            for ( i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != ' ')
                {
                    novaFrase += vetor[i];
                }
                if (vetor[i] == ' ')
                {
                    espaco++;
                }
            }
            Console.WriteLine("\nNova frase: {0}", novaFrase);
            Console.WriteLine("\nA quantidade de espaço em branco é: {0}", espaco);
            Console.ReadLine();
        }
    }
}
