// See https://aka.ms/new-console-template for more information

string prenom;
int longueurPrenom;

do
{
    Console.WriteLine("Saisissez votre prénom, qui doit être composé d'au moins deux lettres :");
    prenom = Console.ReadLine();
    longueurPrenom = prenom.Length;
}
while (longueurPrenom < 2);

Console.WriteLine($"Bonjour {prenom}");