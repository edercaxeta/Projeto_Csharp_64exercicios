using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12) Escreva um programa que leia um número inteiro e exiba o seu módulo. 
             * O módulo de um número x é: 
             * x se x é maior ou igual a zero 
             * x* (-1) se x é menor que zero */

            int numero, modulo; 
            Console.WriteLine("  Calculando o modulo");
            Console.WriteLine("-----------------------");

            Console.Write(" Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                modulo = numero;
                Console.WriteLine("\n O modulo de {0} é: {1}", numero, modulo);

            }
            else
            {
                modulo = numero * (-1);
                Console.WriteLine("\n O modulo de {0} é: {1}", numero, modulo);
            }
            Console.ReadLine();
        }
    }
}
