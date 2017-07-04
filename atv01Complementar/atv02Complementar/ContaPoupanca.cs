using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv02Complementar
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJurosPoupanca { get; set; }


        public void CalculaPoupanca()
        {
            TaxaJuros = TaxaJurosPoupanca;
            base.CalcularJuros();
        }

    }
}
