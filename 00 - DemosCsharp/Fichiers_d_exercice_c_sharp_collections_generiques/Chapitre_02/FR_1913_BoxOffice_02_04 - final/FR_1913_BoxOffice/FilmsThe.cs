using System;

namespace FR_1913_BoxOffice
{
    public class FilmThe : Film
    {
        public FilmThe(string titre, DateTime dateDeSortie) :
            base(NettoyerTitre(titre), dateDeSortie)
        {

        }
        public static bool EnEstUn(string titre)
        {
            return titre.StartsWith("\"")
                && titre.EndsWith(", The\"");
        }
        private static string NettoyerTitre(string titre)
        {
            return "The " + titre.Substring(1, titre.Length - "\", The\"".Length);
        }
    }
}
