using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*31) Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido
             * é par ou ímpar. Exiba ao final a soma total dos números pares lidos e também a soma dos
             * números ímpares lidos. Suporemos que o número de elementos deste conjunto não é conhecido,
             * e que um número negativo será utilizado para sinalizar o fim dos dados. */

            Console.WriteLine("====Conjunto de numeros positivos====");
            Console.WriteLine("=====================================");

            int somapar = 0;
            int somaimpar = 0;
            int numeroFinal = 0;
            while (numeroFinal >= 0)
            {
                Console.WriteLine("\nEnquanto o Numero for Positivo, digite o numero Final: ");
                numeroFinal = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (numeroFinal <= 0)
                {
                    Console.WriteLine("\n{0} é um numero negativo, O programa será encerrado!", numeroFinal);
                    break;
                }
                for (int i = 0; i <= numeroFinal; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("Esse numero é Par:  ");
                        somapar = somapar + i;
                    }
                    else
                    {
                        Console.Write("Esse numero é Impar: ");
                        somaimpar = somaimpar + i;
                    }
                    Console.WriteLine(i);
                    Console.WriteLine("------------------------------");

                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("Soma dos Numeros Pares: {0}", somapar);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Soma dos Numeros Impares: {0}", somaimpar);
                Console.WriteLine("------------------------------");
            }

            Console.WriteLine("\n========================FIM=======================");
            Console.ReadLine();

        }
    }
}
