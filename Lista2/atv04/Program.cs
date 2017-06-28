using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, resto, quociente = 0;

            Console.WriteLine("Digite um número inteiro para x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite um número inteiro para y:");
            y = int.Parse(Console.ReadLine());

            if (y == 0)
            {
                Console.WriteLine("\nNão há divisão por zero.");
            }
            else
            {
                quociente = (x / y);
                resto = (x % y);
                Console.WriteLine("\nO quociente é: {0} e o resto é: {1}", quociente, resto);
            }
            Console.ReadKey();
        }
    }
}

/*Ler dois números inteiros,X e Y, e imprimir o quociente e o resto da divisão inteira entre eles.*/