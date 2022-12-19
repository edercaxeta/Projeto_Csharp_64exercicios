using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio59_DistanciaCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*59) Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número 
             * de caracteres existente entre eles. Assuma que o usuário digite os 2 caracteres em ordem
             * alfabética. Caso não o estejam, emitir mensagem de erro. 
             * Exemplo: Digite 2 caracteres: jt O numero de caracteres entre eles é: 9 */

            string[] vocabulario = {"A","B","C","D","E","F","G",
                                    "H","I","J","K","L","M","N",
                                    "O","P","Q","R","S","T","U",
                                    "V","W","X","Y","Z"};

            string primeiraLetra = string.Empty;
            string segundaLetra = string.Empty;

            do
            {
                Console.WriteLine("Digite a primeira letra");
                primeiraLetra = Console.ReadLine();

                Console.WriteLine("Digite a segunda letra");
                segundaLetra = Console.ReadLine();

                if (primeiraLetra == segundaLetra)
                {
                    Console.WriteLine("Informe letras diferentes");
                    Console.WriteLine("Digite novamente...");
                    Console.WriteLine("-------------------------");
                }

            } while (primeiraLetra == segundaLetra);

            int posicaoPrimeiraLetra = 0;
            int posicaoSegundaLetra = 0;
            int distancia = 0;
            bool validacao = true;
            for (int i = 0; i < vocabulario.Count(); i++)
            {
                if (vocabulario[i] == primeiraLetra)
                    posicaoPrimeiraLetra = i;

                if (vocabulario[i] == segundaLetra)
                    posicaoSegundaLetra = i;

                if (posicaoPrimeiraLetra != 0 &&
                    posicaoSegundaLetra != 0 &&
                    posicaoSegundaLetra <= posicaoPrimeiraLetra)
                {
                    Console.WriteLine("As letras informadas não estão em ordem alfabética!");
                    validacao = false;
                    break;
                }
            }

            if (validacao == true)
            {
                if (posicaoSegundaLetra != 0)
                    distancia = posicaoSegundaLetra - posicaoPrimeiraLetra;

                Console.WriteLine("A distância entre as letras é de {0}", distancia);
            }
            Console.ReadLine();
        }
    }
}
