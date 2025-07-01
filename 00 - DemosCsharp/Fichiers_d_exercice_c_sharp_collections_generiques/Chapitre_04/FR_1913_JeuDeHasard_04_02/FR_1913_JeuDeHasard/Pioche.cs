using System;
using System.Collections.Generic;

namespace FR_1913_JeuDeHasard
{
    public class Pioche
    {
        private Random hasard = new Random();
        private IList<Carte> contenu;

        public Pioche(IEnumerable<Carte> init)
        {
            contenu = new List<Carte>(init);
        }
        public bool EstVide
        {
            get => contenu.Count == 0;
        }
        public Carte Piocher()
        {
            int indice = hasard.Next(contenu.Count);
            Carte retour = contenu[indice];

            contenu.RemoveAt(indice);
            return retour;
        }        
    }
}
