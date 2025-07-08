//affiche sur la console : "Rentrer un caractère :"
Console.Write("Rentrez un caractère : ");

//récupère le caractère donné par l'utilisateur et
//le range dans la variable Car
Char Car = Console.ReadKey().KeyChar;

//comparaison
//si le caractère est 'o' ou 'O'
if (Car == 'o' || Car == 'O')
{
    Console.WriteLine("\naffirmatif ");
}
//sinon si le caractère est 'n' ou 'N'
else if (Car == 'n' || Car == 'N')
{
    Console.WriteLine("\nnégatif");
}
//sinon
else
{
    Console.WriteLine("\n???");
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();