using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double volume, pi, raio;

            pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4/3.0) * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}