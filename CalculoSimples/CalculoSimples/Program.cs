using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, peca2, numeroPeca1, numeroPeca2;
            double valorPeca1, valorPeca2, total;

            string[] vet = Console.ReadLine().Split(' ');
            peca1 = int.Parse(vet[0]);
            numeroPeca1 = int.Parse(vet[1]);
            valorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            peca2 = int.Parse(vet2[0]);
            numeroPeca2 = int.Parse(vet2[1]);
            valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));






        }

    }

}