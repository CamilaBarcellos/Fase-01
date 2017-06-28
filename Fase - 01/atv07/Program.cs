using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antecessorSucessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            Console.WriteLine("Insira um número inteiro: \n");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nO antecessor do número inserido é: " + (n1 - 1));
            Console.WriteLine("\nO sucessor do número inserido é: " + (n1 + 1));


            Console.ReadLine();
        }
    }
}