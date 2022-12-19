using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exercicio043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*43) Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria qualquer preço. 
             * O monge, necessitando de alimentos, indagou à rainha sobre o pagamento, se poderia ser feito
             * com grãos de trigo dispostos em um tabuleiro de xadrez, de tal forma que o primeiro quadro 
             * deveria conter apenas um grão e os quadros subseqüentes, o dobro do quadro anterior.
             * A rainha achou o trabalho barato e pediu que o serviço fosse executado, sem se dar conta de 
             * que seria impossível efetuar o pagamento. Faça um programa para calcular o número de grãos
             * que o monge esperava receber. */

            decimal graosCasa = 1;
            decimal soma = 0;

            for (int x = 1; x <= 64; x++)
            {
                graosCasa = graosCasa * 2;
                soma= soma + graosCasa;
                Console.WriteLine("{0}  {1}", x,soma);
            }

            Console.WriteLine("\nO quantidade de grãos é: {0} ", soma);
            Console.ReadLine();
        }
    }
}
