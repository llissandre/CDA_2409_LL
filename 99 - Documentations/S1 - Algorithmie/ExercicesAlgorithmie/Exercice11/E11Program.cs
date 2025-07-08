//affiche sur la console : "Rentrer un caractère : "
Console.Write("Rentrez un caractère : ");

//récupère le caractère donné par l'utilisateur et
//le range dans la variable Car
String Car = Console.ReadLine();

//comparaison
//si la chaine de caractères est "o" ou "O"
if (Car == "o" || Car == "O")
{
    Console.WriteLine("affirmatif ");
}
//sinon si le caractère est "n" ou "N"
else if (Car == "n" || Car == "N")
{
    Console.WriteLine("négatif");
}
//sinon
else
{
    Console.WriteLine("???");
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();