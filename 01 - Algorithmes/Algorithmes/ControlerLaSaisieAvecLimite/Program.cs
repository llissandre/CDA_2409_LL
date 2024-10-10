// See https://aka.ms/new-console-template for more information

string motDePasse;
string saisie;
int nombreDEssais;

motDePasse = "formation";
nombreDEssais = 0;

do
{
    Console.WriteLine("Saisissez votre mot de passe :");
    saisie = Console.ReadLine();

    nombreDEssais++;
}
while (nombreDEssais < 3 && !saisie.Equals(motDePasse));

if (saisie.Equals(motDePasse))
{
    Console.WriteLine("Vous êtes connecté");
}
else
{
    Console.WriteLine("Votre compte est bloqué");
}