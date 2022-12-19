using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*45) Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que
             * foi realizada a leitura. */

            Console.WriteLine("==========Ordem Inversa da leitura===========");
            Console.WriteLine("=============================================");
            int quantidade;
            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o {0}° Número: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine ("\nA ordem contrária é:\n");
            for (int i = quantidade-1; i >= 0; i--)
            {
                Console.WriteLine (numeros[i]);
            }
            Console.ReadLine();
        }
    }
}
