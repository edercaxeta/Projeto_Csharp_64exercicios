using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*58) Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e 
             * calcular a média. Imprimir também o maior. A quantidade de números lidos será definida 
             * pelo usuário. */

            Console.WriteLine("====Calcular media e o Numero maior====");
            Console.WriteLine("=======================================");
            Console.WriteLine();

            Console.Write("Digite quantos numeros quer calcular: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double[] numero = new double[quantidade];
            int i ;
            double soma = 0, maior = 0;
            for ( i = 0; i < quantidade; i++) 
            {
                Console.Write("Digite o {0}° numero: ", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
                soma += numero[i];
                if (numero[i] > maior || i == 0)
                {
                    maior = numero[i];
                }
            }
            
            double media  = soma/quantidade;
            Console.Clear();
            Console.WriteLine("\nA media dos numeros é: {0:f2}", media);
            Console.WriteLine("\nO maior numero digitado é : {0}", maior);
            Console.WriteLine("========================================");
            Console.WriteLine("===================FIM==================");
            Console.WriteLine("========================================");

            Console.ReadLine();


        }
    }
}
