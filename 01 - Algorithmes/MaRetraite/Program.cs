// See https://aka.ms/new-console-template for more information

int EntrerUnAge(string Phrase)
{
    Console.WriteLine(Phrase);

    int age;
    bool vrai;

    do
    {
        Console.Write("Entrez votre âge : ");
        string saisie = Console.ReadLine();

        vrai = int.TryParse(saisie, out age);
        if (!vrai)
        {
            Console.WriteLine("La valeur fournie n'est pas un âge valide.");
        }
    }
    while (!vrai);

    return age;
}

int dureeRetraite;
int age;

age = EntrerUnAge("");

if (age > 60)
{
    dureeRetraite = age - 60;
    Console.WriteLine($"{Environment.NewLine}Vous êtes à la retraite depuis {dureeRetraite} années.");
}
else if (age == 60)
{
    Console.WriteLine($"{Environment.NewLine}C'est le moment de prendre votre retraite.");
}
if (age < 60)
{
    dureeRetraite = 60-age;
    Console.WriteLine($"{Environment.NewLine}Il vous reste {dureeRetraite} années avant la retraite.");
}

Console.ReadLine();