using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*38) Faça um programa que leia as variáveis C e N, respectivamente código e número de horas 
             * trabalhadas de um operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora.
             * Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na 
             * variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00.
             * No final do processamento imprimir o salário total e o salário excedente. O programa só deve 
             * parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
             * programa?". */

            Console.WriteLine("==Programa de calculo de banco de horas==");
            Console.WriteLine("=========================================");

            string codigoC;
            double horatrabalhadaN = 0;
            double salarioTotal = 0;
            double excessoE = 0;
            double salarioexcedente = 0;
            string resposta;

            do
            {
                Console.Write("\nDigite o Codigo do funcionario: ");
                codigoC = Console.ReadLine();
                Console.Write("\nDigite o numero de horas trabalhadas pelo operário: ");
                horatrabalhadaN = double.Parse(Console.ReadLine());

                if (horatrabalhadaN > 50)
                {
                    excessoE = horatrabalhadaN - 50;
                }
                else
                {
                    excessoE = 0;
                }
                salarioexcedente = excessoE * 20;
                salarioTotal = 500 + salarioexcedente;

                Console.WriteLine("O salario total do funcionario '{0}' é R${1:f2} e o excedente foi R${2:f2}.",codigoC, salarioTotal, salarioexcedente);

                Console.WriteLine("\nDeseja encerrar o programa(S/N)");
                resposta = Console.ReadLine();
                while (resposta != "n" && resposta != "N" && resposta != "s" && resposta != "S")
                {
                    Console.WriteLine("Opção invalida, Repita!");
                    resposta = Console.ReadLine();
                }
            }while(resposta.ToUpper()== "N");

            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("=O programa será encerrado=");
            Console.WriteLine("===========================");
            Console.ReadLine();
        }
    }
}
