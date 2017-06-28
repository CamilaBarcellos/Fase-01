using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b = 0;

            Console.WriteLine("Digite o valor de A.");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o valor de B.");
            b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} é maior que {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} é maior que {1}", b, a);
            }
            Console.ReadKey();
        }
    }
}

/*Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é o maior, ou a mensagem "A = B" caso sejam iguais.*/