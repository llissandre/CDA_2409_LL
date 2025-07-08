//affiche sur la console : "Quel est votre genre ?"
Console.Write("Quel est votre genre ? ");

//récupère le genre donné par l'utilisateur et le range dans la 
//variable Genre
String Genre = Console.ReadLine();

//affiche sur la console : "Quel âge avez-vous ?"
Console.Write("Quel âge avez-vous ? ");

//récupère l'âge donné par l'utilisateur et le range dans la 
//variable Age
int Age = int.Parse(Console.ReadLine());

if (Genre == "H" || Genre == "h")
{
    if (Age >= 20)
    {
        Console.WriteLine("Vous êtes imposable");
    }
    else
    {
        Console.WriteLine("Vous n'êtes pas imposable");
    }
}
else
{
    if (Age >= 18 && Age <= 35)
    {
        Console.WriteLine("Vous êtes imposable");
    }
    else
    {
        Console.WriteLine("Vous n'êtes pas imposable");
    }
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();