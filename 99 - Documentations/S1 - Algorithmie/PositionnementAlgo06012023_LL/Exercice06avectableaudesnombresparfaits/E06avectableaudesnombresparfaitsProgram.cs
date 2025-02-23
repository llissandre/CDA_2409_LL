int[] TableauDesNombresParfaitsInferieursA10000 = new int[10];


bool Parfait(int Nombre)
{
    int CompteurDiviseurs = 0;
    for (int Compteur = 1; Compteur < Nombre; Compteur++)
    {
        if (Nombre % Compteur == 0)
        {
            CompteurDiviseurs += Compteur;
        }
    }
    if (CompteurDiviseurs == Nombre && Nombre > 1)
    {
        return true;
    }
    return false;
}

int Compteur = 0;
int Nombre = 0;
Console.Write("La liste des nombres parfaits inférieurs à 10000 sont : [");
do
{
    if (Parfait(Nombre) == true)
    {
        TableauDesNombresParfaitsInferieursA10000[Compteur] = Nombre;
        Console.Write(TableauDesNombresParfaitsInferieursA10000[Compteur]);
        if (Compteur < 3)
        {
            Console.Write(", ");
        }
        Compteur++;
    }
    Nombre++;

} while (Nombre < 10000);
Console.WriteLine("]");