using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*64) Escreva um programa que deverá ter as seguintes opções: 
             * 1 - Carregar Vetor 
             * 2 - Listar Vetor 
             * 3 - Exibir apenas os números pares do vetor 
             * 4 - Exibir apenas os números ímpares do vetor 
             * 5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor 
             * 6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor 
             * 7- Sair 
             * Deverá ser implementado um método para realizar cada uma das opções de 1 a 6. */

            Console.WriteLine("----------------------------- O que fazer com os Numeros-----------------------------");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine();
            int opcao = 0;

            do
            {
                Console.WriteLine("\n================================Escolha a Opção=======================================");
                Console.WriteLine("======================================================================================");
                Console.WriteLine("|Opção|                                                                              |");
                Console.WriteLine("|  1  |  Carregar Vetor                                                              |");
                Console.WriteLine("|  2  |  Listar Vetor                                                                |");
                Console.WriteLine("|  3  |  Exibir apenas os numeros pares do Vetor                                     |");
                Console.WriteLine("|  4  |  Exibir apenas os numeros impares do Vetor                                   |");
                Console.WriteLine("|  5  |  Exibir a quantidade de numeros pares existen nas posições impares do Vetor. |");
                Console.WriteLine("|  6  |  Exibir a quantidade de numeros pares existen nas posições impares do Vetor. |");
                Console.WriteLine("|  7  |  Sair                                                                        |");
                Console.WriteLine("======================================================================================");
                Console.WriteLine("\n===Escolha uma Opção====");
                opcao = int.Parse(Console.ReadLine());

                while (opcao < 1 || opcao > 7)
                {
                    Console.WriteLine("\nNumero invalido, REPITA!");
                    Console.WriteLine("Escolha uma Opção");
                    opcao = int.Parse(Console.ReadLine());

                }
                switch (opcao)
                {
                    case 1:
                        CarregaVetor();
                        Console.WriteLine("\nVetor carregado com Sucesso");
                        Console.ReadLine();
                        break;

                    case 2:
                        ListaVetor();
                        Console.ReadLine();
                        break;

                    case 3:
                        VetorPar();
                        Console.ReadLine();
                        break;

                    case 4:
                        VetorImpar();
                        Console.ReadLine();
                        break;

                    case 5:
                        SoImpar();
                        Console.ReadLine();
                        break;

                    case 6:
                        SoPar();
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("\n========================================================");
                        Console.WriteLine("=============================FIM========================");
                        Console.WriteLine("========================================================");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
                Console.WriteLine();
                Console.Clear();
            } while (opcao > 0 & opcao < 7);
        }
        
        static void CarregaVetor()
        {
            int quantidade;
            Console.WriteLine("\nDigite a quantidade de números do vetor: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o {0}° Número: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }
        
        static void ListaVetor()
        {
            int quantidade;
            Console.WriteLine("\nDigite a quantidade de números do vetor: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o {0}° Número: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("O {0}° digitado foi: {1}", i + 1, numeros[i] );
            }
        }
        
        static void VetorPar()
        {
            int quantidade;
            Console.WriteLine("\nDigite a quantidade de números do vetor: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o {0}° Número: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEsses são os numeros pares: ");
            for (int i = 0; i < quantidade; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(" " + numeros[i]);
                }
            }
        }
        
        static void VetorImpar()
        {
            int quantidade;
            Console.WriteLine("\nDigite a quantidade de números do vetor: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o {0}° Número: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEsses são os numeros Impares: ");
            for (int i = 0; i < quantidade; i++)
            {
                if (numeros[i] % 2 == 1)
                {
                    Console.Write(" " + numeros[i]);
                }
            }
        }
        
        static void SoImpar()
        {
            int soImpar = 0;
            int quantidade;
            Console.WriteLine("\nDigite a quantidade de números do vetor: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o {0}° Número: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 1)
                {
                   soImpar ++;
                }
            }
            Console.WriteLine("\nA quantidade de numeros Impar é: {0}", soImpar);
        }
        
        static void SoPar()
        {
            int soPar = 0;
            int quantidade;
            Console.WriteLine("\nDigite a quantidade de números do vetor: ");
            quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o {0}° Número: ", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    soPar++;
                }
            }
            Console.WriteLine("\nA quantidade de numeros Par é: {0}", soPar);
        }

    }
}
