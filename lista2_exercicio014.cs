using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14) Escreva um programa que leia dois números e apresente a diferença do maior para o menor.*/

            Console.WriteLine("Diferença do maior para o menor");
            Console.WriteLine("-------------------------------");

            Console.Write("Digite um Numero: ");
            int num1 =  int.Parse(Console.ReadLine());
            Console.Write("Digite Outro numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            if (num1 > num2)
            {
                int resultado = num1 - num2;
                Console.WriteLine(" A diferença entre os numeros lidos é: " +  resultado);
            }
            else 
            {
                int resultado2 = num2 - num1;
                Console.WriteLine(" A diferença entre os numeros lidos é: " + resultado2);
            }
            Console.ReadLine();
        }
    }
}
