
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerImprimirNomeEndTel
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone = "";
            Console.WriteLine("Digite seu nome: \n");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite seu endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("\nDigite seu telefone: ");
            telefone = Console.ReadLine();
            Console.WriteLine("\nNome: {0}\nEndereco: {1}\nTelefone: {2}", nome, endereco, telefone);


            Console.ReadLine();
        }
    }
}