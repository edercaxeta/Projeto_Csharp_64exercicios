using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*26) Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.*/

            Console.WriteLine("Programa de 100 numeros em ordem decrescente");
            for (int i = 100; i  > 0; i--) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
