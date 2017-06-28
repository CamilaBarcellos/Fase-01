using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv15
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nTodo o nome: {0}", nome);
            Console.WriteLine("\nPrimeiro caractere: {0}", nome.Substring(0, 1));
            Console.WriteLine("\nÚltimo caractere: {0}", nome.Substring(nome.Length - 1, 1);
            Console.WriteLine("\nDo primeiro até o terceiro: {0}", nome.Substring(0, 3));
            Console.WriteLine("\nQuarto caractere: {0}", nome.Substring(3, 1));
            Console.WriteLine("\nTodos menos o primeiro: {0}", nome.Substring(1, nome.Length - 1));
            Console.WriteLine("\nOs dois últimos: {0}", nome.Substring(nome.Length - 2, 2));


            Console.ReadLine();
        }
    }
}