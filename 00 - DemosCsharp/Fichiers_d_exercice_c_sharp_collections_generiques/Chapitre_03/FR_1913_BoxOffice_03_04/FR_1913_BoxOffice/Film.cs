using System;

namespace FR_1913_BoxOffice
{
    public class Film
    {
        public Film(string titre, DateTime dateDeSortie)
        {
            Titre = titre;
            DateDeSortie = dateDeSortie;
        }
        public string   Titre           { get; private set; }
        public DateTime DateDeSortie    { get; private set; }

        public override bool Equals(object obj) => obj is Film && Titre == ((Film)obj).Titre;

        public override int GetHashCode()
        {
            return Titre.GetHashCode();
        }
    }
}
