using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*40) A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de
             * indústrias que são altamente poluentes do meio ambiente. O índice de poluição aceitável
             * varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias do 1o grupo são intimadas 
             * a suspenderem suas atividades, se o índice crescer para 0,4 as industrias do 1o e 2o grupo
             * são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos devem
             * ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição 
             * medido e emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve
             * parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". */

            Console.WriteLine("======Indice de Poluição======");
            Console.WriteLine("==============================");
            Console.WriteLine();
            double indiceP = 0;
            string resposta;

            do
            { 
                Console.WriteLine("Digite o indice de poluição medido");
                indiceP = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                if (indiceP >= 0.05 && indiceP <= 0.25)
                {
                    Console.WriteLine("Indice de poluição aceitavel.");
                }
                else if (indiceP <= 0.3)
                {
                    Console.WriteLine("Suspender atividades do 1° Grupo das indústrias !");
                }
                else if (indiceP <= 0.4)
                {
                    Console.WriteLine("Suspender atividades do 1° e do 2° grupo das indústrias !");
                }
                else if (indiceP < 0.5)
                {
                    Console.WriteLine("Suspender atividades de todos grupos das indústrias !");
                }
                else if (indiceP >= 0.5) 
                {
                    Console.WriteLine("Paralisem atividades de todos grupos das indústrias!");
                }

                Console.Write("\nDeseja encerrar o programa(S/N): ");
                resposta = Console.ReadLine();

                while (resposta != "n" && resposta != "N" && resposta != "s" && resposta != "S")
                {
                    Console.WriteLine("Opção invalida, Repita!");
                    resposta = Console.ReadLine();
                }

            } while (resposta.ToUpper() == "N");
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("=O programa será encerrado=");
            Console.WriteLine("===========================");
            Console.ReadLine();
          
        }
    }
}
