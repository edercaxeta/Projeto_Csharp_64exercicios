using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13) Escreva um programa que leia 3 números inteiros e imprima na tela os valores
             * em ordem decrescente. */
            int a , b , c ;
            Console.WriteLine("Colocar os numeros em ordem decrescente");
            Console.WriteLine("---------------------------------------");

            Console.Write("Digite um  numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite mais um numero: ");
            c = int.Parse(Console.ReadLine());

            if (a != b && a != c && b != c)
            {
                if (a < b)
                {
                    if (b < c)
                    {
                        Console.WriteLine("A ordem crescente é: {0},{1},{2}", c, b, a);
                    }
                    else if (a < c)
                    {
                        Console.WriteLine("A ordem crescente é: {0},{1},{2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("A ordem crescente é: {0},{1},{2}", b, a, c);
                    }
                }
                else if (b < c)
                {
                    if (a < c)
                    {
                        Console.WriteLine("A ordem crescente é: {0},{1},{2}", c, a, b);
                    }
                    else
                    {
                        Console.WriteLine("A ordem crescente é: {0},{1},{2}", a, c, b);
                    }
                }
                else
                {
                    Console.WriteLine("A ordem crescente é: {0},{1},{2}", c, b, a);
                }
            }
            else
            {
                Console.WriteLine("Os numeros não pode ser iguais repita o processo.");
            }
            Console.ReadLine();
        }
    }
}
