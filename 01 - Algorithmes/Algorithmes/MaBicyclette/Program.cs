// See https://aka.ms/new-console-template for more information


string beauTemps;
string bicycletteEnBonEtatDeFonctionnement;
string reparationImmediateDeLaBicyclette;
string premierTomeGotDansLeSalon;
string premierTomeGotALaBibliotheque;


Console.WriteLine("Fait-il beau temps ? (O/N)");
try
{
beauTemps = Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("Il faut taper O ou N !"+e.Message);
    Environment.Exit(1);
}

beauTemps = Console.ReadLine();

if (beauTemps == "O" || beauTemps == "o")
{
    Console.WriteLine("Vous pouvez aller faire une balade en bicyclette.");
}
else if (beauTemps == "N" || beauTemps == "n")
{
    Console.WriteLine("Vous allez consacrer votre journée à la lecture.");
}

Console.ReadLine();