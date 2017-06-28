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
            int n1, n2, quociente;

            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite outro número:");
            n2 = int.Parse(Console.ReadLine());

            if (n2 != 0)
            {
                quociente = n1 / n2;
            }
            else
            {
                Console.WriteLine("Não há divisão por zero.");
            }
            Console.ReadKey();
        }
    }
}


/* Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, calcular e imprimir o quociente do primeiro pelo segundo. Caso  contrário, 
imprimir a mensagem: "DIVISÃO POR ZERO".*/