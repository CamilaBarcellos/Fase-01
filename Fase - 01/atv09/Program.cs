using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0;
            int soma = 0;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("\nA soma é: " + soma);

            Console.ReadLine();
        }
    }
}