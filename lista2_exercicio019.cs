using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19) Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C).
             * Verificar se cada lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e 
             * se B==C, sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B ou se A==C ou 
             * se B==C, sendo verdade o triângulo é isósceles; e caso contrário, o triângulo será escaleno.
             * Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência. */

            Console.WriteLine("Qual Tipo de Triângulo");
            Console.WriteLine("----------------------");

            Console.Write(" Digite o Lado A do triângulo: ");
            double ladoA = int.Parse(Console.ReadLine());

            Console.Write(" Digite o Lado B do Triângulo: ");
            double ladoB = int.Parse(Console.ReadLine());

            Console.Write(" Digite o Lado C do Triângulo: ");
            double ladoC = int.Parse(Console.ReadLine());

            if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB )
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("\n Triângulo Equilatero.");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("\n Triângulo Isósceles.");
                }
                else
                {
                    Console.WriteLine("\n Triângulo Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("\n Os Lados não Caracterizam um Triângulo.");
            }
            Console.ReadLine();
        }
    }
}
