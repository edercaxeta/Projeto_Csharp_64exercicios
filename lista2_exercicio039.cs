using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio039
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*39) Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este 
             * número é par ou ímpar, e se é positivo ou negativo. O programa só deve parar de rodar 
             * quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". */

            Console.WriteLine("Par ou Impar, Positivo ou Negativo");
            Console.WriteLine("==================================");
            int numero = 0;
            string resposta;

            do
            {
                Console.Write("\nDigite um numero: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (numero % 2 == 0 && numero > 0)
                {
                    Console.WriteLine("O numero {0} é Par e Positivo", numero);
                }
                else if (numero % 2 == 1 && numero > 0)
                {
                    Console.WriteLine("O numero {0} é Impar e Positivo", numero);
                }
                else if (numero % 2 == 0 && numero < 0)
                {
                    Console.WriteLine("O numero {0} é Par e Negativo", numero);
                }
                else
                {
                    Console.WriteLine("O numero {0} é Impar e Negativo", numero);
                }
                Console.Write("\nDeseja encerrar o programa(S/N): ");
                resposta = Console.ReadLine();
                while (resposta != "n" && resposta != "N" && resposta != "s" && resposta != "S")
                {
                    Console.WriteLine("Opção invalida, Repita!");
                    resposta = Console.ReadLine();
                }

            } while (resposta.ToUpper() == "N");
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("=O programa será encerrado=");
            Console.WriteLine("===========================");
            Console.ReadLine();
        }
    }
}
