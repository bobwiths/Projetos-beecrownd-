int codigo, alcool, gasolina, diesel;

codigo = int.Parse(Console.ReadLine());
alcool = 0;
gasolina = 0;
diesel = 0;

while (codigo != 4){
    if (codigo == 1){
        alcool = alcool + 1;
    }
    else if (codigo == 2){
        gasolina = gasolina + 1;
    }
    else if (codigo == 3){
        diesel = diesel + 1;
    }
    codigo = int.Parse(Console.ReadLine());
}
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: " + alcool);
Console.WriteLine("Gasolina: " + gasolina);
Console.WriteLine("Diesel: " +  diesel);   
