using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;

            Console.WriteLine("Digite um valor interio para x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um valor interio para y");
            y = int.Parse(Console.ReadLine());

            if (x % y == 0)
            {
                Console.WriteLine("X ({0}) é múltiplo de Y ({1})", x, y);
            }
            else
            {
                Console.WriteLine("X ({0}) não é múltiplo de Y ({1})", x, y);
            }
            Console.ReadKey();
        }
    }
}

/*Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.*/