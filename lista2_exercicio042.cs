using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*42) Faça um programa que determine o maior e o menor entre N números lidos. A condição de 
             * parada é a entrada de um valor 0, ou seja, o programa deve ficar executando até que a
             * entrada seja igual a 0 (ZERO). */

            Console.WriteLine("====Maior e Menor Numero====");
            Console.WriteLine("============================");
            Console.WriteLine();

            double numero, maior, menor;
            Console.Write("Digite um numero: ");
            numero = double.Parse(Console.ReadLine());
            menor = numero;
            maior = numero;

            do
            {
                Console.Write("Digite outro numero: ");
                numero = double.Parse(Console.ReadLine());

                if(numero > maior)
                {
                    maior = numero;
                }
                if (numero < menor && numero != 0)
                {
                    menor = numero;
                }

            }while(numero != 0);

            Console.WriteLine("O menor numero é {0} e o maior numero é {1}",menor, maior);

            Console.ReadLine();
        }
    }
}
