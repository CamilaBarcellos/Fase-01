using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv13
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldoInicial, saldoFinal = 0;

            Console.WriteLine("Digite o saldo: ");
            saldoInicial = double.Parse(Console.ReadLine());

            saldoFinal = saldoInicial + (saldoInicial * 0.01);

            Console.WriteLine("\nO novo saldo com reajuste de 1% é: {0}", saldoFinal);

            Console.ReadLine();
        }
    }
}