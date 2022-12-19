using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*41) Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes 
             * categorias: 
             * Infantil A = 5 a 7 anos 
             * Infantil B = 8 a 11 anos 
             * Juvenil A = 12 a 13 anos 
             * Juvenil B = 14 a 17 anos 
             * Adultos Maiores de 18 anos */

            Console.WriteLine("Categorias de nadador por Idade");
            Console.WriteLine("===============================");
            Console.WriteLine();

            double idade = 0;

            Console.Write("Digite a idade: ");
            idade = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
           
            while (idade < 5)
            {
                Console.WriteLine("\nIdade invalida, Repita!");
                idade = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            }

            if (idade >= 5 && idade <8 )
            {
                Console.WriteLine("\nA idade digitada foi {0} e a Categoria é: Infanil 'A' ",idade);
            }
            else if (idade >= 8 && idade <12 )
            {
                Console.WriteLine("\nA idade digitada foi {0} e a Categoria é: Infanil 'B' ",idade);
            }
            else if(idade >= 12 && idade <14 )
            {
                Console.WriteLine("\nA idade digitada foi {0} e a Categoria é: Juvenil 'A' ",idade); 
            }
            else if (idade >= 14 && idade <18 )
            {
                Console.WriteLine("\nA idade digitada foi {0} e a Categoria é:: Juvenil 'B' ",idade);
            }
            else if (idade >= 18)
            {
                Console.WriteLine("\nA idade digitada foi {0} e a Categoria é: Adulto ",idade);
            }
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("=O programa será encerrado=");
            Console.WriteLine("===========================");
            Console.ReadLine();
        }
    }
}
