using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace FR_1913_BoxOffice
{
    public class Catalogue : ICollection<Film>, IDictionary<string, Film>
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

        #region Implémentation de IDictionary<string, Film>
        public void Add(string key, Film value)             => Ajouter(value.Titre, value.DateDeSortie);
        public bool ContainsKey(string key)                 => films.ContainsKey(key);
        public bool Remove(string key)                      => films.Remove(key);
        public bool TryGetValue(string key, out Film value) => films.TryGetValue(key, out value);
        public ICollection<string> Keys                     => films.Keys;
        public ICollection<Film>   Values                   => films.Values;
        public Film                this[string key]         { get => films[key]; set => films[key] = value; }

        #region Implémentation de IList<KeyValuePair<string, Film>> dont dérive IDictionary
        private IList<KeyValuePair<string, Film>> ListePaires { get => films as IList<KeyValuePair<string, Film>>; }

        public void Add     (KeyValuePair<string, Film> item)                       => ListePaires.Add(item);
        public bool Contains(KeyValuePair<string, Film> item)                       => ListePaires.Contains(item);
        public void CopyTo  (KeyValuePair<string, Film>[] array, int arrayIndex)    => ListePaires.CopyTo(array, arrayIndex);
        public bool Remove  (KeyValuePair<string, Film> item)                       => ListePaires.Remove(item);
        IEnumerator<KeyValuePair<string, Film>> IEnumerable<KeyValuePair<string, Film>>.GetEnumerator() 
                                                                                    => ListePaires.GetEnumerator();
        #endregion
        #endregion
    }
}
