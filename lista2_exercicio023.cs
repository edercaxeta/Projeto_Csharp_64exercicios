using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*23) Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma
             * delas:
             * 1 - Adição 
             * 2 - Subtração
             * 3- Multiplicação 
             * 4 - Divisão */

            Console.WriteLine("===Escolha a Operação====");
            Console.WriteLine("=========================");
            Console.WriteLine("|Opção|  Operações      |");
            Console.WriteLine("|  1  |  Adição         |");
            Console.WriteLine("|  2  |  Subtração      |");
            Console.WriteLine("|  3  |  Multiplicação  |");
            Console.WriteLine("|  4  |  Divisão        |");
            Console.WriteLine("|  0  |  Finalizar      |");
            Console.WriteLine("=========================");

            int opcao = 0;
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;  

            do
            {
                Console.WriteLine("\n===Escolha uma Opção====");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 0 || opcao > 4 )
                {
                    Console.WriteLine("\nNumero invalido, REPITA!");
                    Console.WriteLine("Escolha uma Opção");
                    opcao = int.Parse(Console.ReadLine());

                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n===Faça a Adição====");
                        Console.WriteLine("Digite um Numero");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero");
                        num2 =  double.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("A soma entre {0} e {1} é: {2}", num1, num2, resultado);
                        break;

                    case 2:
                        Console.WriteLine("\n===Faça a Subtração===");
                        Console.WriteLine("Digite um Numero");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("A subtração entre {0} e {1} é: {2}", num1, num2, resultado);
                        break;

                    case 3:
                        Console.WriteLine("\n===Faça a Multiplicação===");
                        Console.WriteLine("Digite um Numero");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("A multiplicação entre {0} e {1} é: {2}", num1, num2, resultado);
                        break;

                    case 4:
                        Console.WriteLine("\n===Faça a Divisão===");
                        Console.WriteLine("Digite um Numero");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine("A Divisão entre {0} e {1} é: {2:F2}", num1, num2, resultado);
                        break;

                    case 0:
                        Console.WriteLine("\nPrograma será encerrado!");
                        Console.WriteLine("==========================");
                        Console.WriteLine("============FIM===========");
                        Console.WriteLine("==========================");

                        break;
                }
            }
            while (opcao >= 1 && opcao <= 4);

            Console.ReadLine();
        }
    }
}
