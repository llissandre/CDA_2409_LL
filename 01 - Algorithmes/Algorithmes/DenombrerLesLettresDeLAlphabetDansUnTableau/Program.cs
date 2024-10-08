// See https://aka.ms/new-console-template for more information


using System.ComponentModel;

string entrerDuTexte(string phrase)
{
    Console.WriteLine("Taper du texte : ");
    phrase = Console.ReadLine();
    phrase = phrase.ToLower();
    return phrase;
}

string text;
int count;
int countLetter;
char[] monTableau;

text = entrerDuTexte("");
count = 0;
countLetter = 0;

monTableau = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];


foreach (char c in text)
{
    count++;
}

Console.WriteLine($"Nombre de caractères du texte : {count}{Environment.NewLine}");

if (count < 10)
{
    Console.WriteLine($"Le texte doit contenir au moins 120 caractères !{Environment.NewLine}");
}
else
{
    for (int i = 0; i < monTableau.Length; i++)
    {
        foreach (char c in text)
        {
            //if (c == monTableau[i])
            if (c.Equals(monTableau[i]))
            {
                countLetter++;
            }
        }
        Console.WriteLine($"La lettre {monTableau[i]} est présente {countLetter} fois !");
        countLetter = 0;
    }
}