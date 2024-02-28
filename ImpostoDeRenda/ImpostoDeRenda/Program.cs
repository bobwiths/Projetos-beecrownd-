using System.Globalization;

double salario, imposto;

salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (salario < 2000.01){
    Console.WriteLine("Isento");
}
else if (salario < 3000.01){
    imposto = (salario - 2000.0) * 0.08;
    Console.WriteLine("R$ " +  imposto.ToString("F2", CultureInfo.InvariantCulture));    
}
else if (salario < 4500.01){
    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
}
else{
    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
}
