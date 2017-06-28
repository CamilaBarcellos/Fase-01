using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atv01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, sucessor = 0;

            Console.WriteLine("Digite um número?");
            n1 = int.Parse(Console.ReadLine());

            sucessor = 0;
            sucessor = sucessor + 1;

            Console.WriteLine("\nO sucessor de {0} é: {1}", n1, sucessor);
            Console.ReadKey();
        }
    }
}

/*Leia um número e e exiba o seu sucessor*/
