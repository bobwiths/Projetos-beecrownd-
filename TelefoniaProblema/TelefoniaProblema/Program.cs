using System.Globalization;
using System.Numerics;

int minutos, franquia, total, plano;

minutos = int.Parse(Console.ReadLine());
franquia = minutos - 100;
plano = 50;
total = (franquia * 2) + plano;


if (franquia > 0){
    Console.WriteLine("Valor a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

}else{
    Console.WriteLine("Valor a pagar: R$ " + plano.ToString("F2", CultureInfo.InvariantCulture));
}


