using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*17) Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor 
             * fornecido está na faixa entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da
             * faixa, apresentar a mensagem "valor válido". Caso contrário, apresentar a mensagem
             * "valor inválido". */

            Console.WriteLine("Valor Valido ou Invalido");
            Console.WriteLine("------------------------");

            Console.Write("Digite um Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Valor Valido");
            }
            else
            {
                Console.WriteLine("Valor Inalido");
            }

            Console.ReadLine();
        }
    }
}
