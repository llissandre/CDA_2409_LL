// See https://aka.ms/new-console-template for more information


string entrerDuTexte(string phrase)
{
    Console.WriteLine("Taper du texte : ");
    return Console.ReadLine();
}

string text;
int count;
int countLetter;
string[] monTableau;

text = entrerDuTexte("");
count = 0;
countLetter = 0;

monTableau = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];


foreach (char c in text)
{
    count++;
}

Console.WriteLine($"Nombre de caractères du texte : {count}");

if (count < 10)
{
    Console.WriteLine("Le texte doit contenir au moins 120 caractères !");
}
else
{
    for (int i = 0; i < monTableau.Length; i++)
    {
        for (int j = 0; j < text.Length; j++)
        {
            if (monTableau[i].CompareTo(text[j])
            {

            }
            Console.WriteLine(text[0]);
            Console.WriteLine(monTableau[0]);
        }
    }
}