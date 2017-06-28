using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv09
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Camila";

            Console.WriteLine("Digite o nome:");
            nome = string.Format(Console.ReadLine());

            if (nome == "Camila")
            {
                Console.WriteLine("Nome Correto.");
            }
            else
            {
                Console.WriteLine("Nome Incorreto.");
            }
            Console.ReadKey();
        }
    }
}

/* Ler um nome do teclado e verificar se é igual ao seu nome. Imprimir  conforme o caso: " NOME CORRETO "  ou  " NOME INCORRETO ".*/