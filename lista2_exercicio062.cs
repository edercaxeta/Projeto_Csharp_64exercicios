using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*62) Escreva um programa que calcule e retorne o valor da hipotenusa através do método 
             * HIPOTENUSA. O método recebe o valor da base e da altura de um triângulo.
             * Fórmulas: hipotenusa2 = base2+ altura2 */

            Console.WriteLine("=====Calcule a Hipotenusa=====");
            Console.WriteLine("==============================");
            Console.WriteLine();
            
            Console.Write("Digite o valor da Base: ");
            double baze = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da Altura: ");
            double altura = double.Parse(Console.ReadLine());
            double resposta = Hipotenusa(baze, altura);
            
            Console.WriteLine("\nO valor da Hipotenusa é: {0}", resposta.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("\n=====================================");
            Console.WriteLine("==================FIM================");
            Console.WriteLine("=====================================");
            Console.ReadLine();

        }
        static double Hipotenusa (double num1, double num2)
        {
            double resultadof = double.Parse(Math.Sqrt((num1 * num1) + (num2 * num2)).ToString());
            return resultadof;
        }

    }
}
