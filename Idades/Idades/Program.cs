using System.Globalization;

double idade, cont, media, soma;

idade = double.Parse(Console.ReadLine());
cont = 0;
soma = 0;
while (idade > 0){
    soma = soma + idade;
    cont = cont + 1;
    idade = double.Parse(Console.ReadLine());
}
media = (double)soma / cont; 
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));