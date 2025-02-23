//algorithme de Sylvain

int Nombre = 1;
string Fizz = "Fizz";
string Buzz = "Buzz";
string FizzBuzz = "FizzBuzz ";
while (Nombre <= 100) // tant que Nombre est <= 100
{
    int Modulo3 = Nombre % 3; // calcul le modulo 3 en fonction du nombre actuel
    int Modulo5 = Nombre % 5; // calcul le modulo 5 en fonction du nombre actuel
    if ((Modulo3 == 0) && (Modulo5 == 0)) // Verifie si le nmodulo 3 et 5 du nombre = 0
    {
        Console.WriteLine(FizzBuzz); //si la condition se verifie ecrit FizzBuzz
    }
    else if (Modulo3 == 0) // sinon verifie si le modulo 3 = 0
    {
        Console.WriteLine(Fizz); //si la condition se verifie ecrit Fizz
    }
    else if (Modulo5 == 0)// sinon verifie si le modulo 5 = 0 
    {
        Console.WriteLine(Buzz); //si la condition se verifie ecrit Buzz
    }
    else if (!(Modulo3 == 0) && !(Modulo5 == 0)) // sinon verifie si le modulo 3 != 0 et le modulo 5 != 0
    {
        Console.WriteLine(Nombre); //si la condition se verifie ecrit le nombre 
    }
    Nombre = Nombre + 1;
}
Console.ReadLine();