using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor da taxa de esgoto: ");
            double taxa = double.Parse(Console.ReadLine());

            Console.Write("Informe o total da conta: ");
            double valorConta = double.Parse(Console.ReadLine());

            double percentualTaxa = (taxa / valorConta) * 100;

            Console.Write("O percentual da taxa é: " + percentualTaxa + " %");

            Console.ReadKey();

        }
    }
}
