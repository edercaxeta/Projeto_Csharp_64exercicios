using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16) Escreva um programa que leia dois números e exiba mensagem informando o valor do maior 
             * número e o valor do menor número. Se os dois números forem iguais, o programa deve exibir 
             * mensagem informando este fato. */

            Console.WriteLine("Qual Numero é Mior");
            Console.WriteLine("------------------");

            Console.WriteLine("Digite um Numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro Numero");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("\n {0} é o Maior Numero; E {1} é o Menor. ", num1, num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("\n {0} é o Maior Numero; E {1} é o Menor.", num2, num1);
            }
            else
            {
                Console.WriteLine("\n O Numero {0} e {1} são Iguais.", num1, num2);
            }
            Console.ReadLine();

        }
    }
}
