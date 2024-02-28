using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double salarioFixo, totalVendas, totalComissao;

            nome = (Console.ReadLine());
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalComissao = salarioFixo + (totalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + totalComissao.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}