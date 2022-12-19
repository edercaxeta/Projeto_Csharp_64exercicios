using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*33) Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma 
             * prova. O número de alunos é desconhecido. Os dados de um aluno são: número de matrícula e 
             * a sua nota na prova em questão. */

            Console.WriteLine("====Calcule a Media do Alunos====");
            Console.WriteLine("=================================");

            string matricula;
            double alunos = 0;
            double nota = 0;
            double media = 0;


            Console.Write("Digite o numero de alunos: ");
            alunos = double.Parse(Console.ReadLine());

            for (int i = 0; i < alunos; i++)
            {
                Console.Write("\nDigite a matricula do aluno: ");
                matricula = Console.ReadLine();
                Console.Write("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                media = media + nota;
            }
            media = media / alunos;

            Console.WriteLine("\nA media da notas dos {0} alunos é: {1}", alunos, media.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("======================================");
            Console.WriteLine("==================FIM=================");
            Console.WriteLine("======================================");
            Console.ReadLine();
        }
    }
}
