using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*30) Faça um programa para imprimir uma tabuada. */

            Console.WriteLine("===========TABUADA============");
            Console.WriteLine("==============================");
            Console.WriteLine("Escolha um numero entre 1 e 10");
            double numero = int.Parse(Console.ReadLine());
            double resultado =0;

            Console.WriteLine("\nA Tabuada de {0} é: ", numero);
            Console.WriteLine("\n====Multiplicação====");
            for (int i = 0; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine("{0} x {1} = {2}",numero, i, resultado);
            }
            Console.WriteLine("\n====Adição====");
            for (int i = 0; i <= 10; i++)
            {
                resultado = numero + i;
                Console.WriteLine("{0} + {1} = {2}", numero, i, resultado);
            }
            Console.WriteLine("\n====Subtração====");
            for (int i = 0; i <= 10; i++)
            {
                resultado = numero - i;
                Console.WriteLine("{0} - {1} = {2}", numero, i, resultado);
            }
            Console.WriteLine("\n====Divisão====");
            for (int i = 1; i <= 10; i++)
            {
                resultado = (numero / i);
                Console.WriteLine("{0} / {1} = {2:f2}", numero, i, resultado);
            }

            Console.ReadLine();
        }
    }
}
