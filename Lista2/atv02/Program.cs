using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace atv02
{
    class Program
    {
        static void Main(string[] args)
        {
            double notab1, notab2, notab3, falta = 0;

            Console.WriteLine("Digite a nota do primeiro bimestre.");
            notab1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a nota do segundo bimestre.");
            notab2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a nota do terceiro bimestre.");
            notab3 = double.Parse(Console.ReadLine());

            falta = (40 - (notab1 + notab2 + notab3)) / 4;

            Console.WriteLine("\nFaltam {0} pontos para ser aprovado.", falta);
            Console.ReadKey();
        }
    }
}
/*Calcular a nota necessária para passar por média no 4º bimestre. Dados: notas dos 3 bimestres.*/