using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9)Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e 
             * escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e
             * mês com 30 dias. */

            Console.WriteLine("calculador de Idade em dias:");
            Console.WriteLine("----------------------------");

            Console.Write("Que dia é hoje? ");
            int queDia = int.Parse(Console.ReadLine());
            Console.Write("Que dia você nasceu? ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("\nQue mês estamos? ");
            int quemes = int.Parse(Console.ReadLine());
            Console.Write("Que mês você nasceu? ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("\nQue ano Estamos? ");
            int queano = int.Parse(Console.ReadLine());
            Console.Write("Que ano você nasceu? ");
            int ano = int.Parse(Console.ReadLine());

            int idade = (queano - ano) * 365;
            int idademes = ((quemes - 1) - mes) * 30;
            int idadedia = (queDia - dia) ;

            int resultado = idade + idademes + idadedia;
            Console.WriteLine("\nVocê tem {0} dias de vida.", resultado);

            int resultadohoras = resultado * 24;
            Console.WriteLine("\nVocê te {0} horas de vida.", resultadohoras);

            Console.ReadLine();
        }
    }
}
