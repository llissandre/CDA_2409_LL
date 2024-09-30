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
nombreSuperieur = 0;
compteur++;

nombreChoisi++;

if (nombreEntre == nombreChoisi)
{
    Console.WriteLine($"Bravo vous avez trouvé en X essais");
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
    compteur++;
}
while (nombreEntre != nombreChoisi);

Console.WriteLine(nombreChoisi);




