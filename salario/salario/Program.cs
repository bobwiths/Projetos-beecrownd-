using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int number, quantidadeHora;
            double valorHora, salario;

            number = int.Parse(Console.ReadLine());
            quantidadeHora = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = quantidadeHora * valorHora;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}