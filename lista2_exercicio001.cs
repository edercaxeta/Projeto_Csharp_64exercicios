using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_execicio_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Faça um programa para calcular o estoque médio de uma peça, sendo que: 
             * ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE MÁXIMA) / 2. */

            Console.WriteLine("Calcule o estoque medio de uma peça");
            Console.WriteLine("__________________________");
            Console.WriteLine("Digite a Quantidade Minima");
            double quantidade_minima = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade Maxima");
            double quantidade_maxima = double.Parse(Console.ReadLine());
            double estoque_medio = (quantidade_minima + quantidade_maxima)/2;
            Console.WriteLine();
            Console.WriteLine("A quandidade media de uma peça é: {0}", estoque_medio.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
