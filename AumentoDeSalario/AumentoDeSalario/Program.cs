using System.Globalization;

double salario;

salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (salario > 0 && salario < 400.01){
    Console.WriteLine("Novo salario: " + (salario + salario * 0.15).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + (salario * 0.15).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 15 %");
}else if (salario > 400.00 && salario < 800.01){
    Console.WriteLine("Novo salario: " + (salario + salario * 0.12).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + (salario * 0.12).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 12 %");
}else if (salario > 800.00 && salario < 1200.01){
    Console.WriteLine("Novo salario: " + (salario + salario * 0.10).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + (salario * 0.10).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 10 %");
}else if (salario > 1200.00 && salario < 2000.01){
    Console.WriteLine("Novo salario: " + (salario + salario * 0.07).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + (salario * 0.07).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 7 %");
}
else {
    Console.WriteLine("Novo salario: " + (salario + salario * 0.04).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Reajuste ganho: " + (salario * 0.04).ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Em percentual: 4 %");
}