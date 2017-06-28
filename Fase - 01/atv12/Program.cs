
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv12
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, media = 0;

            Console.WriteLine("Digite um número real: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número: ");
            n2 = float.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("\nMedia antes do resultado: {0}", media);

            Console.ReadLine();
        }
    }
}