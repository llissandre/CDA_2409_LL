using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_LINQ
{
    public static class JeuDonnees
    {

        public static IEnumerable<Personne> GetPersonnes()
        {

            Personne p1 = new Personne("Aglur", "Jean", Sexe.MASCULIN, new DateTime(1980, 11, 12));
            Personne p2 = new Personne("Adams", "Emilie", Sexe.FEMININ, new DateTime(2006, 04, 12));
            Personne p3 = new Personne("Glub", "Kevin", Sexe.MASCULIN, new DateTime(2010, 3, 30));
            Personne p4 = new Personne("APRIUD", "Chloé", Sexe.FEMININ, new DateTime(2010, 3, 30));
            Personne p5 = new Personne("Flin", "Christophe", Sexe.MASCULIN, new DateTime(1955, 06, 23));

            Voiture v1 = new Voiture("VOIT1", "Rouge", 100);
            Voiture v2 = new Voiture("VOIT2", "Vert", 300);
            Voiture v3 = new Voiture("VOIT3", "Bleue", 44);
            Voiture v4 = new Voiture("VOIT4", "Rouge", 180);
            Voiture v5 = new Voiture("VOIT5", "Vert", 10000);
            Voiture v6 = new Voiture("VOIT6", "Vert", 25000);
            Voiture v7 = new Voiture("VOIT7", "Rouge", 45000);
            Voiture v8 = new Voiture("VOIT8", "Bleue", 33);

            p1.AjouterVoiture(v1);
            p1.AjouterVoiture(v2);

            p3.AjouterVoiture(v3);
            p3.AjouterVoiture(v4);
            p3.AjouterVoiture(v5);

            p4.AjouterVoiture(v6);
            p4.AjouterVoiture(v7);

            p5.AjouterVoiture(v8);

            return new List<Personne>() { p1, p2, p3, p4, p5 };
        }

        public static void Afficher<T>(String titre, IEnumerable<T> items)
        {
            Console.WriteLine("--- " + titre);
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void Afficher<T>(String titre, T item)
        {
            Console.WriteLine("--- " + titre + " ---");
            Console.WriteLine(item);
            Console.WriteLine();
        }

    }
}
