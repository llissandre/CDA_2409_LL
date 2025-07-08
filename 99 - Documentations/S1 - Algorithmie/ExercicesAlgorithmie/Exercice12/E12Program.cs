//affiche sur la console : "Rentrer un caractère :"
Console.Write("Rentrez l'âge de l'enfant : ");

//récupère l'âge donné par l'utilisateur et le range dans la 
//variable Age
int Age = int.Parse(Console.ReadLine());

//comparaison
//si l'enfant a 6 ou 7 ans
if (Age == 6 || Age == 7)
{
    Console.WriteLine("Poussin");
}
//sinon si l'enfant a 8 ou 9 ans
else if (Age == 8 || Age == 9)
{
    Console.WriteLine("Pupille");
}
//sinon si l'enfant a 10 ou 11 ans
else if (Age == 10 || Age == 11)
{
    Console.WriteLine("Minime");
}
//sinon l'enfant a plus de 12 ans
else if (Age >= 12)
{
    Console.WriteLine("Cadet");
}

// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();