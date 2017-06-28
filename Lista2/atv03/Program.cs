using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atv03
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdedia, qtdetotal,qtdeano, anos = 0;
            double precounidade, precocarteira, totalgasto = 0;

            Console.WriteLine("Digite quantos anos você fuma:");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite quantos cigarros você fuma por dia:");
            qtdedia = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o preço da carteira de cigarros:");
            precocarteira = double.Parse(Console.ReadLine());

            precounidade = (precocarteira / 20);
            qtdeano = (qtdedia * 365);
            qtdetotal = (qtdeano * anos);
            totalgasto = (qtdetotal * precounidade);

            Console.WriteLine("\nVocê já fumou {0} cigarros e gastou R${1} até hoje.", qtdetotal, totalgasto);


            Console.ReadKey();
        }
    }
}


/* Calcular a quantidade de dinheiro gasta por um fumante. Dados: o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.*/