using System;
using System.Linq;
using System.Collections.Generic;

// Avant (LIFO)                       Après
// [a, b, c, d, e] [f, g, h, i, j, k, l, m]
//                  ^    
//              Maintenant  

namespace FR_1913_BoxOffice
{
    public class StatsFilm
    {
        private Stack<StatHebdo> avant = new Stack<StatHebdo>();
        private LinkedList<StatHebdo> apres = new LinkedList<StatHebdo>();

        public StatsFilm(Film film)
        {
            Film = film;
        }
        public Film Film { get; private set; }

        public void AjouterStats(int noSemaine, long nbCinemas, DateTime date)
        {
            apres.AddLast(new StatHebdo(noSemaine, nbCinemas, date));
        }

        public DateTime Maintenant
        {
            get => apres.Count == 0 ? avant.Peek().Date : apres.First.Value.Date;
            set
            {
                while (value < Maintenant && avant.Count > 0)
                {
                    apres.AddFirst(avant.Pop());
                }
                while (value > Maintenant && apres.Count > 0)
                {
                    avant.Push(apres.First.Value);
                    apres.RemoveFirst();
                }
            }
        }
        public long Total
        {
            get => (from stat in avant select stat.NbCinemas).Sum();
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
