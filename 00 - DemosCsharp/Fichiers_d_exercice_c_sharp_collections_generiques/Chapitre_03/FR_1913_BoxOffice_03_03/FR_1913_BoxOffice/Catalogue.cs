using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace FR_1913_BoxOffice
{
    public class Catalogue : ICollection<Film>
    {
        private Dictionary<string, Film> films = new Dictionary<string, Film>();

        public bool Ajouter(string titre, DateTime dateDeSortie)
        {
            if (!films.ContainsKey(titre))
            {
                films[titre] = new Film(titre, dateDeSortie);
                return true;
            }
            return false;
        }

        public IEnumerable<Film> Tout
            => films.Values;

        public IEnumerable<Film> Avant(DateTime max)
            => films
                .Where(kv => kv.Value.DateDeSortie < max)
                .Select(kv => kv.Value);

        #region Implémentation de ICollection<Film>
        public void Add(Film f)                         => Ajouter(f.Titre, f.DateDeSortie);
        public void Clear()                             => films.Clear();
        public bool Contains(Film f)                    => films.ContainsKey(f.Titre);
        public void CopyTo(Film[] tab, int indiceTab)   => films.Values.CopyTo(tab, indiceTab);
        public bool Remove(Film f)                      => films.Remove(f.Titre);
        public IEnumerator<Film> GetEnumerator()        => films.Values.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()         => films.Values.GetEnumerator();
        public int Count                                => films.Count;
        public bool IsReadOnly                          => false;
        #endregion
    }
}
