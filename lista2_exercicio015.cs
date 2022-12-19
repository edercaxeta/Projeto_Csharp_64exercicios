using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*15) Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem
             * que o aluno foi aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da 
             * média for menor que 7, solicitar a nota do recuperação, somar com o valor da média e obter a
             * nova média. Se a nova média for maior ou igual a 7, apresentar uma mensagem informando que o
             * aluno foi aprovado na recuperação. Se o aluno não foi aprovado, apresentar uma mensagem
             * informando esta condição. Apresentar junto com as mensagens o valor da média do aluno.*/

            double nota1 = 0;
            double notaRecuperacao = 0;
            double resultado = 0;
            double media = 0;
            double mediaFinal = 0;

            Console.WriteLine("Aprovado Ou Recuparação");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite a Nota do {0}° aluno: ",i);
                 nota1 = double.Parse(Console.ReadLine());
                 resultado += nota1;
            }
            media = resultado / 4;
            if (media >= 7 )
            {
                Console.WriteLine("A media do Aluno foi {0}. Está Aprovado, PARABÉNS. ", media);
            }
            else
            {
                Console.Write("Sua media foi {0}. Digite a nota da recuperação: ", media);
                notaRecuperacao = double.Parse(Console.ReadLine());
                mediaFinal = (media + notaRecuperacao) / 2;
                
                if (mediaFinal >= 7)
                {
                    Console.WriteLine("A media do foi {0}. Aluno Aprovado na Recuperação. ", mediaFinal);
                }
                else
                {
                    Console.WriteLine("A media final foi {0}. Aluno Reprovado, Estude Mais.", mediaFinal);
                }

            }
            
            Console.ReadLine();
        }
    }
}
