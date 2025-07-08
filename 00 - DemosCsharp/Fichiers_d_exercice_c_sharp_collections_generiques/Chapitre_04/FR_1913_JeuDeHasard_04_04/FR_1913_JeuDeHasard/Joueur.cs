using System.Collections.Generic;

namespace FR_1913_JeuDeHasard
{
    public enum Resultat
    {
        Defaite =-1,
        Nul     = 0,
        Victoire= 1
    }
    public class Joueur
    {
        public Resultat Jouer<T, TComp>(T moi, T lui) where TComp : IComparer<T>, new()
        {
            var comp = new TComp();
            var diff = comp.Compare(moi, lui);

            return diff < 0 ? Resultat.Defaite
                 : diff > 0 ? Resultat.Victoire
                 : Resultat.Nul;
        }
        public Resultat Jouer(Chifoumi moi, Chifoumi lui)
        {
            var combinaisons = new Dictionary<(Chifoumi moi, Chifoumi lui), Resultat>()
            {
                { (Chifoumi.Ciseaux, Chifoumi.Pierre ), Resultat.Defaite  },
                { (Chifoumi.Ciseaux, Chifoumi.Papier ), Resultat.Victoire },
                { (Chifoumi.Ciseaux, Chifoumi.Ciseaux), Resultat.Nul      },

                { (Chifoumi.Papier , Chifoumi.Pierre ), Resultat.Victoire },
                { (Chifoumi.Papier , Chifoumi.Papier ), Resultat.Nul      },
                { (Chifoumi.Papier , Chifoumi.Ciseaux), Resultat.Defaite  },

                { (Chifoumi.Pierre , Chifoumi.Pierre ), Resultat.Nul      },
                { (Chifoumi.Pierre , Chifoumi.Papier ), Resultat.Defaite  },
                { (Chifoumi.Pierre , Chifoumi.Ciseaux), Resultat.Victoire }
            };
            return combinaisons[(moi, lui)];
        }
        public Resultat Jouer(CarteAJouer moi, CarteAJouer lui)
        {
            bool figureVsNombre = !moi.GetType().Equals(lui.GetType());

            if(figureVsNombre)
            {
                return moi is CarteAJouerFigure
                    ? Resultat.Victoire
                    : Resultat.Defaite;
            }
            else
            {
                int comparaison = moi is CarteAJouerFigure
                    ? ((CarteAJouerFigure)moi).CompareTo((CarteAJouerFigure)lui)
                    : ((CarteAJouerNombre)moi).CompareTo((CarteAJouerNombre)lui);

                return comparaison < 0 ? Resultat.Defaite
                     : comparaison > 0 ? Resultat.Victoire
                     : Resultat.Nul;
            }
        }
    }
}
