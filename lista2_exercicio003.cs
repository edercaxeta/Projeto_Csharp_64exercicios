using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lista2_exercicio003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3) Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração
             * que sua comissão será de 5% do total da venda e que você tem os seguintes dados: 
             * Identificação do vendedor 
             * Código da peça 
             * Preço unitário da peça
             * Quantidade vendida */

            Console.WriteLine("---Calculador de comissão---");
            Console.WriteLine("----------------------------");
            Console.Write("Digite o código do vendedor: ");
            string codigoVendedor = Console.ReadLine();
            Console.Write("Digite código do produto: ");
            string codigoProduto = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine());

            double valorTotal = valorProduto * quantidade;

            double comissao = (valorTotal * 5) / 100;
            Console.Clear();

            Console.WriteLine("O vendedor {0} vendeu {1} itens do produto {2} é vai receber: R${3}", codigoVendedor, quantidade, codigoProduto, comissao.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.ReadLine();
        }
    }
}
