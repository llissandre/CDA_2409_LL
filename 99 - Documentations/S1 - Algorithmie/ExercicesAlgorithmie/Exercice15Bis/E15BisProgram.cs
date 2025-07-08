Console.Write("Quel est votre âge ? : ");
int Ageconducteur = int.Parse(Console.ReadLine());

Console.Write("Depuis combien de temps avez-vous le permis ? : ");
int Anciennetepermis = int.Parse(Console.ReadLine());

Console.Write("Combien avez-vous eu d'accidents ? : ");
int Nbaccidents = int.Parse(Console.ReadLine());

Console.Write("Depuis combien de temps êtes-vous assuré dans notre compagnie ? : ");
int Fidelite = int.Parse(Console.ReadLine());

int Point = 0;

if (Ageconducteur < 25)
{
    Point++;
}

if (Anciennetepermis < 2)
{
    Point++;
}

Point += Nbaccidents;

if (Fidelite > 5 && Point < 3)
{
    Point--;
}

if (Point == -1)
{
    Console.WriteLine("BLEU");
}

if (Point == 0)
{
    Console.WriteLine("VERT");
}

else if (Point == 1)
{
    Console.WriteLine("ORANGE");
}

else if (Point == 2)
{
    Console.WriteLine("ROUGE");
}

else
{
    Console.WriteLine("REFUS");
}