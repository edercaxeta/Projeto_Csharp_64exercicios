using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*35) Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem:
             * "Múltiplo de 10". */

            Console.WriteLine("========Multiplos de 10=========");
            Console.WriteLine("================================");
            
            for (int i = 1; i <= 100; i++)
            {
                
                if (i % 10 == 0)
                {
                    Console.WriteLine("{0} é multiplo de 10", i);
                }
            }
            Console.WriteLine("================================");
            Console.ReadLine();
        }
    }
}
