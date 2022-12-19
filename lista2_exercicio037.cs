using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*37) Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de
             * entrada com as seguintes opções: 
             * 1 - Adição 
             * 2 - Subtração 
             * 3- Multiplicação 
             * 4 - Divisão
             * Informe a opção:
             * A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois
             * números. Em seguida, o programa deve exibir o resultado da opção indicada pelo usuário e
             * perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta seja 'S' ou 's',
             * deverá voltar ao menu, caso contrário deverá encerrar o programa. */

            int opcao = 0;
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            string consulta;
            bool encerrar = false;

            do
            {
                Console.WriteLine("===Escolha a Operação====");
                Console.WriteLine("=========================");
                Console.WriteLine("|Opção|  Operações      |");
                Console.WriteLine("|  1  |  Adição         |");
                Console.WriteLine("|  2  |  Subtração      |");
                Console.WriteLine("|  3  |  Multiplicação  |");
                Console.WriteLine("|  4  |  Divisão        |");
                Console.WriteLine("=========================");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 1 || opcao > 4)
                {
                    Console.WriteLine("\nNumero invalido, REPITA!");
                    Console.WriteLine("Escolha uma Opção");
                    opcao = int.Parse(Console.ReadLine());

                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n===Faça a Adição====");
                        Console.WriteLine("Digite um Numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("A soma entre {0} e {1} é: {2}", num1, num2, resultado);
                        break;

                    case 2:
                        Console.WriteLine("\n===Faça a Subtração===");
                        Console.WriteLine("Digite um Numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("A subtração entre {0} e {1} é: {2}", num1, num2, resultado);
                        break;

                    case 3:
                        Console.WriteLine("\n===Faça a Multiplicação===");
                        Console.WriteLine("Digite um Numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("A multiplicação entre {0} e {1} é: {2}", num1, num2, resultado);
                        break;

                    case 4:
                        Console.WriteLine("\n===Faça a Divisão===");
                        Console.WriteLine("Digite um Numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine("A Divisão entre {0} e {1} é: {2:F2}", num1, num2, resultado);
                        break;

                    default:
                        Console.WriteLine("\nOpção invalida, Repita!");
                        break;
                }
                Console.WriteLine("\nDeseja continuar?(S/N)");
                consulta = Console.ReadLine();
                while (consulta != "s" && consulta != "S" && consulta != "n" && consulta != "N")
                {
                    Console.WriteLine("Opção inalida, Repita!");
                    consulta = Console.ReadLine();
                }
                if (consulta == "S" || consulta == "s")
                {
                    Console.Clear();
                    encerrar = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("O progama sera finalizado");
                    break;
                }
            }
            while (opcao >= 1 && opcao <= 4);
            Console.ReadLine();
        }
    }
}
