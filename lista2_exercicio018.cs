using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18) Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é
             * igual a 1, igual a 2 ou igual a 3. Caso não seja, apresentar a mensagem "Código inválido".
             * Ao ser verificado o código e constatado que é um valor válido, o programa deve verificar cada
             * código em separado para determinar seu valor por extenso, ou seja, apresentar a mensagem "um",
             * "dois" ou "três”. (Utilizar o comando Switch). */

            int codigo = 0;
            Console.WriteLine("Numero em Extenso");
            Console.WriteLine("-----------------");

            Console.Write("Digite um Numero: ");
            codigo = int.Parse(Console.ReadLine());

            
            if (codigo == 1 || codigo == 2 || codigo == 3)
            {
                switch (codigo)
                {

                    case 1:
                            Console.WriteLine("\n Um é o valor por Extenso do numero {0}", codigo);
                    break;

                    case 2:
                        Console.WriteLine("\n Dois é o valor por Extenso do numero {0}", codigo);
                    break;

                    case 3:
                        Console.WriteLine("\n Três é o valor por Extenso do numero {0}", codigo);
                    break;
                    default:

                        Console.WriteLine("\n Algo Deu Errado");
                    break;
                }
            }
            else
            {
                Console.WriteLine("\n Código Invalido");
            }
            Console.ReadLine();
        }
    }
}
