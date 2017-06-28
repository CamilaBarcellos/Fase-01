using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv07
{
    class Program
    {
        static void Main(string[] args)
        {
            double notab1, notab2, notab3, notab4, media = 0;

            Console.WriteLine("Digite a nota do 1º bimestre:");
            notab1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a nota do 2º bimestre:");
            notab2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a nota do 3º bimestre:");
            notab3 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a nota do 4º bimestre:");
            notab4 = double.Parse(Console.ReadLine());

            media = (notab1 + notab2 + notab3 + notab4) / 4;

            if (media < 6)
            {
                Console.WriteLine("\n\nALUNO REPROVADO!");
            }
            else
            {
                Console.WriteLine("\n\nALUNO APROVADO!");
            }

            Console.ReadKey();

        }
    }
}




/*  7.   Calcular a média final  (nota bimestre 1 + bimestre 2 +  bimestre3 dividido por 3 )
 dadas as  notas dos 4 bimestres e produzir uma saída com a média e a situação do aluno de
acordo com o seguinte critério: média >=6, aprovado; média < 6, reprovado.a*/