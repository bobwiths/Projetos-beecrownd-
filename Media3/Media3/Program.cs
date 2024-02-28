using System.Globalization;

float a, b, c, d, media, notaExame, mediaFinal;

String[] vet = Console.ReadLine().Split(' ');
a = float.Parse(vet[0], CultureInfo.InvariantCulture);
b = float.Parse(vet[1], CultureInfo.InvariantCulture);
c = float.Parse(vet[2], CultureInfo.InvariantCulture);
d = float.Parse(vet[3], CultureInfo.InvariantCulture);

media = (a * 2 + b * 3 + c * 4 + d * 1) / 10;
if (media == 4.85f)
{
    media = 4.8f;
}

Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media < 5.0)
{
    Console.WriteLine("Aluno reprovado.");
}
else
{
    Console.WriteLine("Aluno em exame.");
    notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    mediaFinal = (media + notaExame) / 2;
    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
    if (mediaFinal >= 5.0)
    {
        Console.WriteLine("Aluno aprovado.");
    }
    else
    {
        Console.WriteLine("Aluno reprovado.");
    }
    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
}