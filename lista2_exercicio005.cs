using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando 
             * um automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo
             * gasto na viagem e a velocidade média. Desta forma, será possível obter a distância percorrida 
             * com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor da distância, basta calcular a
             * quantidade de litros de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12. 
             * O programa deve apresentar os valores da velocidade média, tempo gasto, a distância
             * percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais. */

            Console.WriteLine("Descubra quantos litros de combustivel foram gastos: ");
            Console.WriteLine("_____________________________________________________");
            double kml = 12;
            Console.Write("Quanto você gastou para fazer a viagem(Horas)? ");
            double tempoGasto = double.Parse(Console.ReadLine());
            Console.Write("Qual foi a velocidade media(KM/H)? ");
            double velocidadeMedia = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            //calculo da distancia
            double distancia = tempoGasto * velocidadeMedia;

            //calculo da quantidade de litros
            double quantidadeLitros = distancia / kml;

            Console.WriteLine("A velocidade media foi: {0} KM/H", velocidadeMedia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O tempo gasto foi: {0} Horas", tempoGasto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A distancia percorida foi: {0} KM", distancia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A quantidade de litros ultilizadas foi: {0} Litros", quantidadeLitros.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
