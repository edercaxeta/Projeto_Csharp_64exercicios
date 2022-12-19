using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10) Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos
             * de ordem existentes entre eles. Os relacionamentos possíveis são:
             * Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. */

            int PrimeiroNumero, SegundoNumero;
            bool Igual = false, NaoIgual = false, Maior = false, Menor = false, MaiorOuIgual = false, MenorOuIgual = false;

            Console.WriteLine("Mostrador de relacionamentos");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Digite o primeiro número:  ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = int.Parse(Console.ReadLine());

            if (PrimeiroNumero == SegundoNumero)
            {
                Igual = true;
            }
            if (PrimeiroNumero != SegundoNumero)
            {
                NaoIgual = true;
            }
            if (PrimeiroNumero > SegundoNumero)
            {
                Maior = true;
            }
            if (PrimeiroNumero < SegundoNumero)
            {
                Menor = true;
            }
            if (PrimeiroNumero >= SegundoNumero)
            {
                MaiorOuIgual = true;
            }
            if (PrimeiroNumero <= SegundoNumero)
            {
                MenorOuIgual = true;
            }

            Console.WriteLine("\nIgual = " + Igual);
            Console.WriteLine("Não Igual = " + NaoIgual);
            Console.WriteLine("Maior = " + Maior);
            Console.WriteLine("Menor = " + Menor);
            Console.WriteLine("Maior ou igual = " + MaiorOuIgual);
            Console.WriteLine("Menor ou igual = " + MenorOuIgual);

            Console.ReadLine();
        }
    }
}
