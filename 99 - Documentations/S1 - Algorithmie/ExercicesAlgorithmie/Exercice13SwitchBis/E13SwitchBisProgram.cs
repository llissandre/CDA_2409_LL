// See https://aka.ms/new-console-template for more information


while (true)
{
    int Age = 1;

    //affiche sur la console : "Quel âge avez-vous ?"
    Console.Write("Quel âge avez-vous ? ");
    //récupère l'âge donné par l'utilisateur et le range dans la 
    //variable Age
    int A = int.Parse(Console.ReadLine());

    //affiche sur la console : "Quel est votre genre ?"
    Console.Write("Quel est votre genre ? ");
    //récupère le genre donné par l'utilisateur et le range dans la 
    //variable Genre
    String Genre = Console.ReadLine();

    bool Imposable = ((Genre == "H" || Genre == "h" && A >= 20) || (Genre == "F" || Genre == "f" && A >= 18 && A <= 35));

    if (Imposable)
    {
        Age++;
    }

    switch (Age)
    {
        case 2:
            Console.WriteLine("Vous êtes imposable");
            break;

        default:
            Console.WriteLine("Vous n'êtes pas imposable");
            break;
    }
    // permet de laisser la fenêtre de la console ouverte
    Console.ReadLine();
}