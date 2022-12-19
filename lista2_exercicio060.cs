using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*60) Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método
             * chamado VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y. */

            string resposta;
            do
            {
                Console.WriteLine("=======Verifica Quadrante=========");
                Console.WriteLine("==================================");
                Console.WriteLine();
                Console.WriteLine("           Quadrantes            ");
                Console.WriteLine("               x|                ");
                Console.WriteLine("                |                ");
                Console.WriteLine("       2°       |        1°      ");
                Console.WriteLine("                |                ");
                Console.WriteLine("y--------------------------------");
                Console.WriteLine("                |                ");
                Console.WriteLine("                |                ");
                Console.WriteLine("       3°       |        4°      ");
                Console.WriteLine("                |                ");
                Console.WriteLine();

                int num1 = 0;
                int num2 = 0;

                Console.WriteLine("Digite o valor de y: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de x: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Verifica_Quadrante(num1, num2);

                Console.Write("\nDeseja encerrar o programa(S/N): ");
                resposta = Console.ReadLine();
                while (resposta != "n" && resposta != "N" && resposta != "s" && resposta != "S")
                {
                    Console.WriteLine("Opção invalida, Repita!");
                    resposta = Console.ReadLine();
                }
                Console.Clear();

            } while (resposta.ToUpper() == "N");
            Console.WriteLine("===========================");
            Console.WriteLine("=O programa será encerrado=");
            Console.WriteLine("===========================");
            Console.ReadLine();

        }
        static void Verifica_Quadrante(int y, int x)
        {
            if (y > 0 & x > 0)
                Console.WriteLine("1° Quadrante");
            else if (y < 0 & x > 0)
                Console.WriteLine("2° Quadrante");
            else if (y < 0 & x < 0)
                Console.WriteLine("3° Quadrante");
            else if (y > 0 & x < 0)
                Console.WriteLine("4° Quadrante");
            else
                Console.WriteLine("Neutro");
        }
    }
}
