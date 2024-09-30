// See https://aka.ms/new-console-template for more information

int entrerUnAge(string Phrase)
{
    Console.WriteLine(Phrase);

    int age;
    bool vrai;

    do
    {
        Console.Write("Entrez votre âge : ");
        string saisie = Console.ReadLine();

        vrai = int.TryParse(saisie, out age);
    }
    while (!vrai);

    return age;
}

int age = entrerUnAge("");

if (age < 0)
{
    Console.WriteLine($"{Environment.NewLine}Vous n'êtes pas encore né !");
}
else if (age > 18)
{
    Console.WriteLine($"{Environment.NewLine}Vous êtes majeur !");
}
else
{
    Console.WriteLine($"{Environment.NewLine}Vous êtes mineur !");
}

Console.ReadLine();
