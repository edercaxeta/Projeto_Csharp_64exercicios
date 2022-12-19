using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio028
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*28) Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200. */

            Console.WriteLine("Numeros impares entre 100 e 200");
            Console.WriteLine("===============================");

            for (int i = 100; i < 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("|"+i);
                }
            }
            Console.ReadLine();
        }
    }
}
