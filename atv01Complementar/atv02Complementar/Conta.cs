using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv02Complementar
{
    public class Conta
    {
        public double ValorInvestido { get; set; }
        public int TempoInvestimento { get; set; }
        public double TaxaJuros { get; set; }
        public double ValorTotal { get; set; }
        public double Juros { get; set; }
        public IList<double> ListaJurosMes = new List<double>();


        public void CalcularJuros()
        {
            ValorTotal = ValorInvestido;

            for (var i = 1; i <= TempoInvestimento; i++)
            {
                Juros = ValorTotal * (TaxaJuros / 100);
                ValorTotal += Juros;

                ListaJurosMes.Add(Juros);
            }
        }

        public void PreencheConta(Conta conta)
        {
            ValorInvestido = conta.ValorInvestido;
            TempoInvestimento = conta.TempoInvestimento;
            TaxaJuros = conta.TaxaJuros;
        }

    }
}
