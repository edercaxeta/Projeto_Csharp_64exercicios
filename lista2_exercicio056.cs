using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*56) Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a 
             * quantidade de números pares e de múltiplos de 5. */

            Console.WriteLine("====Numeros pares e multiplos de 5====");
            Console.WriteLine("======================================");
            Console.WriteLine();

            int[] numero = new int[50];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write("Digte {0}° numero: ", i + 1);
                numero[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nEsses são os numeros pares: ");
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] % 2 == 0)
                {
                    Console.Write(" "+ numero[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nEsses são os numeros multiplos de 5: ");
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] % 5 == 0)
                {
                    Console.Write(" "+ numero[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
