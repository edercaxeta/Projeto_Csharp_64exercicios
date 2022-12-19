using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*61) Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE.
             * O método deve receber o valor do salário e o índice de reajuste. */

            Console.WriteLine("====Calcule o Reajuste do Salario====");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            double resposta = 0;

            Console.WriteLine("Digite o Salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o reajuste(%): ");
            double valor = double.Parse(Console.ReadLine());
            resposta = Reajuste(salario, valor);
            Console.WriteLine("\nO salario final é: {0}", resposta.ToString("f2",CultureInfo.InvariantCulture));
           
            Console.WriteLine("\n=====================================");
            Console.WriteLine("==================FIM================");
            Console.WriteLine("=====================================");
            Console.ReadLine();

        }
        static double Reajuste(double salarioN, double valorN)
        {
            double resultado =( salarioN + (salarioN*(valorN / 100)));
            return resultado;
        }
    }
}
