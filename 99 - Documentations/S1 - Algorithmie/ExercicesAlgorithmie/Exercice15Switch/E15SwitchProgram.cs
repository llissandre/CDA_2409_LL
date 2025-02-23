int Point = 0;

Console.Write("Quel est votre âge ? : ");
int Ageconducteur = int.Parse(Console.ReadLine());
Console.Write("Depuis combien de temps avez-vous le permis ? : ");
int Anciennetepermis = int.Parse(Console.ReadLine());
Console.Write("Combien avez-vous eu d'accidents ? : ");
int Nbaccidents = int.Parse(Console.ReadLine());
Console.Write("Depuis combien de temps êtes-vous assuré dans notre compagnie ? : ");
int Fidelite = int.Parse(Console.ReadLine());

if (Ageconducteur < 25)
{
    Point++;
}

if (Anciennetepermis < 2)
{
    Point++;
}

Point += Nbaccidents;

if (Fidelite >= 5 && Point < 3)
{
    Point--;
}

switch (Point)
{
    case -1:
        Console.WriteLine("Vous bénéficiez du tarif bleu");
        break;

    case 0:
        Console.WriteLine("Vous bénéficiez du tarif vert");
        break;

    case 1:
        Console.WriteLine("Vous bénéficiez du tarif orange");
        break;

    case 2:
        Console.WriteLine("Vous bénéficiez du tarif rouge");
        break;

    default:
        Console.WriteLine("Votre adhésion est refusée");
        break;
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();