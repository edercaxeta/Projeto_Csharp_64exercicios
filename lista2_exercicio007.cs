using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7) Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius.
             * A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5/9, 
             * em que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura 
             * em graus Celsius*/

            Console.WriteLine("Conversor de temperatura Fahrenheit para Celsius ");
            Console.WriteLine("________________________________________________");
            Console.Write("Digite a temperatura e Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());
            double resultado = (f - 32) * 5 / 9;
            Console.Clear();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" {0:f2}° Fahrenheit é igual a {1:f2}° Celsius .", f, resultado);
            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();
        }
    }
}
