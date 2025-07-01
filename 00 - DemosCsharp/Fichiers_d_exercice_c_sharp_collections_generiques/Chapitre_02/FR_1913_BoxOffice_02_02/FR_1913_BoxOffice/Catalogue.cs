using System;
using System.Collections.Generic;

namespace FR_1913_BoxOffice
{
    public class Catalogue
    {
        private readonly List<Film> films = new List<Film>();

        public bool Ajouter(string titre, DateTime dateDeSortie)
        {
            var dernierTitre = films.Count == 0
                ? String.Empty
                : films[films.Count - 1].Titre;

            if (titre != dernierTitre)
            {
                films.Add(new Film(titre, dateDeSortie));
                return true;
            }
            return false;
        }
        public List<Film> Tout
            => films;
    }
}
