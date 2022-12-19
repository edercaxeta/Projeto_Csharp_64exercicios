using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*50) Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário 
             * (sem conhecer o número sorteado) tente acertar. Caso não acerte, o programa deve imprimir
             * uma mensagem informando se o número sorteado é maior ou menor que a tentativa feita.
             * Ao acertar o número, o programa deve imprimir a quantidade de tentativas feitas. */

            Console.WriteLine("==========Acerte o numero========");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Random random = new Random();
            int valorEscondido = random.Next(0,100);

            int contador = 0;
            int numerodigitado = 0;

            while(numerodigitado != valorEscondido)
            {
                if (contador == 0)
                    Console.WriteLine("Tente descobrir, Digite um Numero! ");
                else
                    Console.WriteLine("Tente descobrir o numero novamente! ");
                numerodigitado = int.Parse(Console.ReadLine());

                if(numerodigitado > valorEscondido)
                    Console.WriteLine("O numero escondido é menor.");
                else if(numerodigitado < valorEscondido)
                    Console.WriteLine("O numero escondido é maior.");
                else
                    Console.WriteLine("\nParabéns vocé descobriu o numero secreto: {0}", valorEscondido);
                contador++;
            }
            Console.WriteLine("\nO numero de tentativas foi de: {0}", contador);
            Console.ReadLine();
        }
    }
}
