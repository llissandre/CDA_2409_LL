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
            var comparateur = new TComp();
            var comparaison = comparateur.Compare(moi, lui);

            return comparaison < 0 ? Resultat.Defaite
                 : comparaison > 0 ? Resultat.Victoire
                 : Resultat.Nul;
        }        
    }
}
