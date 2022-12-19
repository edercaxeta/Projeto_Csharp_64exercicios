using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*49) Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine
             * e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições. */

            Console.WriteLine("=======Vetores idênticos=======");
            Console.WriteLine("===============================");
            Console.WriteLine();

            int n = 0;
            Console.Write("Digite o numero de componentes: ");
            n = int.Parse(Console.ReadLine());
            while(n < 1 || n > 50)
            {
                Console.WriteLine("\nNumero acima do permitido, Repita! ");
                n = int.Parse(Console.ReadLine());
            }

            int[] v1 = new int[n];
            int[] v2 = new int[n];
            for ( int i = 0; i < n; i++)
            {
                Console.Write("\nDigite o {0}° numero para v1: ",i + 1);
                v1[i] = int.Parse(Console.ReadLine());
                Console.Write("Digite o {0}° numero para v2: ",i + 1);
                v2[i] = int.Parse(Console.ReadLine());
               
            }
                        
            for(int i = 0; i < n; i++)
            {
               if(v1[i] == v2[i])
                {
                    Console.WriteLine("Posição: {0}", i + 1);
               }
            }
            Console.ReadLine();
        }
    }
}
