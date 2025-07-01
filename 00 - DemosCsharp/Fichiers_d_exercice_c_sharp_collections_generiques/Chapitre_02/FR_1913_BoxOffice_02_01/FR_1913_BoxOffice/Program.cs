using System;
using System.IO;
using System.Globalization;
using System.Diagnostics;

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
            var catalogue = new Catalogue();
            var noLigne = 1;

            Console.WriteLine("+------------------------------------------+-----+--------+------------+");
            foreach (var ligne in File.ReadLines("movieweekend.dat.txt"))
            {
                var champs = ligne.Split('\t');

                try
                {
                    var titre = champs[ChampNomFilm];
                    var date = DateTime.Parse(champs[ChampDate], CultureInfo.InvariantCulture);

                    catalogue.Ajouter(titre, date);
                    Console.WriteLine(
                        "| {0,-40} | {1,3} | {2,6} | {3:d} |",
                        titre,
                        int.Parse(champs[ChampNoSemaine]),
                        long.Parse(champs[ChampNbCinemas]),
                        date
                    );
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
            Console.WriteLine("+------------------------------------------+-----+--------+------------+");
            Console.WriteLine();
            Console.WriteLine("+------------------------------------------+------------+");
            foreach (var f in catalogue.Tout)
            {
                if(f != null)
                {
                    Console.WriteLine("| {0,-40} | {1:d} |", f.Titre, f.DateDeSortie);
                }                
            }
            Console.WriteLine("+------------------------------------------+------------+");
            Console.ReadLine();
        }
    }
}
