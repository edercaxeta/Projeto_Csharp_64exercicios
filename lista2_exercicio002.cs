using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2) Faça um programa que: 
             * - Leia a cotação do dólar 
             * - Leia um valor em dólares Converta esse valor para Real Mostre o resultado */

            Console.WriteLine("---Conversor de Dolar para Real---");
            Console.WriteLine("____________________________________");
            double dolar_dia = 5.35;
            Console.Write("   Escreva o valor em dolar: ");
            double valor_dolar = double.Parse(Console.ReadLine());

            double real = valor_dolar * dolar_dia;
            Console.WriteLine("_____________________________________");
            Console.WriteLine("|{0} Dolares coresponde a R${1}.|", valor_dolar, real.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
