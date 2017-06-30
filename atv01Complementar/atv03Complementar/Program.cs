using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceiraImpostoRendaFixa
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorAplicado, rendimentofixo, rendimento, total = 0;
            int tempo = 0, i = 0;

            Console.WriteLine("Digite o valor a ser aplicado:");
            valorAplicado = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o percentual do rendimento mensal:");
            rendimento = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o percentual do rendimento fixo:");
            rendimentofixo = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite quantos meses o dinheiro ficará aplicado:");
            tempo = int.Parse(Console.ReadLine());


            do
            {
                total = (valorAplicado * (rendimento / 100)) + valorAplicado;
                i += 1;
            }
            while (i <= tempo);

            Console.WriteLine("\nO valor aplicado será R${0} no último mês!", total);
            Console.ReadKey();
        }
    }
}