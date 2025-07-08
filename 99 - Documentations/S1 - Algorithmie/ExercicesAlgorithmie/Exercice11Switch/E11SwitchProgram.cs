string Car = "A";

//affiche sur la console : "Entrer un caractère : "
Console.Write("Entrer un caractère : ");
//récupère le premier entier donné par l'utilisateur et le
//range dans la variable E1
string C = Console.ReadLine();

//conditions
if (C == "o" || C == "O")
{
    Car = "O";
}

if (C == "n" || C == "N")
{
    Car = "N";
}

//case pour savoir si on renvoit affirmatif, négatif ou ???

switch (Car)
{
    case "O":
        Console.WriteLine("affirmatif");
        break;

    case "N":
        Console.WriteLine("négatif");
        break;

    default:
        Console.WriteLine("???");
        break;
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();