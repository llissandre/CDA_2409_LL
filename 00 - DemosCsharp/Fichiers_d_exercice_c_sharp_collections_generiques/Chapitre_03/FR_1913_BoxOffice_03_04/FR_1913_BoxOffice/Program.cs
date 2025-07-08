using System;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Collections.Generic;

namespace FR_1913_BoxOffice
{
    class Program
    {
        // Données : http://ww2.amstat.org/publications/jse/datasets/movieweekend.dat.txt
        const int
            ChampNomFilm = 1,
            ChampNoSemaine = 2,
            ChampNbCinemas = 3,
            ChampDate = 4;

        static void Main(string[] args)
        {
            StatsFilm statCourante = null;
            var lesStats = new List<StatsFilm>();
            var catalogue = new Catalogue();
            var noLigne = 1;
            
            foreach (var ligne in File.ReadLines("movieweekend.dat.txt").Skip(1).Where(l => l.Trim().Length>0))
            {
                var champs = ligne.Split('\t');
                
                try
                {
                    var titre = champs[ChampNomFilm];
                    var date = DateTime.Parse(champs[ChampDate], CultureInfo.InvariantCulture);

                    if(catalogue.Ajouter(titre, date))
                    {
                        statCourante = new StatsFilm(catalogue[titre]);
                        lesStats.Add(statCourante);
                    }
                    statCourante.AjouterStats(int.Parse(champs[ChampNoSemaine]), long.Parse(champs[ChampNbCinemas]), date);                    
                }
                catch (IndexOutOfRangeException e)
                {
                    Trace.WriteLine($"Ligne {noLigne} - Nombre de données : { e.Message }");
                }
                catch (FormatException e)
                {
                    Trace.WriteLine($"Ligne {noLigne} - Format de donnée : { e.Message }");
                }
                noLigne++;
            }

            lesStats.Sort((s1, s2) => -s1.Total.CompareTo(s2.Total));
            Console.WriteLine("+------------------------------------------+------------+------------+");
            foreach (var stat in lesStats)
            {
                if (stat.Total > 0)
                {
                    Console.WriteLine("| {0,-40} | {1,10} | {2:d} |", stat.Film.Titre, stat.Total, stat.Film.DateDeSortie);
                }
            }
            Console.WriteLine("+------------------------------------------+------------+------------+");
            Console.ReadLine();
        }
    }
}
