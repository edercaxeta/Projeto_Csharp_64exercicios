using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11) Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo 
             * que a variável A passe a possuir o valor da variável B, e a variável B passe a possuir o 
             * valor da variável A. Apresentar os valores trocados. */

            int num1, num2, auxiliar;
            auxiliar = 0;
            num1 = 0;
            num2 = 0;

            Console.WriteLine("  Valores invertidos");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Digite um numero para A");  
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero para B");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            if (num1 != num2)
            {
                auxiliar = num1;
                num1 = num2;
                num2 = auxiliar;

                Console.WriteLine("'A' agora é: "+ num1);
                Console.WriteLine("'B' agora é: "+ num2);
            }
            else
            {
                Console.WriteLine("\n'A' tem que ser diferente de 'B'.");
            }
            Console.WriteLine("-----------------------");
            Console.ReadLine();
        }
    }
}
