using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*36) Faça um programa que leia 10 valores inteiros e positivos e: 
             * -Encontre o maior valor
             * -Encontre o menor valor 
             * -Calcule a média dos números lidos */

            Console.WriteLine("=========Encotre o maior, o menor e as medias do numero========");
            Console.WriteLine("===============================================================");

            double soma = 0;
            double numero = 0;
            double maior = 0;
            double menor = 0;
            for (int i = 1; i <= 10 ; i++)
            {
                Console.Write("Digite um numero para posição {0}: ",i);
                numero = double.Parse(Console.ReadLine());
                soma = soma + numero;
                
                if (i == 1)
                {
                    maior = numero;
                    menor = numero;
                }
                if(numero > maior)
                {
                    maior = numero;

                }
                if (numero < menor)
                {
                    menor = numero ;
                }
                
            }
            soma = soma / 10;
            Console.WriteLine("\n===============================================================");
            Console.WriteLine("O menor numero digitado foi {0}, o maior {1}", menor,maior);
            Console.WriteLine("===============================================================");
            Console.WriteLine("\A media dos numero é {0}", soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("===============================================================");
            Console.ReadLine();
        }
    }
}
