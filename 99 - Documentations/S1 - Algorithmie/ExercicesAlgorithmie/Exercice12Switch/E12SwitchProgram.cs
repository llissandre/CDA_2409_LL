int Age = 1;

//affiche sur la console : "Entrer un premier nombre entier:"
Console.Write("Entrez l'âge de l'enfant : ");
//récupère le premier entier donné par l'utilisateur et
//parse la chaine de caractères et le range dans la variable A
int A = int.Parse(Console.ReadLine());

//conditions
if (A >= 12)
{
    Age++;
    Age++;
}

if (A == 6 || A == 7)
{
    Age++;
}
if (A == 8 || A == 9)
{
    Age--;
}

//case pour indiquer la catégorie de l'enfant
switch (Age)
{
    case 0:
        Console.WriteLine("Pupille");
        break;

    case 2:
        Console.WriteLine("Poussin");
        break;

    case 3:
        Console.WriteLine("Cadet");
        break;

    default:
        Console.WriteLine("Minime");
        break;
}
// permet de laisser la fenêtre de la console ouverte
Console.ReadLine();
            }