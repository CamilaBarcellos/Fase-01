using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo = 0;
    }
            public void Saque(double valor) 
            {       
                if (this.saldo >= 100.00)
                {
                     this.saldo -= 100.00;
                }
            }
                    
        

        private void button1_Click(object sender, EventArgs e)
    {
        Conta c = new Conta();
        c.numero = 1;
        c.titular = "Camila";
        c.saldo = 100.00;
    }


        
}
