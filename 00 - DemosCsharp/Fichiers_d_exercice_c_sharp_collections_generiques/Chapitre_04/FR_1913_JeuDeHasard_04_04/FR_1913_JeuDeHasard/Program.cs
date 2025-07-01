using System;
using System.Collections.Generic;

namespace FR_1913_JeuDeHasard
{
    class Program
    {
        static void Main(string[] args)
        {
            var moi = new Joueur();

            Chifoumi[] choixFrance = { Chifoumi.Pierre, Chifoumi.Papier, Chifoumi.Ciseaux };
            var monTirage = TirerAuSort(choixFrance);
            var sonTirage = TirerAuSort(choixFrance);
            var resultat = moi.Jouer(monTirage, sonTirage);

            Console.WriteLine($"Moi : { monTirage } ({ resultat }), Lui: { sonTirage }");


            var jeu32Cartes = new Pioche<CarteAJouer>(CreerJeuDeCartes(debut: 7));

            var maCarte = jeu32Cartes.Piocher();
            var saCarte = jeu32Cartes.Piocher();
            var bataille = moi.Jouer(maCarte, saCarte);

            Console.WriteLine($"Moi : { maCarte } ({ bataille }), Lui: { saCarte }");
            while (!jeu32Cartes.EstVide)
            {
                Console.WriteLine(jeu32Cartes.Piocher());
            }
            CarteAJouer apresLaDerniere = jeu32Cartes.EssayerDePiocher();

            Console.WriteLine(apresLaDerniere?.ToString() ?? "(null)");
        }

        static T TirerAuSort<T>(T[] choix)
        {
            int indice = new Random().Next(choix.Length);

            return choix[indice];
        }
        
        static T[] ValeursEnum<T>() => (T[])Enum.GetValues(typeof(T));

        static IList<CarteAJouer> CreerJeuDeCartes(int debut)
        {
            var lesCouleurs = ValeursEnum<Couleur>();
            var lesFigures  = ValeursEnum<Figure>();
            var jeu = new List<CarteAJouer>();
            
            foreach (var couleur in lesCouleurs)
            {
                for (int i = debut; i <= 10; i++)
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
