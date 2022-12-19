using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*52) Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o
             * número 1, 3 e 4, nesta ordem. O vetor terá no máximo 100 posições. Sair do programa quando 
             * for digitado -1. */

            Console.WriteLine("Quantas vezes aparece o numero 1, 3 e 4");
            Console.WriteLine("=======================================");
            Console.WriteLine("       (Digite -1 para sair)");
            Console.WriteLine();

            int[] numero = new int[100];
            int soma1 = 0, soma3 = 0, soma4 = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write("Digite um numero: ");
                numero[i] = int.Parse(Console.ReadLine());
                while (numero[i] < -1 || numero[i] > 100)
                {
                    Console.WriteLine("Numero invalido, REPITA!");
                    numero[i] = int.Parse(Console.ReadLine());
                }
                if (numero[i] == 1)
                    soma1++;
                else if (numero[i] == 3)
                    soma3++;
                else if (numero[i] == 4)
                    soma4++;
                else if (numero[i] == -1)
                {
                    Console.Clear();
                    Console.WriteLine("======Você digitou '-1', Programa sera encerrado======");
                    break;
                }
            }
            Console.WriteLine("\nO total foi:\nNumero 1 = {0} \nNumero 3 = {1} \nNumero 4 = {2}", soma1, soma3, soma4);
            Console.ReadLine();
        }
    }
}
