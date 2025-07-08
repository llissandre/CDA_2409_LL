using System;
using System.Collections.Generic;

namespace FR_1913_JeuDeHasard
{
    public class Pioche<T>
    {
        private Random hasard = new Random();
        private IList<T> contenu;

        public Pioche(IEnumerable<T> init)
        {
            contenu = new List<T>(init);
        }
        public bool EstVide
        {
            get => contenu.Count == 0;
        }
        public T Piocher()
        {
            int indice = hasard.Next(contenu.Count);
            T retour = contenu[indice];

            contenu.RemoveAt(indice);
            return retour;
        }        
    }
}
