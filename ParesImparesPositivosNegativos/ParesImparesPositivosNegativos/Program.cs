double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double d = double.Parse(Console.ReadLine());
double e = double.Parse(Console.ReadLine());

double contPositivo = 0;
double contNegativo = 0;
double contPar = 0;
double contImpar = 0;

//a
if (a > 0.0)
{
    contPositivo = contPositivo + 1;
}
if (a < 0.0)
{
    contNegativo = contNegativo + 1;
}
if (a % 2 == 0)
{
    contPar = contPar + 1;
}
if (a % 2 == 1)
{
    contImpar = contImpar + 1;
}
//b
if (b > 0.0)
{
    contPositivo = contPositivo + 1;
}
if (b < 0.0)
{
    contNegativo = contNegativo + 1;
}
if (b % 2 == 0)
{
    contPar = contPar + 1;
}
if (b % 2 == 1)
{
    contImpar = contImpar + 1;
}
//c
if (c > 0.0)
{
    contPositivo = contPositivo + 1;
}
if (c < 0.0)
{
    contNegativo = contNegativo + 1;
}
if (c % 2 == 0)
{
    contPar = contPar + 1;
}
if (c % 2 == 1)
{
    contImpar = contImpar + 1;
}
//d
if (d > 0.0)
{
    contPositivo = contPositivo + 1;
}
if (d < 0.0)
{
    contNegativo = contNegativo + 1;
}
if (d % 2 == 0)
{
    contPar = contPar + 1;
}
if (d % 2 == 1)
{
    contImpar = contImpar + 1;
}
//e
if (e > 0.0)
{
    contPositivo = contPositivo + 1;
}
if (e < 0.0)
{
    contNegativo = contNegativo + 1;
}
if (e % 2 == 0)
{
    contPar = contPar + 1;
}
if (e % 2 == 1)
{
    contImpar = contImpar + 1;
}
Console.WriteLine(contPar + " valor(es) par(es)");
Console.WriteLine(contImpar + " valor(es) impar(es)");
Console.WriteLine(contPositivo + " valor(es) positivo(s)");
Console.WriteLine(contNegativo + " valor(es) negativo(s)");