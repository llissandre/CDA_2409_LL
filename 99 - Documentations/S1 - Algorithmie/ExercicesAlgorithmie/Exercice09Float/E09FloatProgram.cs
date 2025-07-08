//affiche sur la console : "Saisissez une note
Console.Write("Entrez une note : ");
//récupère le premier entier donné par l'utilisateur et
//le range dans la variable N
//parse la chaine de caractère "N" en un entier "Note"
float Note = float.Parse(Console.ReadLine());

//comparaison pour savoir si l'élève est admis
if (Note >= 10)
{
    Console.WriteLine("Admis");
}

//comparaison pour savoir si l'élève est en rattrapage
else if (Note > 8)
{
    Console.WriteLine("Rattrapage");
}

//les deux comparaison précédente étant fausses
//écrire échec
else
{
    Console.WriteLine("Echec");
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();