using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*34) Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior.
             * Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo 
             * será utilizado para sinalizar o fim dos dados. */

            Console.WriteLine("====Conjunto de numeros positivos, Exiba o maior e o menor====");
            Console.WriteLine("=====================================");

            int numeroFinal = 0;
            int numero = 0;
            int maior = 0;
            int menor = 0;

            do
            {
                Console.WriteLine("\nDigite quantos numeros você quer analisar");
                numeroFinal = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (numeroFinal <= 0)
                {
                    Console.WriteLine("\nO programa será encerrado!");
                    break;
                }
                for (int i = 0; i < numeroFinal; i++)
                {
                    Console.WriteLine("Digite o numero");
                    numero = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        maior = numero;
                        menor = maior;
                    }
                    else if (numero > maior)
                    {
                        maior = numero;
                    }
                    else if (numero < menor)
                    {
                        menor = numero;
                    }

                }
                Console.WriteLine("O numero menor é {0} e o maior é {1}", menor, maior);
            } while (numeroFinal >= 0);
            
            Console.WriteLine("\n========================FIM=======================");
            Console.ReadLine();
        }
    }
}
