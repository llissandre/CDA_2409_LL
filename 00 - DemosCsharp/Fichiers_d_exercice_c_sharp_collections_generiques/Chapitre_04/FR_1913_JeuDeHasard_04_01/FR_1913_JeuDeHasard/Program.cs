using System;
using System.Collections.Generic;
using System.Linq;

namespace FR_1913_JeuDeHasard
{
    class Program
    {
        static void Main(string[] args)
        {
            Chifoumi[] choixFrance = { Chifoumi.Pierre, Chifoumi.Papier, Chifoumi.Ciseaux };
            
            Console.WriteLine(TirerAuSortChifoumi(choixFrance));

            var jeu32Cartes = CreerJeuDeCartes(debut: 7);

            Console.WriteLine(TirerAuSortCarte(jeu32Cartes.ToArray()));
        }

        static Chifoumi TirerAuSortChifoumi(Chifoumi [] choix)
        {
            int indice = new Random().Next(choix.Length);

            return choix[indice];
        }

        static Carte TirerAuSortCarte(Carte[] choix)
        {
            int indice = new Random().Next(choix.Length);

            return choix[indice];
        }

        static IList<CarteAJouer> CreerJeuDeCartes(int debut)
        {
            var lesCouleurs = (Couleur[])Enum.GetValues(typeof(Couleur));
            var lesFigures  = (Figure [])Enum.GetValues(typeof(Figure ));
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
