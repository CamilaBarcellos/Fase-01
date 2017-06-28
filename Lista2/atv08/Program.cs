using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv08
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3 = 0;

            Console.WriteLine("Digite o 1º número.");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o 2º número.");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o 3º número.");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > (n2 + n3))
            {
                Console.WriteLine("\n{0} é maior que a soma de {1} + {2}", n1,n2,n3);
            }
            else
            {
                Console.WriteLine("\n{0} não é maior que a soma de {1} + {2}", n1, n2, n3);
            }
            Console.ReadKey();
        }
    }
}

/* Fazer um algoritmo para ler 03 números reais do teclado e verificar se o primeiro é maior que a soma dos outros dois.*/