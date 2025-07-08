// See https://aka.ms/new-console-template for more information
using TP_Livre;


List<Livre> livres = new List<Livre>();
do 
{
    livres.Add(new Livre());


    //Liste des livres
    for(int i = 0; i < livres.Count; i++)
    {
        livres[i].Afficher();
    }

    
}while(Console.ReadKey().Key != ConsoleKey.Escape);