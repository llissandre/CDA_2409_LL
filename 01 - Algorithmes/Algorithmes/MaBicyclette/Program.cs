// See https://aka.ms/new-console-template for more information


string beauTemps;
string bicycletteEnBonEtatDeFonctionnement;
string reparationImmediateDeLaBicyclette;
string premierTomeGotDansLaBibliothequeDuSalon;
string premierTomeGotALaBibliothequeMunicipale;


Console.WriteLine("Fait-il beau temps ? Entrez O ou N.");


do
{
    beauTemps = Console.ReadLine();
    beauTemps = beauTemps.ToLower();
}
while (beauTemps != "o" && beauTemps != "n");

if (beauTemps == "o")
{
    Console.WriteLine($"{Environment.NewLine}Vous pouvez aller faire une balade en bicyclette!");
    Console.WriteLine($"{Environment.NewLine}La bicyclette est-elle en bon état ? Entrez O ou N.");

    do
    {
        bicycletteEnBonEtatDeFonctionnement = Console.ReadLine();
        bicycletteEnBonEtatDeFonctionnement = bicycletteEnBonEtatDeFonctionnement.ToLower();

        if (bicycletteEnBonEtatDeFonctionnement == "o")
        {
            Console.WriteLine($"{Environment.NewLine}Bonne balade en bicyclette !!!");
        }
        else if ((bicycletteEnBonEtatDeFonctionnement == "n"))
        {
            Console.WriteLine($"{Environment.NewLine}Les réparations sont-elles possibles immédiatement ? Entrez O ou N.");

            do
            {
                reparationImmediateDeLaBicyclette = Console.ReadLine();
                reparationImmediateDeLaBicyclette = reparationImmediateDeLaBicyclette.ToLower();

                if (reparationImmediateDeLaBicyclette == "o")
                {
                    Console.WriteLine($"{Environment.NewLine}Bonne balade en bicyclette !!!");
                }
                else if (reparationImmediateDeLaBicyclette == "n")
                {
                    Console.WriteLine($"{Environment.NewLine}Vous allez à pieds jusqu’à l’étang pour cueillir les joncs. !!!");
                }
            }
            while (reparationImmediateDeLaBicyclette != "o" && reparationImmediateDeLaBicyclette != "n");
        }
    }
    while (bicycletteEnBonEtatDeFonctionnement != "o" && bicycletteEnBonEtatDeFonctionnement != "n");
}

else
{
    Console.WriteLine($"{Environment.NewLine}Vous allez consacrer votre journée à la lecture.{Environment.NewLine}Vous pourrez relire le 1er tome de Game of Thrones que vous pensez posséder.");
    Console.WriteLine($"{Environment.NewLine}Le 1er tome de Game of Thrones est-il dans la bibliothèque de votre salon ? Entrez O ou N");

    do
    {
        premierTomeGotDansLaBibliothequeDuSalon = Console.ReadLine();
        premierTomeGotDansLaBibliothequeDuSalon = premierTomeGotDansLaBibliothequeDuSalon.ToLower();

        if (premierTomeGotDansLaBibliothequeDuSalon == "o")
        {
            Console.WriteLine($"{Environment.NewLine}Bonne lecture, vous vous installez confortablement dans un fauteuil et vous vous plongez dans la lecture.");
        }
        else if (premierTomeGotDansLaBibliothequeDuSalon == "n")
        {
            Console.WriteLine($"{Environment.NewLine}Le livre n'est pas dans votre bibliothèque, vous allez devoir emprunter le 1er tome de Game of Thrones à la bibliothèque municipale.");

            Console.WriteLine($"{Environment.NewLine}Le 1er tome de Game of Thrones est-il à la bibliothèque municipale ? Entrez O ou N");

            do
            {
                premierTomeGotALaBibliothequeMunicipale = Console.ReadLine();
                premierTomeGotALaBibliothequeMunicipale = premierTomeGotALaBibliothequeMunicipale.ToLower();

                if (premierTomeGotALaBibliothequeMunicipale == "o")
                {
                    Console.WriteLine($"{Environment.NewLine}Vous rentrez directement chez vous, vous vous installez confortablement dans un fauteuil et vous vous plongez dans la lecture.");
                }
                else if (premierTomeGotALaBibliothequeMunicipale == "n")
                {
                    Console.WriteLine($"{Environment.NewLine}Vous empruntez un roman policier, vous rentrez directement chez vous, vous vous installez confortablement dans un fauteuil et vous vous plongez dans la lecture.");
                }
            }
            while (premierTomeGotALaBibliothequeMunicipale != "o" && premierTomeGotALaBibliothequeMunicipale != "n");
        }

    }
    while (premierTomeGotDansLaBibliothequeDuSalon != "o" && premierTomeGotDansLaBibliothequeDuSalon != "n");
}

Console.ReadLine();