using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float PR1, PR2, media = 0;

            Console.WriteLine("Digite o valor da PR1: ");
            PR1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o valor da PR2: ");
            PR2 = float.Parse(Console.ReadLine());

            media = (PR1 + PR2) / 2;

            Console.WriteLine("\nA média final é: {0}", media);

            Console.ReadLine();
        }
    }
}