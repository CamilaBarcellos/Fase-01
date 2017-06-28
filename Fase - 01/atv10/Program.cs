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
            int n1, n2 = 0;
            int produto = 0;

            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite outro número: ");
            n2 = int.Parse(Console.ReadLine());

            produto = n1 * n2;

            Console.WriteLine("\n\nO produto entre os números é: " + produto);



            Console.ReadLine();
        }
    }
}