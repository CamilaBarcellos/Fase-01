using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv02Complementar
{
    public class ContaRendaFixa : Conta
    {
        public double TaxaJurosRendaFixa { get; set; }
        public double Imposto { get; set; }
        public double TotalComIR { get; set; }

        public void CalculaRendaFixa()
        {
            TaxaJuros = TaxaJurosRendaFixa;
            base.CalcularJuros();

            ImpostoDeRenda();
        }
    
        private void ImpostoDeRenda()
        {
            var valor = ValorTotal - ValorInvestido;

            if(TempoInvestimento <= 12)
            {
                Imposto = valor * 0.25;
            }
            else if(TempoInvestimento <= 24)
            {
                Imposto = valor * 0.15;
            }
            else if(TempoInvestimento <= 36)
            {
                Imposto = valor * 0.05;
            }
            else
            {
                Imposto = valor * 0.01;
            }

            TotalComIR = ValorTotal - Imposto;

        }

    }
}
