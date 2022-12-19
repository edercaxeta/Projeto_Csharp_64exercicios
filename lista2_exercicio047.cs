using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*47) Considere um vetor de 10 números inteiros positivos maiores que zero e um único número 
             * inteiro, também positivo e maior que zero. Faça um programa para: 
             * a. ler pelo teclado o vetor; 
             * b. ler pelo teclado o número X; 
             * C. dizer quantos números no vetor são maiores que X, menores que X e iguais a X. */

            Console.WriteLine("Comparar um vetor de 10 numero ao numeroX");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            int[] numero = new int[10];
            int maior = 0, menor = 0, igual = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o {0}° numero: ", i+1);
                numero[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite o numeroX: ");
            int numeroX = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (numero[i] > numeroX)
                {
                    maior++;
                }
                else if (numero[i] < numeroX)
                {
                    menor++;
                }
                else
                {
                    menor++;
                }
            }

            Console.WriteLine("\n{0} numeros são maiores que numeroX", maior);
            Console.WriteLine("{0} numeros são menores que numeroX", menor);
            Console.WriteLine("{0} numeros são iguais a numeroX", igual);
            Console.ReadLine();
        }
                
    }
}
