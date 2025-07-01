using System;
using System.Collections.Generic;

namespace FR_1913_JeuDeHasard
{
    class Program
    {
        static void Main(string[] args)
        {
            Chifoumi[] choixFrance = { Chifoumi.Pierre, Chifoumi.Papier, Chifoumi.Ciseaux };
            
            Console.WriteLine(TirerAuSort(choixFrance));

            var jeu32Cartes = new Pioche<CarteAJouer>(CreerJeuDeCartes(debut: 7));

            while(!jeu32Cartes.EstVide)
            {
                Console.WriteLine(jeu32Cartes.Piocher());
            }
        }

        static T TirerAuSort<T>(T [] choix)
        {
            int indice = new Random().Next(choix.Length);

            return choix[indice];
        }

        static T[] ValeursEnum<T>()
            => (T[])Enum.GetValues(typeof(T));
        
        static IList<CarteAJouer> CreerJeuDeCartes(int debut)
        {
            var lesCouleurs = ValeursEnum<Couleur>();
            var lesFigures  = ValeursEnum<Figure >();
            var jeu = new List<CarteAJouer>();
            
            foreach (var couleur in lesCouleurs)
            {
                for (int i = 7; i <= 10; i++)
                {
                    jeu.Add(new CarteAJouerNombre(i, couleur));
                }
                foreach (var figure in lesFigures)
                {
                    jeu.Add(new CarteAJouerFigure(figure, couleur));
                }
            };
            return jeu;
        }
    }
}
