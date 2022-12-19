using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4) Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e
             * multiplicação entre os valores lidos, baseando-se na utilização do conceito de propriedade
             * distributiva. Dica: se forem lidas as variáveis A, B, C e D, devem ser somados e multiplicados
             * os valores de A com B, A com C e A com D; depois B com C, B com D e por último C com D.
             * Note que para cada operação serão utilizadas seis combinações. Assim sendo, devem ser realizadas
             * doze operações de processamento, sendo seis para as adições e seis para as multiplicações. */

            Console.WriteLine("Digite quatro valores a serem somados e multiplicados entre si");
            Console.WriteLine("______________________________________________________________");

            Console.Write("Digite o primeiro: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto: ");
            int D = int.Parse(Console.ReadLine());
            Console.Clear();

            int somaAB = A + B;
            int multAB = A * B;
            Console.WriteLine("---RESPOSTAS---");
            Console.WriteLine("A e B");
            Console.WriteLine("{0} + {1}= {2}", A,B,somaAB);
            Console.WriteLine("{0} X {1}= {2}", A,B,multAB);
            Console.WriteLine();

            int somaAC = A + C;
            int multAC = A * C;
            Console.WriteLine("A e C");
            Console.WriteLine("{0} + {1}= {2}", A,C,somaAC);
            Console.WriteLine("{0} X {1}= {2}", A,C,multAC);
            Console.WriteLine();

            int somaAD = A + D;
            int multAD = A * D;
            Console.WriteLine("A e D");
            Console.WriteLine("{0} + {1}= {2}", A,D,somaAD);
            Console.WriteLine("{0} X {1}= {2}", A,D,multAD);
            Console.WriteLine();

            int somaBC = B + C;
            int multBC = B * C;
            Console.WriteLine("B e C");
            Console.WriteLine("{0} + {1}= {2}", B,C,somaBC);
            Console.WriteLine("{0} X {1}= {2}", B,C,multBC);
            Console.WriteLine();

            int somaBD = B + D;
            int multBD = B * D;
            Console.WriteLine("B e D");
            Console.WriteLine("{0} + {1}= {2}", B,D,somaBD);
            Console.WriteLine("{0} X {1}= {2}", B,D,multBD);
            Console.WriteLine();

            int somaCD = C + D;
            int multCD = C * D;
            Console.WriteLine("C e D");
            Console.WriteLine("{0} + {1}= {2}", C,D,somaCD);
            Console.WriteLine("{0} X {1}= {2}", C,D,multCD);

            Console.ReadLine();

        }
    }
}
