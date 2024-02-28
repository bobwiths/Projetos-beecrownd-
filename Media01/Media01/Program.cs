using System;
using System.Globalization;

namespace curso{
    class Program{
        static void Main(string[] args) {
        
            double a, b, c, media;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((a * 3.5) + (b * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));


        
        
        }
    }
}