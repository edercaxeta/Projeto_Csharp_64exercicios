using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
             * A fórmula de conversão de temperatura a ser utilizada é F = (9* C + 160) / 5, 
             * em que a variável F representa é a temperatura em graus Fahrenheit e a variável C representa
             * é a temperatura em graus Celsius. */

            Console.WriteLine("Conversor de temperatura Celsius para Fahrenheit");
            Console.WriteLine("________________________________________________");
            Console.Write("Digite a temperatura e Celsius: ");
            double c = double.Parse(Console.ReadLine());
            double resultado = (9 * c + 160) / 5;
            Console.Clear();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" {0:f2}° Celsius é igual a {1:f2}° Fahrenheit.", c,resultado);
            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();
        }
    }
}
