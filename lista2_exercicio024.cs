using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*24) Escreva um programa que leia dois números inteiros e apresente as opções para usuário 
             * escolher o que deseja realizar: 
             * 1 - Verificar se um dos números lidos é ou não múltiplo do outro
             * 2- Verificar se os dois números lidos são pares 
             * 3 - Verificar se a média dos dois números é maior ou igual a 7. 
             * 4- Sair */

            Console.WriteLine("-------------------Escolha o que fazer com os numeros--------------------------");
            Console.WriteLine("===============================================================================");

            double num1 = 0;
            double num2 = 0;
            double resultado = 0;
            double opcao = 0;

            Console.WriteLine("Digite um numero.");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero.");
            num2 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("\n=============================Escolha a Opção===================================");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("|Opção|                                                                       |");
            Console.WriteLine("|  1  |  Verificar se um dos numeros lidos é ou não multiplo do outro.        |");
            Console.WriteLine("|  2  |  Verificar se os dois numeros lidos são pares.                        |");
            Console.WriteLine("|  3  |  Verificar se a media dos dois numeros é igual ou maior que 7.        |");
            Console.WriteLine("|  4  |  Sair                                                                 |");
            Console.WriteLine("===============================================================================");
            do
            {
                Console.WriteLine("\n===Escolha uma Opção====");
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
                        Console.WriteLine("\n===É ou não multiplo do outro====");
                        if (num1 % num2 == 0 || num2 % num1 == 0)
                        {
                            Console.WriteLine("O numero {0} e {1} são multiplos", num1,num2);
                        }
                        else
                        {
                            Console.WriteLine("O numero {0} não é multiplo de {1}", num1,num2);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n===São pares===");
                        if(num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("O numero {0} e o numero {1} é pares", num1, num2);
                        }
                        else if(num1 % 2 == 1 &&  num2 % 2 == 0)
                        {
                            Console.WriteLine("O numero {0} é impar e numero {1} é par", num1, num2);
                        }
                        else if( num1 % 2 == 0 && num2 % 2 == 1)
                        {
                            Console.WriteLine("O numero {0} é par e numero {1} é impar", num1, num2);
                        }
                        else if(num1 % 2 == 1 && num2 % 2 == 1)
                        {
                            Console.WriteLine("O numero {0} é impar e numero {1} é impar", num1, num2);
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n===É igual ou maior que 7===");
                        resultado = (num1 + num2) / 2;
                        if (resultado == 7)
                        {
                            Console.WriteLine("A media dos numeros é 7");
                        }
                        else
                        {
                            Console.WriteLine("A media dos numeros não é 7");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nPrograma será encerrado!");
                        Console.WriteLine("==========================");
                        Console.WriteLine("============FIM===========");
                        Console.WriteLine("==========================");

                        break;
                }
            }
            while (opcao >= 1 && opcao <= 3);
            Console.ReadLine();
        }
    }
}
