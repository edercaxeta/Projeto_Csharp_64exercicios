using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*44) Faça um programa que exiba as opções: 
             * 1 - Conversão de Graus Celsius em Graus Fahrenheit 
             * 2- Conversão de Graus Fahrenheit em Graus Celsius 
             * 3- Peso ideal do homem 
             * 4 - Peso ideal da mulher 
             * O programa só deve encerrar quando o usuário digitar  ́S ́ para a pergunta 
             * “Deseja encerrar o programa?" Obs.: Nas opções 3 e 4 informar se o usuário 
             * está acima ou abaixo do peso ideal. */

            int opcao = 0;
            double altura = 0;
            double peso = 0;
            double resultado = 0;
            string resposta;

            do
            {
                Console.WriteLine("=======================Escolha a Operação===================");
                Console.WriteLine("============================================================");
                Console.WriteLine("|Opção|                                                    |");
                Console.WriteLine("|  1  |  Conversão de Graus Celsius em Graus Fanrenheit    |");
                Console.WriteLine("|  2  |  Conversão de Fanrenheit Celsius em Graus Graus    |");
                Console.WriteLine("|  3  |  Peso ideal do homem                               |");
                Console.WriteLine("|  4  |  Peso ideal da mulher                              |");
                Console.WriteLine("============================================================");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 1 || opcao > 4)
                {
                    Console.WriteLine("\nOpção invalido, REPITA!");
                    Console.WriteLine("Escolha uma Opção");
                    opcao = int.Parse(Console.ReadLine());

                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Conversor de temperatura Celsius para Fahrenheit ");
                        Console.WriteLine("___________________________________________________");
                        Console.Write("Digite a temperatura e Celsius: ");
                        double c = double.Parse(Console.ReadLine());
                        resultado = (9 * c + 160) / 5;
                        Console.Clear();

                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine(" {0:f2}° Celsius é igual a {1:f2}° Fahrenheit.", c, resultado);
                        Console.WriteLine("---------------------------------------------------");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Conversor de temperatura Fahrenheit para Celsius ");
                        Console.WriteLine("___________________________________________________");
                        Console.Write("Digite a temperatura e Fahrenheit: ");
                        double f = double.Parse(Console.ReadLine());
                        resultado = (f - 32) * 5 / 9;
                        Console.Clear();

                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine(" {0:f2}° Fahrenheit é igual a {1:f2}° Celsius .", f, resultado);
                        Console.WriteLine("---------------------------------------------------");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("--------------Peso ideal do homem-------------------");
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("\nDigite sua altura");
                        altura = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite seu peso");
                        peso = double.Parse(Console.ReadLine());
                        double pesohomem = (72.7 * altura) - 58;

                        if (peso < pesohomem)
                        {
                            Console.WriteLine("O peso ideal para homem que tem {0} de altura é: {1} ", altura, pesohomem.ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("------------Você está abaixo do peso----------------");
                        }
                        else if (peso > pesohomem)
                        {
                            Console.WriteLine("O peso ideal para homem que tem {0} de altura é: {1} ", altura, pesohomem.ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("------------Você está acima do peso-----------------");
                        }
                        else
                        {
                            Console.WriteLine("------------Você está com peso ideal----------------");
                        }
                        break;

                    case 4:
                        Console.WriteLine("----------------Peso ideal da mulher---------------");
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("\nDigite sua altura");
                        altura = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite seu peso");
                        peso = double.Parse(Console.ReadLine());
                        double pesomulher = (62.1 * altura) - 44.7;
                        
                        if (peso < pesomulher)
                        {
                            Console.WriteLine("O peso ideal para homem que tem {0} de altura é: {1} ", altura, pesomulher.ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("------------Você está abaixo do peso----------------");
                        }
                        else if (peso > pesomulher)
                        {
                            Console.WriteLine("O peso ideal para homem que tem {0} de altura é: {1} ", altura, pesomulher.ToString("f2", CultureInfo.InvariantCulture));
                            Console.WriteLine("------------Você está acima do peso-----------------");
                        }
                        else
                        {
                            Console.WriteLine("------------Você está com peso ideal----------------");
                        }
                        break;

                    default:
                        Console.WriteLine("\nOpção invalida, Repita!");
                        break;
                }
                Console.WriteLine("\nDeseja encerrar?(S/N)");
               resposta = Console.ReadLine();
                while (resposta != "n" && resposta != "N" && resposta != "s" && resposta != "S")
                {
                    Console.WriteLine("Opção invalida, Repita!");
                    resposta = Console.ReadLine();
                }
                Console.Clear();
            }while (resposta.ToUpper() == "N");

            Console.WriteLine("===========================");
            Console.WriteLine("=O programa será encerrado=");
            Console.WriteLine("===========================");
            Console.ReadLine();
        }
    }
}
