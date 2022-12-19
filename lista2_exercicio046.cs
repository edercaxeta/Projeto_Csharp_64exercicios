using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*46) Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses 
             * vetores. Ou seja, realizar a soma de todos dos resultados da multiplicação de x[i] por y[i]. */

            Console.WriteLine("=Detemine o protudo escalar dos vetores=");
            Console.WriteLine("========================================");
           
            Console.Write("Digite a quantidade de números: ");
            int quantidade = int.Parse(Console.ReadLine());

            int[] numeroX = new int[quantidade];
            int[] numeroY = new int[quantidade];
            double[] multiplica = new double[quantidade];
            double soma = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("\nDigite o {0}° Número X: ", i + 1);
                numeroX[i] = int.Parse(Console.ReadLine());
                Console.Write("\nDigite o {0}° Número Y: ", i + 1);
                numeroY[i] = int.Parse(Console.ReadLine());
                multiplica[i] = numeroX[i] * numeroY[i];
                soma = soma + multiplica[i];
            }
            Console.Clear();
            Console.WriteLine("O produto escalar dos vetores é: {0} ",soma);
            Console.ReadLine();

        }
    }
}
