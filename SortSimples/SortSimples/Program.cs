int a, b, c;

String[] valores = Console.ReadLine().Split(' ');

a = int.Parse(valores[0]);
b = int.Parse(valores[1]);
c = int.Parse(valores[2]);

if (a < b && a < c){
    if (c > b) {
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    else{
        Console.WriteLine(a);
        Console.WriteLine(c);
        Console.WriteLine(b);
    }
}
else if (a > b && b < c){
    if (a > c)
    {
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(b);
        Console.WriteLine(a);
        Console.WriteLine(c);
    }
}
else if (a > c && b > c){
    if (b > a){
        Console.WriteLine(c);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    else{
        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(a);
    }
}
Console.WriteLine();
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);