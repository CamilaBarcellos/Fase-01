
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv11
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, terco = 0;

            Console.WriteLine("Digite um número real que não seja inteiro: ");
            n1 = float.Parse(Console.ReadLine());

            terco = n1 / 3;

            Console.WriteLine("\nA terça parte do número digitado é: {0}", terco);


            Console.ReadLine();
        }
    }
}