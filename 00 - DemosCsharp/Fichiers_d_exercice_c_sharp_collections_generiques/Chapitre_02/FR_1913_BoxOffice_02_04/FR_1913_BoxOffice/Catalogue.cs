using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace FR_1913_BoxOffice
{
    public class Catalogue : ICollection<Film>
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
        public IEnumerable<Film> Tout
            => films;

        public IEnumerable<Film> Avant(DateTime max)
            => films.Where(f => f.DateDeSortie < max);

        #region Implémentation de ICollection<Film>
        public void Add(Film f)                         => Ajouter(f.Titre, f.DateDeSortie);
        public void Clear()                             => films.Clear();
        public bool Contains(Film f)                    => films.Contains(f);
        public void CopyTo(Film[] tab, int indiceTab)   => films.CopyTo(tab, indiceTab);
        public bool Remove(Film f)                      => films.Remove(f);
        public IEnumerator<Film> GetEnumerator()        => films.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()         => films.GetEnumerator();
        public int Count                                => films.Count;
        public bool IsReadOnly                          => false;
        #endregion
    }
}
