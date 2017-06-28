using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, x = 0, soma = 0;

            for (x = 0; x < 4; x++)
            {
                Console.WriteLine("Digite um número.");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    soma = soma + a;
                }
            }

            Console.WriteLine();

            Console.WriteLine("A soma dos números pares é = " + soma);
            Console.ReadKey();
        }
    }
}


// Ler 4 números inteiros e calcular a soma dos que forem par.