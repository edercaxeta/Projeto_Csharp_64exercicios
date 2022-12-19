using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*27) Escreva um programa que leia: 
             * a quantidade de números que deverá processar;
             * os números que deverá processar,e calcule e exiba, para cada número a ser processado o seu
             * fatorial. Lembrete: O fatorial de um número N é dado pela fórmula: N!= 1*2*3*4* 5 * ... * N */

            Console.WriteLine("===Calculando o Fatotial===");
            Console.WriteLine("===========================");

            double i, numero, fatorial;
            Console.WriteLine("Digite quanto Numeros quer processar");
            numero = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite os numero a processar ");
            //fatorial = double.Parse(Console.ReadLine());

            fatorial = numero;

            for (i = numero - 1; i >= 1; i--)
            {
                //Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;

            }
            Console.WriteLine("\nFatorial de {0} é {1} ", numero, fatorial);
            Console.ReadLine();
        }
    }
}
