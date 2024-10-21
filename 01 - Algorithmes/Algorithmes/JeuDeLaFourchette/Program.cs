// See https://aka.ms/new-console-template for more information

int demanderUnNombreEntiers(string Phrase)
{
    int nb;
    string saisie;
    bool vrai;

    Console.WriteLine(Phrase);

    do
    {
        Console.WriteLine("Entrer un nombre");
        saisie = Console.ReadLine();
        vrai = int.TryParse(saisie, out nb);
    }
    while (!vrai);

    return nb;
}

Console.OutputEncoding = System.Text.Encoding.UTF8;

Random rand;
int compteur;
int nombreEntre;
int nombreChoisi;
int nombreInferieur;
int nombreSuperieur;

rand = new Random();
compteur = 0;
nombreChoisi = rand.Next(100);
nombreEntre = demanderUnNombreEntiers("");
nombreInferieur = 0;
nombreSuperieur = 100;
compteur++;

nombreChoisi++;

if (nombreEntre == nombreChoisi)
{
    Console.WriteLine($"Bravo vous avez trouvé le nombre !");
}
else if (nombreEntre < nombreChoisi)
{
    Console.WriteLine($"La fourchette pour trouver le nombre choisi est entre {nombreEntre} et 100");
    nombreInferieur = nombreEntre;
}
else if (nombreEntre > nombreChoisi)
{
    Console.WriteLine($"La fourchette pour trouver le nombre choisi est compris entre 0 et {nombreEntre}");
    nombreSuperieur = nombreEntre;
}


do
{
    nombreEntre = demanderUnNombreEntiers("");
    compteur++;

    if (nombreEntre == nombreChoisi)
    {
        Console.WriteLine($"Bravo vous avez trouvé en {compteur} essais");
    }
    else if (nombreEntre < nombreChoisi)
    {
        if (nombreEntre > nombreInferieur)
        {
            Console.WriteLine($"La nouvelle fourchette pour trouver le nombre choisi est entre {nombreEntre} et {nombreSuperieur}");
            nombreInferieur = nombreEntre;
        }
        else
        {
            Console.WriteLine($"La nouvelle fourchette pour trouver le nombre choisi est entre {nombreInferieur} et {nombreSuperieur}");
        }
    }
    else if (nombreEntre > nombreInferieur)
    {
        if (nombreEntre < nombreSuperieur)
        {
            Console.WriteLine($"La nouvelle fourchette pour trouver le nombre choisi est compris entre {nombreInferieur} et {nombreEntre}");
            nombreSuperieur = nombreEntre;
        }
        else
        {
            Console.WriteLine($"La nouvelle fourchette pour trouver le nombre choisi est compris entre {nombreInferieur} et {nombreSuperieur}");
        }
    }
}
while (nombreEntre != nombreChoisi);

Console.WriteLine(nombreChoisi);