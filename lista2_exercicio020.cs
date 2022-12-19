using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20) Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). 
             * Ler um valor maior que zero para cada variável (se o valor digitado não é válido,
             * mostrar mensagem e ler novamente). Exibe o menor valor lido multiplicado pelo maior 
             * e o maior valor dividido pelo menor. */

            double resultado = 0;
            double resultado2 = 0;

            Console.WriteLine("Menor valor lido multiplicado pelo maior e o maior dividido pelo menor");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Digite o valor A: ");
            double valor1 = double.Parse(Console.ReadLine());
            while (valor1 < 0 )
            {
                Console.Write("Valor digitado não é válido, ler novamento");
                valor1 = double.Parse(Console.ReadLine());

            }

            Console.Write("Digite o valor B: ");
            double valor2 = double.Parse(Console.ReadLine());
            while (valor2 < 0)
            {
                Console.Write("Valor digitado não é válido, ler novamento");
                valor2 = double.Parse(Console.ReadLine());

            }

            Console.Write("Digite o valor C: ");
            double valor3 = double.Parse(Console.ReadLine());
            while (valor3 < 0)
            {
                Console.Write("Valor digitado não é válido, ler novamento: ");
                valor3 = double.Parse(Console.ReadLine());

            }

            if (valor1 < valor2 && valor2 < valor3)
            {
                resultado = valor1 * valor3;
                Console.WriteLine(resultado);
                resultado2 = valor3 / valor1;
                Console.WriteLine(resultado2);
            }
            else if (valor1 < valor3 && valor3 < valor2)
            {
                resultado = valor1 * valor2;
                Console.WriteLine(resultado);
                resultado2 = valor2 / valor1;
                Console.WriteLine(resultado2);
            }
            else if (valor2 < valor1 && valor1 < valor3)
            {
                resultado = valor2 * valor3;
                Console.WriteLine(resultado);
                resultado2 = valor3 / valor2;
                Console.WriteLine(resultado2);
            }
            else if (valor2 <valor3 && valor3 < valor1)
            {
                resultado = valor2 * valor1;
                Console.WriteLine(resultado);
                resultado2 = valor1 / valor2;
                Console.WriteLine(resultado2);
            }
            else if (valor3 < valor1 && valor1 < valor2)
            {
                resultado = valor3 * valor2;
                Console.WriteLine(resultado);
                resultado2 = valor2 / valor3;
                Console.WriteLine(resultado2);
            }
            else if (valor3 < valor2 && valor2 < valor1)
            {
                resultado = valor3 * valor1;
                Console.WriteLine(resultado);
                resultado2 = valor1 / valor3;
                Console.WriteLine(resultado2);
            }
            Console.ReadLine();
        }
    }
}
