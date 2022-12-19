using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*21) Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se 
             * este número é positivo ou negativo. Pare a execução do programa quando o usuário requisitar. */

            Console.WriteLine("===========Positivo ou Negativo===========");
            Console.WriteLine("==========================================");
            Console.WriteLine("Para encerrar o programa digite o numero 0");
            Console.WriteLine("==========================================");

            int numero ;

            do
            {
                Console.Write("\nDigite um numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 1)
                {
                    Console.WriteLine("\nO numero {0} é POSITIVO.", numero);
                }
                else if (numero <= -1)
                {
                    Console.WriteLine("\nO numero {0} é NEGATIVO.", numero);
                }
                else
                {
                    Console.WriteLine("\n========================================");
                    Console.WriteLine("Zero não é nem Positivo e nem Negativo. ");
                    Console.WriteLine("========PROGRAMA=SERÁ=ENCERRADO=========");
                    Console.WriteLine("========================================");
                }

            } while (numero != 0);
            Console.ReadLine();
        }
    }
}
