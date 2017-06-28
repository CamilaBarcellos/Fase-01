using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* conferi a resposta com a atividade pois tive dificuldades*/

namespace atv12
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a = 0, b, c, delta, x1, x2 = 0;

            while (a == 0)
            {
                Console.Write("Digite o coeficiente A: ");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Digite um valor diferente de zero para que seje valido uma equação do segundo grau.");
                    Console.WriteLine();
                }

            }
            Console.Write("Digite o coeficiente B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o coeficiente C: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            delta = (Math.Pow(b, 2)) - 4 * a * c;

                    if (delta < 0)
            {
                Console.WriteLine("Não existem raizes Reais.");
            }
            if (delta == 0)
            {
                x1 = -b + Math.Sqrt(delta) / (2 * a);
                x2 = -b - Math.Sqrt(delta) / (2 * a);
                Console.WriteLine("Raizes iguais.");
                Console.WriteLine("--------------");
                Console.WriteLine("X1 = " + x1 + " e X2 = " + x2);
            }
            if (delta > 0)
            {
                x1 = -b + Math.Sqrt(delta) / (2 * a);
                x2 = -b - Math.Sqrt(delta) / (2 * a);
                Console.WriteLine("Raizes diferentes.");
                Console.WriteLine("------------------");
                Console.WriteLine("X1 = " + x1 + " e X2 = " + x2);
            }
            Console.ReadKey();
        }
    }
}

/* Ler os três coeficientes de uma equação de segundo grau e determinar suas raízes*/