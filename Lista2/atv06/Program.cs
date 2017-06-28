using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv06
{
    class Program
    {
        static void Main(string[] args)
        {
        double n1, n2, soma, resto, quociente = 0;

        Console.WriteLine("Digite um número real:");
            n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite outro número real:");
            n2 = double.Parse(Console.ReadLine());

        Console.WriteLine();
 
            soma = n1 + n2;
 
            if (n1 == 0)
            {
                Console.WriteLine("\nNão há divisão por zero.");
            }
            else
            {
                quociente = n1 / n2;
                resto = n1 % n2;
                Console.WriteLine("\nO quociente é {0}, o resto é {1} e a soma é {2}.", quociente, resto, soma);
                Console.ReadKey();

            }
        }
    }
}

/*Fazer um algoritmo para ler dois valores reais do teclado, calcular e imprimir na tela: 
 a) A soma destes valores b) O produto deles c) O quociente entre eles*/