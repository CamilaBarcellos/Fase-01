using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            double investimento = 100;
            int percentual = 10;
            int tempo = 3;
            double totalinvestimento = 0;
            double rendimento = 0;

            rendimento = ((percentual / 100) * tempo);
            
            

            Console.WriteLine("total: {0}", rendimento);
            Console.ReadKey();

        }
    }
}
