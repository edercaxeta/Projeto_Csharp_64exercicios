using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: 
             * V = 3.14159 * R * R * A
             * Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura. */

            Console.WriteLine("Calcule o Volume de uma lata de oleo");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Informe o Raio da lata:");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Altura da lata: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;
            Console.WriteLine("O volume da lata é: {0}", volume.ToString(CultureInfo.InvariantCulture));
            
            Console.ReadLine();

        }
    }
}
