using System;
using System.Linq;
using System.Collections.Generic;

namespace FR_1913_BoxOffice
{
    public class StatsFilm
    {
        private List<StatHebdo> historique = new List<StatHebdo>();
                
        public StatsFilm(Film film)
        {
            Film = film;
        }
        public Film Film { get; private set; }

        public void AjouterStats(int noSemaine, long nbCinemas, DateTime date)
        {
            historique.Add(new StatHebdo(noSemaine, nbCinemas, date));
        }

        public long Total
        {
            get => (from stat in historique select stat.NbCinemas).Sum();
        }
        private class StatHebdo
        { 
            public StatHebdo(int noSemaine, long nbCinemas, DateTime date)
            {
                NoSemaine = noSemaine;
                NbCinemas = nbCinemas;
                Date = date;
            }
            public int NoSemaine { get; private set; }
            public long NbCinemas { get; private set; }
            public DateTime Date { get; private set; }
        }
    }
}
