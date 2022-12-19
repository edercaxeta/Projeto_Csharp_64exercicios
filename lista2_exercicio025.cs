using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*25) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule
             * seu peso ideal, utilizando as seguintes fórmulas: (h = altura)
             * Para homens: (72.7*h) - 58 
             * Para mulheres: (62.1 *h) - 44.7 */

            Console.WriteLine("----Peso ideal Homem ou mulher----");
            Console.WriteLine("==================================");

            Console.WriteLine("\n==========Menu de Opção===========");
            Console.WriteLine("==================================");
            Console.WriteLine("|Opção|                          |");
            Console.WriteLine("|  1  |  Homem                   |");
            Console.WriteLine("|  2  |  Mulher                  |");
            Console.WriteLine("|  0  |  Sair                    |");
            Console.WriteLine("==================================");

            double altura = 0;
            int opcao = 0;
            do
            {
                Console.WriteLine("\n========Escolha a Opção===========");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 0 || opcao > 2)
                {
                    Console.WriteLine("\nNumero invalido, REPITA!");
                    Console.WriteLine("Escolha uma Opção");
                    opcao = int.Parse(Console.ReadLine());
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\nDigite a Altura");
                        altura = double.Parse(Console.ReadLine());
                        double pesohomem = (72.7 * altura) - 58;
                        Console.WriteLine("O peso ideal para homem que tem {0} de altura é: {1}", altura, pesohomem.ToString("f2", CultureInfo.InvariantCulture));
                        break;

                    case 2:
                        Console.WriteLine("\nDigite a Altura");
                        altura = double.Parse(Console.ReadLine());
                        double pesomulher = (62.1 * altura) - 44.7;
                        Console.WriteLine("O peso ideal para mulher que tem {0} de altura é: {1}", altura, pesomulher.ToString("f2", CultureInfo.InvariantCulture));
                        break;

                    case 0:
                        Console.WriteLine("\n     Programa será encerrado!");
                        Console.WriteLine("==================================");
                        Console.WriteLine("================FIM===============");
                        Console.WriteLine("==================================");
                        break;
                }
            }
            while (opcao >= 1 && opcao <= 2);

            Console.ReadLine();
        }
    }
}
