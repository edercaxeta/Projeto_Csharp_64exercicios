using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*22) Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo,
             * em B. No final mostrar o resultado. */

            Console.WriteLine("Se for Positivo armazena em A; Se for Negativo armazena e B");
            Console.WriteLine("===========================================================");

            int numero = 0;

            Console.Write("\nDigite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 1)
            {
                int A = numero;
                Console.WriteLine("\nO numero é Positivo, entao A recebeu  {0}.", A);
            }
            else if (numero <= -1)
            {
                int B = numero;
                Console.WriteLine("\nO numero é Negativo, entao B recebeu {0}.", B);
            }
            else
            {
                Console.WriteLine("\nZero não é nem positivo e nem negativo");
            }
            Console.WriteLine("\n====================FIM====================");
            Console.ReadLine();
        }
    }
} 
