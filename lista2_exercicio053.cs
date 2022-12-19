using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*53) Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, 
             * na ordem, os tempos registrados em cada volta. Fazer um programa para ler os tempos das
             * N voltas, calcular e imprimir: 
             * i. melhor tempo; 
             * ii. a volta em que o melhor tempo ocorreu; 
             * iii. tempo médio das N voltas; */

            Console.WriteLine("====Tempos Registrados em Cada Volta====");
            Console.WriteLine("========================================");

            Console.WriteLine("Digite o numero de voltas");
            int n  = int.Parse(Console.ReadLine());
            double[] tempos = new double[n];
            double somaTempo = 0;
            double melhor = 0, melhorvolta= 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o tempo da {0}° volta", i+1);
                tempos[i] = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
                somaTempo = somaTempo + tempos[i];

                if (tempos[i] < melhor )
                {
                    melhor = tempos[i];
                    melhorvolta = i+1;
                }            
            }
            double media = somaTempo / n;
            Console.WriteLine("O melhor tempo foi: {0}", melhor.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("A volta em que melhor tempo ocorreu foi: {0}",melhorvolta);
            Console.WriteLine("O tempo medio das voltas foram: " + media.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
