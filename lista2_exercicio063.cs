using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio063
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*63) Escreva um programa que verifique se um número é par ou ímpar através de um método
             * chamado VERIFICA. O método deverá receber um número inteiro (n) e deverá retornar a 
             * mensagem "PAR" ou "ÍMPAR”. */

            Console.WriteLine("==========Par ou impar===========");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Console.Write("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Verifica(n1);

            Console.WriteLine("\n=================================");
            Console.WriteLine("===============FIM===============");
            Console.WriteLine("=================================");
            Console.ReadLine();   
        }
        static void Verifica(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("\nO numero {0} é Par", num);
            
            else
                Console.WriteLine("\nO numero {0} é Impar", num);
        }
    }
}
