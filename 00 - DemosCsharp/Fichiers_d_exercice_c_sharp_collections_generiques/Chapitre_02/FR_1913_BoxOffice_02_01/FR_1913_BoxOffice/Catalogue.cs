using System;

namespace FR_1913_BoxOffice
{
    public class Catalogue
    {
        private const int MaxFilms = 10000;
        private int nbFilms = 0;
        private readonly Film[] films = new Film[MaxFilms];

        public bool Ajouter(string titre, DateTime dateDeSortie)
        {
            var dernierTitre = nbFilms == 0
                ? String.Empty
                : films[nbFilms - 1].Titre;

            if (titre != dernierTitre)
            {
                films[nbFilms++] = new Film(titre, dateDeSortie);
                return true;
            }
            return false;
        }
        public Film[] Tout
            => films;
    }
}
