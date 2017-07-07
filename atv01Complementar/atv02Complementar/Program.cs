using atv02Complementar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinanceira
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            ContaRendaFixa contaRendaFixa = new ContaRendaFixa();

            Console.WriteLine("Digite o valor a ser aplicado:");
            conta.ValorInvestido = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o percentual do rendimento poupança:");
            contaPoupanca.TaxaJurosPoupanca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o percentual do rendimento da renda fixa:");
            contaRendaFixa.TaxaJurosRendaFixa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite quantos meses o dinheiro ficará aplicado:");
            conta.TempoInvestimento = Convert.ToInt32(Console.ReadLine());

            contaPoupanca.PreencheConta(conta);
            contaRendaFixa.PreencheConta(conta);

            contaPoupanca.CalculaPoupanca();
            contaRendaFixa.CalculaRendaFixa();


            Console.WriteLine("\n============================================================");

            foreach (var listaP in contaPoupanca.ListaJurosMes)
            {
                Console.WriteLine("Juros mês poupança {0 :0.##}", listaP);
            }

            Console.WriteLine("\n============================================================");

            foreach (var listaR in contaRendaFixa.ListaJurosMes)
            {
                Console.WriteLine("Juros mês Renda Fixa {0 :0.##}", listaR);
            }

            Console.WriteLine("\n============================================================");

            Console.WriteLine("\no valor total da aplicação poupanca e {0 :0.##}.", contaPoupanca.ValorTotal);

            Console.WriteLine("\no valor total da aplicação renda fixa e {0 :0.##} sem imposto de renda.", contaRendaFixa.ValorTotal);

            Console.WriteLine("\no valor total da aplicação renda fixa e {0 :0.##} com imposto de renda.", contaRendaFixa.TotalComIR);

            Console.WriteLine("\n============================================================");

            if (contaPoupanca.ValorTotal > contaRendaFixa.TotalComIR)
            {
                Console.WriteLine("Nós indicamos o investimento em Conta Poupança, com rendimento de: {0 :0.##}", contaPoupanca.ValorTotal - contaPoupanca.ValorInvestido);
            }
            else if (contaPoupanca.ValorTotal < contaRendaFixa.TotalComIR)
            {
                Console.WriteLine("Nós indicamos o investimento em Renda Fixa, com rendimento de: {0 :0.##}", contaRendaFixa.TotalComIR - contaRendaFixa.ValorInvestido);
            }
            else
                Console.WriteLine("Os dois investimentos rendem o mesmo valor.");
            
            Console.ReadLine();
        }
    }
}