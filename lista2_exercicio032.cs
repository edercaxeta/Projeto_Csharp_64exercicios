using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*32) Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números 
             * inteiros positivos ímpares a partir do número informado pelo usuário menor que 10 e maior 
             * que zero. */

            Console.WriteLine("Soma do quadrado dos 20 primeros Impares");
            Console.WriteLine("========================================");

            int numeroinicial = 0;
            int resultado = 0;
            int resultado2 = 0;

            Console.WriteLine("Digite o numero inicial: ");
            numeroinicial = int.Parse(Console.ReadLine());

            while (numeroinicial < 0 && numeroinicial > 10)
            {
                Console.WriteLine("O numero Inicia tem que ser >0 e <10, REPITA");
                numeroinicial = int.Parse(Console.ReadLine());

            }

            for (int i = numeroinicial; i < numeroinicial + 40; i++)
            {
                if (i % 2 == 1)
                {
                    resultado = i * i;
                    Console.WriteLine("{0} ao quadrado e: {1}", i, resultado);
                    resultado2 = resultado2 + resultado;
                }
            }
            Console.WriteLine("\nA soma do quadrado do 20 numeros é: {0}", resultado2);
            Console.ReadLine();
        }
    }
}
