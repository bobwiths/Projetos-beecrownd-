string palavra1, palavra2, palavra3;

palavra1 = Console.ReadLine();
palavra2 = Console.ReadLine();
palavra3 = Console.ReadLine();

if (palavra1 == "vertebrado"){
    if (palavra2 == "ave"){
        if (palavra3 == "carnivoro"){
            Console.WriteLine("aguia");
        }
        //onivoro
        else{
            Console.WriteLine("pomba");
        }
    }
    //mamifero
    else{
        if (palavra3 == "onivoro"){
            Console.WriteLine("homem");
        }
        //herbivoro
        else{
            Console.WriteLine("vaca");
        }
    }
}

//invertebrado
else{
    if (palavra2 == "inseto"){
        if (palavra3 == "hematofago"){
            Console.WriteLine("pulga");
        }
        //herbivoro
        else{
            Console.WriteLine("lagarta");
        }
    }
    //anelideo
    else{
        if(palavra3 == "hematofago"){
            Console.WriteLine("sanguessuga");
        }
        //onivoro
        else{
            Console.WriteLine("minhoca");
        }
    }
}